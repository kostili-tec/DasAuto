using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

/* для чего будет использоваться авто: езда по городу, езда за городом, такси, грузоперевозки
 * цена * 
 * кузов
 * коробка * 
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
            public string rPriceClass, rPriceClassMin; // цена
            public string rBodyCheck = null;
            public string rTrans = null;
            public string rDrive = null;
            //public int trackMinValue, trackMaxValue;
        }

        GlobalVars vars = new GlobalVars();

        public void TabPrice() // чек цены
        {

            if (rBprice1.Checked)
            {
                vars.rPriceClass = "Price < 1600000";
                vars.rPriceClassMin = " AND Price > 0";
            }
            if (rBprice2.Checked)
            {
                vars.rPriceClass = "Price < 2500000";
                vars.rPriceClassMin = " AND Price > 1600000";
            }
            if (rBprice3.Checked)
            {
                vars.rPriceClass = "Price < 6000000";
                vars.rPriceClassMin = " AND Price > 2500000";
            }
            if (rBprice4.Checked)
            {
                vars.rPriceClass = "Price < 999999999";
                vars.rPriceClassMin = " AND Price > 6000000";
            }
          }

        public void TabBody()
        {
            if (rBbodyCoupe.Checked)
                vars.rBodyCheck = " AND Body = 'Купе'";

            if (rBbodyHatch.Checked)
                vars.rBodyCheck = " AND Body = 'Хэтчбек'";

            if (rBbodySedan.Checked)
                vars.rBodyCheck = " AND Body = 'Седан'";

            if (rBbodyMinivan.Checked)
                vars.rBodyCheck = " AND Body = 'Минивен'";

            if (rBbodySUV.Checked)
                vars.rBodyCheck = " AND Body = 'Внедорожник'";

            if (rBbodyWagon.Checked)
                vars.rBodyCheck = " AND Body = 'Универсал'";

            if (rBbodyFurgon.Checked)
                vars.rBodyCheck = " AND Body = 'Фургон'";

            if (rBbodyAny.Checked)
                vars.rBodyCheck = "";
        }
        public void TabTrans()
        {
            if (rBtrans1.Checked)
                vars.rTrans = " AND Transmission = 'Механика'";

            if (rBtrans2.Checked)
                vars.rTrans = " AND Transmission = 'Автомат'";

            if (rBtrans3.Checked)
                vars.rTrans = " AND Transmission = 'Робот'";

            if (rBtrans4.Checked)
                vars.rTrans = " AND Transmission = 'Вариатор'";

            if (rBtransAny.Checked)
                vars.rTrans = ""; //" AND Transmission = 'Механика' OR Transmission = 'Автомат' OR Transmission = 'Робот' OR Transmission = 'Вариатор'"; // пока хз
        }

        public void TabDrive()
        {
            if (rBdriveCity.Checked)
                vars.rDrive = " AND TypeCity = true";

            if (rBdriveNature.Checked)
                vars.rDrive = " AND TypeDirt = true";

            if (rBdriveDach.Checked)
                vars.rDrive = " AND TypeDach = true";

            if (rBdriveTravel.Checked)
                vars.rDrive = " AND TypeTravel = true";

            if (rBdriveFast.Checked)
                vars.rDrive = " AND TypeFast = true";

        }


        public void Sql_getter()   //SQL запросы
        {
            TabPrice();
            TabBody();
            TabTrans();
            TabDrive();
            listBox1.Items.Clear();
            
            string strPr2 = vars.strPr;

            /* string query = "SELECT name_mark, Model, Body, Transmission, Price FROM Model WHERE Price < " + vars.rPriceClass.ToString() + " AND Price > " + vars.rPriceClassMin.ToString() + " AND Body = " 
                                  + vars.rBodyCheck.ToString() + " AND (Transmission = " + vars.rTrans + ")"; */

           // string query = "SELECT name_mark, Model, Body, Transmission, Price FROM Model WHERE " + vars.rPriceClass.ToString() + vars.rPriceClassMin.ToString() + vars.rDrive.ToString();

            string query = "SELECT name_mark, Model, Body, Transmission, Price FROM Model WHERE " + vars.rPriceClass.ToString() + vars.rPriceClassMin.ToString() + vars.rBodyCheck.ToString() + vars.rTrans.ToString() + vars.rDrive.ToString();
            strPr2 = query;
            
                OleDbCommand command = new OleDbCommand(strPr2, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + " ₽ ");
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
            tabPage1.Appe;
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
