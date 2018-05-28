using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace LA_Shtokal
{
    class Input_Data
    {
        private  string code = "";

        private  Dictionary<int, string> lexemTable = new Dictionary<int, string>();

        private  

        protected  Dictionary<string, Regex> symbolTable = new Dictionary<string, Regex>();
 
        protected int[,] automat_table;

        protected enum ChCl
        {
            letter,digit,separ_one, separ_logic, equare,space,other
        }

        protected Input_Data(string code_program):this()
        {
            code = code_program;
        }
        protected Input_Data()
        {
            code = "Program qq;";

            InitLexemTable();
            InitSymbolTable();

            automat_table = new int[,] {{ 1, 2, -3,  3,  4, -6, -7 },
                                        { 1, 1, -1, -1, -1, -1, -1 },
                                        {-7, 2, -2, -2, -2, -2, -2 },
                                        {-5,-5, -5, -5, -4, -5, -5 },
                                        {-5,-5, -5, -5, -4, -5, -5 }};
        }

        private  void InitLexemTable()
        {
            lexemTable.Add(1, "Програма");
            lexemTable.Add(2, "змінні");
            lexemTable.Add(3, "початок");
            lexemTable.Add(4, "кінець");
            lexemTable.Add(5, "ціле");
            lexemTable.Add(6, "дійсне");
            lexemTable.Add(7, "символ");
            lexemTable.Add(8, "логічне");
            lexemTable.Add(9, "для");
            lexemTable.Add(10, "якщо");
            lexemTable.Add(11, "інакше");
            lexemTable.Add(12, "читати");
            lexemTable.Add(13, "писати");
            lexemTable.Add(14, "або");
            lexemTable.Add(15, "та");

            lexemTable.Add(16, ";");
            lexemTable.Add(17, ":");
            lexemTable.Add(18, ",");
            lexemTable.Add(19, "(");
            lexemTable.Add(20, ")");
            lexemTable.Add(21, "[");
            lexemTable.Add(22, "]");
            lexemTable.Add(23, "{");
            lexemTable.Add(24, "}");
            lexemTable.Add(25, "=");
            lexemTable.Add(26, "+");
            lexemTable.Add(27, "-");
            lexemTable.Add(28, "*");
            lexemTable.Add(29, ">");
            lexemTable.Add(30, "<");
            lexemTable.Add(31, ">=");
            lexemTable.Add(32, "<=");
            lexemTable.Add(33, "==");
            lexemTable.Add(34, "!=");
            lexemTable.Add(35, "!");
            lexemTable.Add(36, "^");
            lexemTable.Add(37, "ind");
            lexemTable.Add(38, "const");
        }
        private  void InitSymbolTable()
        {
            Regex letter = new Regex("[a-zA-Z]");
            Regex digit = new Regex("[0-9]");
            Regex separ_one = new Regex("[(|)|\\[|\\]|\\{|\\}|,|;|:|+|\\-|*|/|\\^|.]");
            Regex separ_logic = new Regex("[>|<|!]");
            Regex equare = new Regex("[=]");
            Regex space = new Regex(@"\s");

            symbolTable.Add("letter",letter);
            symbolTable.Add("digit", digit);
            symbolTable.Add("separ_one", separ_one);
            symbolTable.Add("separ_logic", separ_logic);
            symbolTable.Add("equare", equare);
            symbolTable.Add("space", space);

        }

        

    }
}