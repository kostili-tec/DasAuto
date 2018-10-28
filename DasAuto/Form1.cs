using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* цена
 * кузов
 * объем
 * мощь
 * 
 */

namespace DasAuto
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=autoDB.accdb;";

        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
            
        }
        int tabN;
        int tabSel;
        int rPrice = 0; int rPriceMin = 0;


        public class GlobalVars
        {
            public string strPr = null; public int rPriceClass, rPriceClassMin;
        }

        public void TabPrice() // чек цены
        {
            
            if (rBprice1.Checked)
            {
                rPrice = 1600000;
                rPriceMin = 0;
                Sql_getter(rPrice, rPriceMin);

            }
            if (rBprice2.Checked)
            {
                rPrice = 2500000;
                rPriceMin = 1600000;
                Sql_getter(rPrice, rPriceMin);
            }
            if (rBprice3.Checked || rBprice4.Checked)
            {
                rPrice = 6000000;
                rPriceMin = 2500000;
                Sql_getter(rPrice, rPriceMin);
            }
            
            textBox1.Text = rPrice.ToString() + " " + rPriceMin.ToString();

        }
        public void TabBody()
        {

        }

        public void Sql_getter(int VoidPrice, int VoidPriceMin)   //SQL запросы
        {
            listBox1.Items.Clear();

            GlobalVars vars = new GlobalVars();
            string strPr2 = vars.strPr;

            if (rBprice1.Checked || rBprice2.Checked || rBprice3.Checked)
           
            {

                string query = "SELECT name_mark, Model, Body, Price FROM Model WHERE price > " + VoidPriceMin.ToString() + " AND price < " + VoidPrice.ToString();
                strPr2 = query;
            }
             if (rBprice4.Checked)
            {
                string query = "SELECT name_mark, Model, Body, Price FROM Model WHERE price > " + VoidPrice.ToString();
                strPr2 = query;
            }
             
                OleDbCommand command = new OleDbCommand(strPr2, myConnection);
                OleDbDataReader reader = command.ExecuteReader();

                // textBox1.Text = command.ExecuteScalar().ToString();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + " ₽ ");
                }
                reader.Close();
            
        }

        public void Pb_count(int valueBar)  // загрузка
        {
            int count = 3;                      // колличество делений в загрузке
            progressBar1.Maximum = count;
            progressBar1.Value = valueBar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            rBprice1.Checked = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            tabN = tabControl1.SelectedIndex;
            tabN++;            
            
            if (tabN >= 4)
                tabN = 0;
            tabControl1.SelectedIndex = tabN;
            Pb_count(tabN);
            TabPrice();
            

        }

        private void DownButton1_Click(object sender, EventArgs e)
        {
            tabSel = tabControl1.SelectedIndex;
            tabSel--;
            if (tabSel < 0)
                tabSel = 3;
            tabControl1.SelectedIndex = tabSel;
            Pb_count(tabSel);
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void TestButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TabPrice();
            // string query = "SELECT Body FROM Model ORDER BY Price = ;";
            string query = "SELECT name_mark, Model, Body, Price FROM Model WHERE body = 'Седан'"; 

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

           // textBox1.Text = command.ExecuteScalar().ToString();

            while(reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + " ₽ ");
            }
            reader.Close();
        }
    }
}
