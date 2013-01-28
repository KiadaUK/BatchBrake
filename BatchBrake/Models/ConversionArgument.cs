using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchBrake.Models
{
    public class ConversionArgument
    {
        public string Command { get; set; }
        public string Argument { get; set; }
        public Dictionary<string, string> ArgumentDictionary { get; set; }  
    }
}
