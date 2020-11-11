using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class LogEntry
    {
        public string Message { get; set; }

        public int ErrorCode { get; set; }

        public DateTime TimeOfEvent { get; set; } = DateTime.UtcNow;
    }
}
