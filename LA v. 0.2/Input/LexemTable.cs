
using System.Collections.Generic;


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
