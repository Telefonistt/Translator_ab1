using System;
using System.Collections.Generic;
using System.Linq;


namespace LA_Shtokal
{
    public class LexAnalizShtokal
    {
        private string Code { get; set; }
        private Analiz Rezult { get; set; }

        public Error Error { get; private set; } = null;
        public List<RezultTable> RezultTable { get; private set; } = new List<RezultTable>();
        public List<IdentifiersTable> IdentifiersTable { get; private set; } = new List<IdentifiersTable>();
        public List<ConstTable> ConstTable { get; private set; } = new List<ConstTable>();

        public LexAnalizShtokal(string code)
        {
            if (code != null)
            {
                Code = code;
                Run(code);
            }
        }

        public bool Run(string code)
        {
            if (code != null) Code = code;
            
            try
            {
                Rezult = new Analiz(Code);
                Error = Rezult.Error;
                RezultTable = Rezult.RezultTable;
                IdentifiersTable = Rezult.IdentifiersTable;
                ConstTable = Rezult.ConstTable;

                return true;
            }
            catch
            {
                return false;
            }  
        }

        
    }
}
