using ACMS_ONLINE_APPLICATION.VendorService.Queries.GetDiagnosis;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetSetting
{
    public class GetSettingHandler : IRequestHandler<GetSettingQuery, ServiceResponse<List<GetSettingResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public GetSettingHandler(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<List<GetSettingResponse>>> Handle(GetSettingQuery request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<List<GetSettingResponse>>
            {
                Data = new List<GetSettingResponse>(),
                Success = true,
                MessageEn = "Data retrieved successfully"
            };
            try
            {
                var section = _configuration.GetSection("online_setting");
                var settingNames = new List<string>();

                foreach (var setting in section.GetChildren())
                {
                    settingNames.Add(setting.Value);
                }

                var connectionString = _unitOfWork.getCurrentConnectionString();

                using (AdoHelper adoHelper = new(connectionString))
                {
                    var query = $@"
                    SELECT [item], [value], [text], [description]
                    FROM [acms_migration].[dbo].[Online_Settings]
                    WHERE [item] IN ({string.Join(",", settingNames.Select(s => $"'{s}'"))})
                ";

                    var result = adoHelper.ExecuteQueryList(query, reader =>
                    {
                        return new OnlineSetting
                        {
                            Name = reader["item"]?.ToString(),
                            Value = reader["value"]?.ToString(),
                            Text = reader["text"]?.ToString()
                        };
                    });

                    var maxDaysQuery = @"
SELECT [value]
FROM [acms_migration].[dbo].[Online_Settings]
WHERE [item] = 'MaxDays'
";

                   
                    var maxDaysValue = adoHelper.ExecuteQuery(maxDaysQuery, reader => reader["value"]?.ToString());

               
                    int.TryParse(maxDaysValue, out int maxDays);

                 
                    response.Data.Add(new GetSettingResponse
                    {
                        CurrentDate = DateTime.Now,
                        MaxDays = maxDays > 0 ? maxDays : 0, 
                        OnlineSettings = result.ToList()
                    });

                }
            }
            catch (SqlException sqlEx)
            {
                response.Success = false;
                response.MessageEn = $"A database error occurred: {sqlEx.Message}";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.MessageEn = $"An error occurred while retrieving data: {ex.Message}";
            }

            return response;
        }
    }
}
