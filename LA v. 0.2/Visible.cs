using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_Shtokal
{
    public partial class Visible : Form
    {
        string code="";
        public Visible()
        {
            InitializeComponent();
        }

        private void Visible_Load(object sender, EventArgs e)
        {
            string path= Application.StartupPath.ToString();
            try
            {
                code = System.IO.File.ReadAllText($@"{path}\program.txt");
            }
            catch
            {

            }
             
            textBox1.Text = code;
        }

        private void Run()
        {
            Analiz test = new Analiz(code);
            if(test.Error!=null)
            {
                MessageBox.Show("Помилка! Рядок " + test.Error.Row.ToString() + ". Колонка " + test.Error.Column.ToString()+"\n"+test.Error.Message);
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            for (int i=0;i<test.RezultTable.Count;i++)
            {
                dataGridView1.Rows.Add(test.RezultTable[i].row, test.RezultTable[i].lexem, test.RezultTable[i].code, test.RezultTable[i].indexConst==0?"": test.RezultTable[i].indexConst.ToString());
            }

            for (int i = 0; i < test.IdentifiersTable.Count; i++)
            {
                dataGridView2.Rows.Add(test.IdentifiersTable[i].idn, test.IdentifiersTable[i].index);
            }

            for (int i = 0; i < test.ConstTable.Count; i++)
            {
                dataGridView3.Rows.Add(test.ConstTable[i].constant, test.ConstTable[i].index);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            code = textBox1.Text;
            Run();
        }
    }
}
