using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns
{
    public class Journal
    {
        private List<string> entries = new List<string>();
        public int count { get; set; }
    }
}
