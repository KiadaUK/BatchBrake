using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchBrake.Models
{
    public class BasicFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FullPathAndName { get; set; }
        public string Extension { get; set; }
        public double Size { get; set; }
    }
}
