using CaptainsLog.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainsLog
{
    public class Log
    {
        public Log(string title)
        {
            Title = title;
            Entries = new ObservableCollection<LogEntry>();
        }
        public string Title { get;  private set; }
         public ObservableCollection<LogEntry> Entries { get; set; }
    }

}