namespace DasAuto
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.NextButton = new System.Windows.Forms.Button();
            this.DownButton1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rBprice4 = new System.Windows.Forms.RadioButton();
            this.rBprice3 = new System.Windows.Forms.RadioButton();
            this.rBprice2 = new System.Windows.Forms.RadioButton();
            this.rBprice1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rBbodyWagon = new System.Windows.Forms.RadioButton();
            this.rBbodyHatch = new System.Windows.Forms.RadioButton();
            this.rBbodyMinivan = new System.Windows.Forms.RadioButton();
            this.rBbodySUV = new System.Windows.Forms.RadioButton();
            this.rBbodySedan = new System.Windows.Forms.RadioButton();
            this.rBbodyCoupe = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rBtrans4 = new System.Windows.Forms.RadioButton();
            this.rBtrans3 = new System.Windows.Forms.RadioButton();
            this.rBtrans2 = new System.Windows.Forms.RadioButton();
            this.rBtrans1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.rBtransAny = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 583);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(261, 277);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // DownButton1
            // 
            this.DownButton1.Location = new System.Drawing.Point(86, 277);
            this.DownButton1.Name = "DownButton1";
            this.DownButton1.Size = new System.Drawing.Size(75, 23);
            this.DownButton1.TabIndex = 3;
            this.DownButton1.Text = "Назад";
            this.DownButton1.UseVisualStyleBackColor = true;
            this.DownButton1.Click += new System.EventHandler(this.DownButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(82, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 238);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rBprice4);
            this.tabPage1.Controls.Add(this.rBprice3);
            this.tabPage1.Controls.Add(this.rBprice2);
            this.tabPage1.Controls.Add(this.rBprice1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rBprice4
            // 
            this.rBprice4.AutoSize = true;
            this.rBprice4.Location = new System.Drawing.Point(267, 106);
            this.rBprice4.Name = "rBprice4";
            this.rBprice4.Size = new System.Drawing.Size(120, 17);
            this.rBprice4.TabIndex = 4;
            this.rBprice4.TabStop = true;
            this.rBprice4.Text = "Свыше 6 000 000 ₽";
            this.rBprice4.UseVisualStyleBackColor = true;
            // 
            // rBprice3
            // 
            this.rBprice3.AutoSize = true;
            this.rBprice3.Location = new System.Drawing.Point(31, 106);
            this.rBprice3.Name = "rBprice3";
            this.rBprice3.Size = new System.Drawing.Size(97, 17);
            this.rBprice3.TabIndex = 3;
            this.rBprice3.TabStop = true;
            this.rBprice3.Text = "до 6 000 000 ₽";
            this.rBprice3.UseVisualStyleBackColor = true;
            // 
            // rBprice2
            // 
            this.rBprice2.AutoSize = true;
            this.rBprice2.Location = new System.Drawing.Point(267, 46);
            this.rBprice2.Name = "rBprice2";
            this.rBprice2.Size = new System.Drawing.Size(97, 17);
            this.rBprice2.TabIndex = 2;
            this.rBprice2.TabStop = true;
            this.rBprice2.Text = "до 2 500 000 ₽";
            this.rBprice2.UseVisualStyleBackColor = true;
            // 
            // rBprice1
            // 
            this.rBprice1.AutoSize = true;
            this.rBprice1.Location = new System.Drawing.Point(31, 46);
            this.rBprice1.Name = "rBprice1";
            this.rBprice1.Size = new System.Drawing.Size(97, 17);
            this.rBprice1.TabIndex = 1;
            this.rBprice1.TabStop = true;
            this.rBprice1.Text = "до 1 600 000 ₽";
            this.rBprice1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена автомобиля:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rBbodyWagon);
            this.tabPage2.Controls.Add(this.rBbodyHatch);
            this.tabPage2.Controls.Add(this.rBbodyMinivan);
            this.tabPage2.Controls.Add(this.rBbodySUV);
            this.tabPage2.Controls.Add(this.rBbodySedan);
            this.tabPage2.Controls.Add(this.rBbodyCoupe);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rBbodyWagon
            // 
            this.rBbodyWagon.AutoSize = true;
            this.rBbodyWagon.Location = new System.Drawing.Point(250, 92);
            this.rBbodyWagon.Name = "rBbodyWagon";
            this.rBbodyWagon.Size = new System.Drawing.Size(81, 17);
            this.rBbodyWagon.TabIndex = 6;
            this.rBbodyWagon.TabStop = true;
            this.rBbodyWagon.Text = "Универсал";
            this.rBbodyWagon.UseVisualStyleBackColor = true;
            // 
            // rBbodyHatch
            // 
            this.rBbodyHatch.AutoSize = true;
            this.rBbodyHatch.Location = new System.Drawing.Point(39, 92);
            this.rBbodyHatch.Name = "rBbodyHatch";
            this.rBbodyHatch.Size = new System.Drawing.Size(66, 17);
            this.rBbodyHatch.TabIndex = 5;
            this.rBbodyHatch.TabStop = true;
            this.rBbodyHatch.Text = "Хэтчбек";
            this.rBbodyHatch.UseVisualStyleBackColor = true;
            // 
            // rBbodyMinivan
            // 
            this.rBbodyMinivan.AutoSize = true;
            this.rBbodyMinivan.Location = new System.Drawing.Point(250, 133);
            this.rBbodyMinivan.Name = "rBbodyMinivan";
            this.rBbodyMinivan.Size = new System.Drawing.Size(70, 17);
            this.rBbodyMinivan.TabIndex = 4;
            this.rBbodyMinivan.TabStop = true;
            this.rBbodyMinivan.Text = "Минивен";
            this.rBbodyMinivan.UseVisualStyleBackColor = true;
            // 
            // rBbodySUV
            // 
            this.rBbodySUV.AutoSize = true;
            this.rBbodySUV.Location = new System.Drawing.Point(39, 133);
            this.rBbodySUV.Name = "rBbodySUV";
            this.rBbodySUV.Size = new System.Drawing.Size(94, 17);
            this.rBbodySUV.TabIndex = 3;
            this.rBbodySUV.TabStop = true;
            this.rBbodySUV.Text = "Внедорожник";
            this.rBbodySUV.UseVisualStyleBackColor = true;
            // 
            // rBbodySedan
            // 
            this.rBbodySedan.AutoSize = true;
            this.rBbodySedan.Location = new System.Drawing.Point(250, 49);
            this.rBbodySedan.Name = "rBbodySedan";
            this.rBbodySedan.Size = new System.Drawing.Size(56, 17);
            this.rBbodySedan.TabIndex = 2;
            this.rBbodySedan.TabStop = true;
            this.rBbodySedan.Text = "Седан";
            this.rBbodySedan.UseVisualStyleBackColor = true;
            // 
            // rBbodyCoupe
            // 
            this.rBbodyCoupe.AutoSize = true;
            this.rBbodyCoupe.Location = new System.Drawing.Point(39, 49);
            this.rBbodyCoupe.Name = "rBbodyCoupe";
            this.rBbodyCoupe.Size = new System.Drawing.Size(49, 17);
            this.rBbodyCoupe.TabIndex = 1;
            this.rBbodyCoupe.TabStop = true;
            this.rBbodyCoupe.Text = "Купе";
            this.rBbodyCoupe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Какой кузов автомобиля вы предпочитаете?";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rBtransAny);
            this.tabPage3.Controls.Add(this.rBtrans4);
            this.tabPage3.Controls.Add(this.rBtrans3);
            this.tabPage3.Controls.Add(this.rBtrans2);
            this.tabPage3.Controls.Add(this.rBtrans1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(599, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rBtrans4
            // 
            this.rBtrans4.AutoSize = true;
            this.rBtrans4.Location = new System.Drawing.Point(287, 107);
            this.rBtrans4.Name = "rBtrans4";
            this.rBtrans4.Size = new System.Drawing.Size(73, 17);
            this.rBtrans4.TabIndex = 4;
            this.rBtrans4.TabStop = true;
            this.rBtrans4.Text = "Вариатор";
            this.rBtrans4.UseVisualStyleBackColor = true;
            // 
            // rBtrans3
            // 
            this.rBtrans3.AutoSize = true;
            this.rBtrans3.Location = new System.Drawing.Point(50, 107);
            this.rBtrans3.Name = "rBtrans3";
            this.rBtrans3.Size = new System.Drawing.Size(55, 17);
            this.rBtrans3.TabIndex = 3;
            this.rBtrans3.TabStop = true;
            this.rBtrans3.Text = "Робот";
            this.rBtrans3.UseVisualStyleBackColor = true;
            // 
            // rBtrans2
            // 
            this.rBtrans2.AutoSize = true;
            this.rBtrans2.Location = new System.Drawing.Point(287, 62);
            this.rBtrans2.Name = "rBtrans2";
            this.rBtrans2.Size = new System.Drawing.Size(68, 17);
            this.rBtrans2.TabIndex = 2;
            this.rBtrans2.TabStop = true;
            this.rBtrans2.Text = "Автомат";
            this.rBtrans2.UseVisualStyleBackColor = true;
            // 
            // rBtrans1
            // 
            this.rBtrans1.AutoSize = true;
            this.rBtrans1.Location = new System.Drawing.Point(50, 62);
            this.rBtrans1.Name = "rBtrans1";
            this.rBtrans1.Size = new System.Drawing.Size(75, 17);
            this.rBtrans1.TabIndex = 1;
            this.rBtrans1.TabStop = true;
            this.rBtrans1.Text = "Механика";
            this.rBtrans1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип коробки";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(599, 212);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Мощь";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(86, 386);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 108);
            this.listBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вам подходит:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 20);
            this.textBox1.TabIndex = 8;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(426, 277);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 9;
            this.CheckButton.Text = "CHECK";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // rBtransAny
            // 
            this.rBtransAny.AutoSize = true;
            this.rBtransAny.Location = new System.Drawing.Point(175, 153);
            this.rBtransAny.Name = "rBtransAny";
            this.rBtransAny.Size = new System.Drawing.Size(59, 17);
            this.rBtransAny.TabIndex = 5;
            this.rBtransAny.TabStop = true;
            this.rBtransAny.Text = "Любая";
            this.rBtransAny.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 615);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DownButton1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Экспертная система выбора  легкового автомобиля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button DownButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBprice4;
        private System.Windows.Forms.RadioButton rBprice3;
        private System.Windows.Forms.RadioButton rBprice2;
        private System.Windows.Forms.RadioButton rBprice1;
        private System.Windows.Forms.RadioButton rBbodyMinivan;
        private System.Windows.Forms.RadioButton rBbodySUV;
        private System.Windows.Forms.RadioButton rBbodySedan;
        private System.Windows.Forms.RadioButton rBbodyCoupe;
        private System.Windows.Forms.RadioButton rBtrans4;
        private System.Windows.Forms.RadioButton rBtrans3;
        private System.Windows.Forms.RadioButton rBtrans2;
        private System.Windows.Forms.RadioButton rBtrans1;
        private System.Windows.Forms.RadioButton rBbodyWagon;
        private System.Windows.Forms.RadioButton rBbodyHatch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RadioButton rBtransAny;
    }
}

