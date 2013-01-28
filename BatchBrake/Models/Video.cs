using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchBrake.Models
{
    public class Video : BasicFile
    {
        public decimal Length { get; set; }
        public Format VideosSourceFormat { get; set; }
    }
}
