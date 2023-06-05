using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPooling.Contracts
{
    public interface ILog
    {
       //Function to wirte the Error logs to the File 
        bool AddErrorLog( string errorSource ,string message);
    }
}
