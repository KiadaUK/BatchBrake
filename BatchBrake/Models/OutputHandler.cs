using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchBrake.Models
{
    public class OutputHandler
    {
        public Video CurrentVideo { get; set; }
        public string StandardOutputText { get; set; }
        public Label OutputLabelControl { get; set; }
    }
}
