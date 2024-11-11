//using IQHealthCareMobile.Api.Core.Interfaces;

//namespace ACMS_ONLINE_INFRASTRUCTURE.Services
//{
//    public class ExceptionLogging : Exception
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        public ExceptionLogging(IUnitOfWork unitOfWork)
//        {
//            _unitOfWork = unitOfWork;
//        }

//        private static string ErrorlineNo, Errormsg, extype, exurl, ErrorLocation, hostIp, HostAdd;

//        public static void SendErrorToText(Exception ex, HttpContext context, string fileName)
//        {
//            var line = Environment.NewLine + Environment.NewLine;

//            ErrorlineNo = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
//            Errormsg = ex.GetType().Name.ToString();
//            extype = ex.GetType().ToString();
//            exurl = context.Request.Path.ToString();
//            ErrorLocation = ex.Message.ToString();


//            try
//            {

//                string filepath = Path.Combine(context.Request.PathBase, "ExceptionDetailsFile"); // Text File Path

//                if (!Directory.Exists(filepath))
//                {
//                    Directory.CreateDirectory(filepath);
//                }

//                filepath = Path.Combine(filepath, fileName + ".txt"); // Text File Name

//                if (!File.Exists(filepath))
//                {
//                    File.Create(filepath).Dispose();
//                }

//                using (StreamWriter sw = File.AppendText(filepath))
//                {
//                    string error = $"Log Written Date: {DateTime.Now.ToString()}{line}Error Line No: {ErrorlineNo}{line}Error Message: {Errormsg}{line}Exception Type: {extype}{line}Error Location: {ErrorLocation}{line}Error Page Url: {exurl}{line}User Host IP: {context.Connection.RemoteIpAddress}{line}";

//                    sw.WriteLine($"-----------Exception Details on {DateTime.Now.ToString()}-----------------");
//                    sw.WriteLine("-------------------------------------------------------------------------------------");
//                    sw.WriteLine(line);
//                    sw.WriteLine(error);
//                    sw.WriteLine($"UserId:  {context.User.Identity.Name}");
//                    sw.WriteLine("--------------------------------*End*------------------------------------------");
//                    sw.WriteLine(line);
//                    sw.Flush();
//                }

//            }
//            catch (Exception e)
//            {
//                e.ToString();
//            }


//        }
//    }

//}
