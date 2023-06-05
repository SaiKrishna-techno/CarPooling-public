using CarPooling.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CarPooling.Services
{
    public class LoggerServices : ILog
    {
        private string FilePath { get; set; } = "C:\\Users\\ivsds\\task-5-car-pooling-web-api-csharp-SaiKrishna-techno\\CarPoolingTask\\CarPooling\\Logs\\logs.txt";
        public bool AddErrorLog(string errorSource, string message)
        {
            try
            {
                using (System.IO.StreamWriter writer = System.IO.File.AppendText(this.FilePath))
                {
                    writer.WriteLine("-----------------------------------------------------");
                    writer.WriteLine("Error Log Entry: ");
                    writer.WriteLine("Time  : "+DateTime.Now.ToLongDateString() +", "+ DateTime.Now.ToLongTimeString());
                    writer.WriteLine("Error " + message);
                    writer.WriteLine("Error Source " + errorSource);
                    writer.WriteLine("-----------------------------------------------------");
                    writer.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
