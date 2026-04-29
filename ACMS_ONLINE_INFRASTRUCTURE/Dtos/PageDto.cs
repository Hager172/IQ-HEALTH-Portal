using System;
using System.Collections.Generic;
using System.Text;

namespace ACMS_ONLINE_INFRASTRUCTURE.Dtos
{
    public class PageDto
    {
        public int PageId { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public bool View { get; set; }
        public bool Add { get; set; }
        public bool Edit { get; set; }



        public bool Submit { get; set; }
        public bool Unsubmit { get; set; }
        public bool Cancel { get; set; }


        public bool Import { get; set; }
        public bool Export { get; set; }
        public bool Print { get; set; }
        public bool SpacialCase { get; set;} 
    }
}
