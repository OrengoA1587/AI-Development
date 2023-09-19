using System.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

namespace BlazerUI.Data
{
    public class GetKey
    {
        private string _key = "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";

        
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        

    }
}
