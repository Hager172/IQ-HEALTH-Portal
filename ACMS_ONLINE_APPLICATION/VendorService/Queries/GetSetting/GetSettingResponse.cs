using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.VendorService.Queries.GetSetting
{
    public class GetSettingResponse
    {
        
        public DateTime CurrentDate { get; set; }

      
        public int MaxDays { get; set; }

        
        public List<OnlineSetting> OnlineSettings { get; set; } = new List<OnlineSetting>();
    }

    
    public class OnlineSetting
    {
            
        public string Name { get; set; }  
        public string Value { get; set; } 
        public string Text { get; set; }  
    }

}
