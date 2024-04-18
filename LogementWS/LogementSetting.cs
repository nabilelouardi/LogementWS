using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogementWS
{

    // commetairre Neo
 
        public class LogementsSetting : ILogementsSettings
        {
            public string LogementCollection { get; set; }
            public string ConnectionString { get; set; }
            public string DatabaseName { get; set; }
        }

        public interface ILogementsSettings
    {
            string LogementCollection { get; set; }
            string ConnectionString { get; set; }
            string DatabaseName { get; set; }
        }
   
}
