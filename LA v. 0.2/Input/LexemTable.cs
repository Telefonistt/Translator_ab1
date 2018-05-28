using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_Shtokal
{
    public class LexemTable:Dictionary<int,string>
    {
        private int index=0;

        public int AddLex(string lex)
        {
            int tempIndex = index;
            this.Add(index, lex);
            index++;
            return tempIndex;
        }
    }
}
