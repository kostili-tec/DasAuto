using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            
        }
        int tabN;
        int tabSel;

        public void TabSelector()
        {
            //tabSel = tabControl1.SelectedIndex;
        }

        public void pb_count(int valueBar)  // загрузка
        {
            int count = 3;                      // колличество делений в загрузке
            progressBar1.Maximum = count;
            progressBar1.Value = valueBar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            tabN = tabControl1.SelectedIndex;
            tabN++;            
            
            if (tabN >= 4)
                tabN = 0;
            tabControl1.SelectedIndex = tabN;
            pb_count(tabN);

        }

        private void DownButton1_Click(object sender, EventArgs e)
        {
            tabSel = tabControl1.SelectedIndex;
            tabSel--;
            if (tabSel < 0)
                tabSel = 3;
            tabControl1.SelectedIndex = tabSel;
            pb_count(tabSel);
            

        }
    }
}
