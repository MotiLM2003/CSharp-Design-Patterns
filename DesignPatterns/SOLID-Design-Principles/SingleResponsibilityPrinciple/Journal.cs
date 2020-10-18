using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns
{
    public class Journal
    {


        private List<string> entries = new List<string>();
        private int count { get; set; }

        public int AddEntry(string text)
        {
            entries.Add($"{++count} {text}");
            return count; // memnto;
        }

        public void RemoveEntry(int index )
        {
            entries.RemoveAt(index);
            count--;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}
