using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_v._0._2
{
    public class LexemTable:Dictionary<int,string>
    {
        private int index=0;

        public void AddLex(string lex)
        {
            this.Add(index, lex);
            index++;
        }
    }
}
