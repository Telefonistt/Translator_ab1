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
        protected  string code = "";

        //protected readonly  Dictionary<int, string> lexemTable1 = new Dictionary<int, string>();

        protected LexemTable lexemTable = new LexemTable();

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

        private  int InitLexemTable()
        {
            lexemTable.AddLex("Програма");
            lexemTable.AddLex("змінні");
            lexemTable.AddLex("початок");
            lexemTable.AddLex("кінець");
            lexemTable.AddLex("ціле");
            lexemTable.AddLex("дійсне");
            lexemTable.AddLex("символ");
            lexemTable.AddLex("логічне");
            lexemTable.AddLex("для");
            lexemTable.AddLex("якщо");
            lexemTable.AddLex("інакше");
            lexemTable.AddLex("читати");
            lexemTable.AddLex("писати");
            lexemTable.AddLex("або");
            lexemTable.AddLex("та");
            lexemTable.AddLex("перемога");
            lexemTable.AddLex("зрада");
            lexemTable.AddLex(";");
            lexemTable.AddLex(":");
            lexemTable.AddLex(",");
            lexemTable.AddLex("(");
            lexemTable.AddLex(")");
            lexemTable.AddLex("[");
            lexemTable.AddLex("]");
            lexemTable.AddLex("{");
            lexemTable.AddLex("}");
            lexemTable.AddLex("=");
            lexemTable.AddLex("+");
            lexemTable.AddLex("-");
            lexemTable.AddLex("*");
            lexemTable.AddLex(">");
            lexemTable.AddLex("<");
            lexemTable.AddLex(">=");
            lexemTable.AddLex("<=");
            lexemTable.AddLex("==");
            lexemTable.AddLex("!=");
            lexemTable.AddLex("!");
            lexemTable.AddLex("^");
            lexemTable.AddLex("ind");
            int count= lexemTable.AddLex("const");
            return count;
        }
        private  void InitSymbolTable()
        {
            Regex letter = new Regex("[_a-zA-ZАаБбВвГгҐґДдЕеЄєЖжЗзИиІіЇїЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЬьЮюЯя]");
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