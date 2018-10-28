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


        public class GlobalVars
        {
            public string strPr = null; // query для sql
            public int rPriceClass, rPriceClassMin; // цена
            public string rBodyCheck = null;
            public string rTrans = null;
        }

        GlobalVars vars = new GlobalVars();

        public void TabPrice() // чек цены
        {
            
            if (rBprice1.Checked)
            {
                vars.rPriceClass = 1600000;
                vars.rPriceClassMin = 0;
            }
            if (rBprice2.Checked)
            {
                vars.rPriceClass = 2500000;
                vars.rPriceClassMin = 1600000;
            }
            if (rBprice3.Checked)
            {
                vars.rPriceClass = 6000000;
                vars.rPriceClassMin = 2500000;
            } 
            if (rBprice4.Checked)
            {
                vars.rPriceClass = 999999999;
                vars.rPriceClassMin = 6000000;
            }
           // Sql_getter(); // вызов sql функции

            textBox1.Text = vars.rPriceClass.ToString() + " " + vars.rPriceClassMin.ToString();

        }
        public void TabBody()
        {
            if (rBbodyCoupe.Checked)
            {
                vars.rBodyCheck = "'Купэ'";
            }
            if (rBbodyHatch.Checked)
            {
                vars.rBodyCheck = "'Хэтчек'";
            }
            if (rBbodySedan.Checked)
            {
                vars.rBodyCheck = "'Седан'";
            }
            if (rBbodyMinivan.Checked)
            {
                vars.rBodyCheck = "'Мнивен'";
            }
            if (rBbodySUV.Checked)
            {
                vars.rBodyCheck = "'Внедорожник'";
            } 
            if (rBbodyWagon.Checked)
            {
                vars.rBodyCheck = "'Универсал'";
            }
        }
        public void TabTrans()
        {
            if (rBtrans1.Checked)
            {
                vars.rTrans = "'Механика'";
            }
            if (rBtrans2.Checked)
            {
                vars.rTrans = "'Автомат'";
            }
            if (rBtrans3.Checked)
            {
                vars.rTrans = "'Робот'";
            }
            if (rBtrans4.Checked)
            {
                vars.rTrans = "'Вариатор'";
            }
            if (rBtransAny.Checked)
            {
                vars.rTrans = "'Механика' OR Body = 'Автомат' OR Body = 'Робот' OR Body = 'Вариатор'"; // пока хз
            }
        }

        public void Sql_getter()   //SQL запросы
        {
            TabPrice();
            TabBody();
            TabTrans();
            listBox1.Items.Clear();
            
            string strPr2 = vars.strPr;

               // string query = "SELECT name_mark, Model, Body, Price FROM Model WHERE Price > " + vars.rPriceClass.ToString() + " AND Price < " + vars.rPriceClassMin.ToString() + " AND Body = " + vars.rBodyCheck.ToString();
               string query = "SELECT name_mark, Model, Body, Price FROM Model WHERE Price < " + vars.rPriceClass.ToString() + " AND Price > " + vars.rPriceClassMin.ToString() + " AND Body = " 
                                    + vars.rBodyCheck.ToString() + " AND Transmission = " + vars.rTrans;
                strPr2 = query;
            
                OleDbCommand command = new OleDbCommand(strPr2, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + " ₽ ");
                }
                reader.Close();
        }

        public void Pb_count(int valueBar)  // бар загрузки
        {
            int count = 3;                      // колличество делений в загрузке
            progressBar1.Maximum = count;
            progressBar1.Value = valueBar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            rBprice1.Checked = true;
            rBbodyCoupe.Checked = true;
            rBtrans1.Checked = true;
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

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Sql_getter();
        }
    }
}
