using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Data;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using ACMS_ONLINE_INFRASTRUCTURE.FunctionModels;

namespace ACMS_ONLINE_INFRASTRUCTURE.Repositories
{


    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        private readonly DbContext _context;
        public MemberRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<string> getMemberStautsAtDate(string MemberId, DateTime validAt)
        {

            string stats = "";
            using (AdoHelper adoHelper = new(_context.Database.GetConnectionString()))
            {

                
                string query = "select dbo.f_member_status_at_date('" + MemberId + "','" + validAt.ToString("yyyy-MM-dd H:mm:ss") + "')";


                var newStatus = adoHelper.ExecuteQuery(query, reader =>
                {
                    return new
                    {
                        stats = reader.GetString(0)

                    };
                });


                return newStatus.stats;
            }
            return stats;

        }


        public async Task<List<FGetMemberPlanItemResult>> FGetMemberPlanItems(string q, string planCode, string vendorId, int? category, string memberId)
        {


            var response = new List<FGetMemberPlanItemResult>();
            string query = $@"SELECT * FROM [dbo].[f_getMemberPlanItems] ('{q}','{planCode}','{vendorId}',{category},'{memberId}')";


            using (AdoHelper adoHelper = new(_context.Database.GetConnectionString()))
            {


                var result = adoHelper.ExecuteQueryList(query, reader =>
                {

                    var fGetMemberPlanItemResult = new FGetMemberPlanItemResult
                    {
                        med_item = reader["med_item"] != DBNull.Value ? Convert.ToInt32(reader["med_item"]) : 0,
                        med_item_name = reader["med_item_name"].ToString(),
                        pool = reader["pool"] != DBNull.Value && (bool)reader["pool"],
                        copay = reader["copay"] != DBNull.Value ? Convert.ToInt32(reader["copay"]) : 0,
                        //re_discount = reader["re_discount"] != DBNull.Value ? Convert.ToDouble(reader["re_discount"]): 0,
                        active = reader["active"] != DBNull.Value && (bool)reader["active"],
                    };

                    return fGetMemberPlanItemResult;
                });

                response = result;
            }


            return response;
        }


        //public async Task<Member> GetMemberByIdAsync(string id)
        //{

        //    //VendorId = "Hp00536";
        //    var member = new Member();
        //    using (AdoHelper adoHelper = new AdoHelper(_context.Database.GetConnectionString()))
        //    {

        //        // Step 2: Retrieve contract services based on vendor contract ID
        //        var query = $@"
        //                        SELECT 
        //                            M.member_id, 
        //                            M.member_name, 
        //                            M.member_customer_id, 
        //                            M.member_birthday, 
        //                            M.member_vip, 
        //                            M.member_tele, 
        //                            dbo.f_member_status_at_date(M.member_id, GETDATE()) AS member_statues,


        //                            M.member_parent, 
        //                            Parent.member_name AS parent_name ,
        //                            Customer.customer_name  

        //                         FROM Members M
        //                         LEFT JOIN Members Parent ON M.member_parent = Parent.member_id 
        //                         LEFT JOIN Customers Customer ON M.member_customer_id = Customer.customer_id 


        //                         WHERE M.member_id = '
        //        {id}'";

        //        member = adoHelper.ExecuteQuery(query, reader =>
        //        {
        //            return new Member()
        //            {
        //                MemberId = reader.GetString(0)

        //            };
        //        });



        //    }
        //    return member;
        //}
    }
}
