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
            this.rBdriveFast = new System.Windows.Forms.RadioButton();
            this.rBdriveNature = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rBdriveTravel = new System.Windows.Forms.RadioButton();
            this.rBdriveDach = new System.Windows.Forms.RadioButton();
            this.rBdriveCity = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rBbodyFurgon = new System.Windows.Forms.RadioButton();
            this.rBbodyAny = new System.Windows.Forms.RadioButton();
            this.rBbodyMicrobus = new System.Windows.Forms.RadioButton();
            this.rBbodyWagon = new System.Windows.Forms.RadioButton();
            this.rBbodyHatch = new System.Windows.Forms.RadioButton();
            this.rBbodyMinivan = new System.Windows.Forms.RadioButton();
            this.rBbodySUV = new System.Windows.Forms.RadioButton();
            this.rBbodySedan = new System.Windows.Forms.RadioButton();
            this.rBbodyCoupe = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rBtransAny = new System.Windows.Forms.RadioButton();
            this.rBtrans2 = new System.Windows.Forms.RadioButton();
            this.rBtrans1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rBprice4 = new System.Windows.Forms.RadioButton();
            this.rBprice3 = new System.Windows.Forms.RadioButton();
            this.rBprice2 = new System.Windows.Forms.RadioButton();
            this.rBprice1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.buttonToOrigin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(-531, 554);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(663, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(122, 218);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(91, 32);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Далее ⇨";
            this.NextButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // DownButton1
            // 
            this.DownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.DownButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.DownButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton1.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.DownButton1.ForeColor = System.Drawing.Color.White;
            this.DownButton1.Location = new System.Drawing.Point(12, 218);
            this.DownButton1.Name = "DownButton1";
            this.DownButton1.Size = new System.Drawing.Size(91, 32);
            this.DownButton1.TabIndex = 3;
            this.DownButton1.Text = "⇦ Назад";
            this.DownButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownButton1.UseVisualStyleBackColor = false;
            this.DownButton1.Click += new System.EventHandler(this.DownButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-5, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 179);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.tabPage1.Controls.Add(this.rBdriveFast);
            this.tabPage1.Controls.Add(this.rBdriveNature);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rBdriveTravel);
            this.tabPage1.Controls.Add(this.rBdriveDach);
            this.tabPage1.Controls.Add(this.rBdriveCity);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 150);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Езда";
            // 
            // rBdriveFast
            // 
            this.rBdriveFast.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBdriveFast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.rBdriveFast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.rBdriveFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBdriveFast.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBdriveFast.ForeColor = System.Drawing.Color.White;
            this.rBdriveFast.Location = new System.Drawing.Point(530, 60);
            this.rBdriveFast.Name = "rBdriveFast";
            this.rBdriveFast.Size = new System.Drawing.Size(93, 32);
            this.rBdriveFast.TabIndex = 6;
            this.rBdriveFast.Text = "Драйва";
            this.rBdriveFast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBdriveFast.UseVisualStyleBackColor = false;
            // 
            // rBdriveNature
            // 
            this.rBdriveNature.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBdriveNature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.rBdriveNature.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.rBdriveNature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBdriveNature.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBdriveNature.ForeColor = System.Drawing.Color.White;
            this.rBdriveNature.Location = new System.Drawing.Point(137, 60);
            this.rBdriveNature.Name = "rBdriveNature";
            this.rBdriveNature.Size = new System.Drawing.Size(96, 32);
            this.rBdriveNature.TabIndex = 5;
            this.rBdriveNature.Text = "Природы";
            this.rBdriveNature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBdriveNature.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Для чего преимущественно будет использоватсья автомобиль?";
            // 
            // rBdriveTravel
            // 
            this.rBdriveTravel.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBdriveTravel.AutoSize = true;
            this.rBdriveTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.rBdriveTravel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.rBdriveTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBdriveTravel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBdriveTravel.ForeColor = System.Drawing.Color.White;
            this.rBdriveTravel.Location = new System.Drawing.Point(390, 60);
            this.rBdriveTravel.Name = "rBdriveTravel";
            this.rBdriveTravel.Size = new System.Drawing.Size(112, 32);
            this.rBdriveTravel.TabIndex = 3;
            this.rBdriveTravel.Text = "Путешествий";
            this.rBdriveTravel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBdriveTravel.UseVisualStyleBackColor = false;
            // 
            // rBdriveDach
            // 
            this.rBdriveDach.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBdriveDach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.rBdriveDach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.rBdriveDach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBdriveDach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBdriveDach.ForeColor = System.Drawing.Color.White;
            this.rBdriveDach.Location = new System.Drawing.Point(267, 60);
            this.rBdriveDach.Name = "rBdriveDach";
            this.rBdriveDach.Size = new System.Drawing.Size(96, 32);
            this.rBdriveDach.TabIndex = 2;
            this.rBdriveDach.Text = "Дачи";
            this.rBdriveDach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBdriveDach.UseVisualStyleBackColor = false;
            // 
            // rBdriveCity
            // 
            this.rBdriveCity.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBdriveCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.rBdriveCity.Checked = true;
            this.rBdriveCity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.rBdriveCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBdriveCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBdriveCity.ForeColor = System.Drawing.Color.White;
            this.rBdriveCity.Location = new System.Drawing.Point(27, 60);
            this.rBdriveCity.Name = "rBdriveCity";
            this.rBdriveCity.Size = new System.Drawing.Size(82, 32);
            this.rBdriveCity.TabIndex = 0;
            this.rBdriveCity.TabStop = true;
            this.rBdriveCity.Text = "Города";
            this.rBdriveCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBdriveCity.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage2.Controls.Add(this.rBbodyFurgon);
            this.tabPage2.Controls.Add(this.rBbodyAny);
            this.tabPage2.Controls.Add(this.rBbodyMicrobus);
            this.tabPage2.Controls.Add(this.rBbodyWagon);
            this.tabPage2.Controls.Add(this.rBbodyHatch);
            this.tabPage2.Controls.Add(this.rBbodyMinivan);
            this.tabPage2.Controls.Add(this.rBbodySUV);
            this.tabPage2.Controls.Add(this.rBbodySedan);
            this.tabPage2.Controls.Add(this.rBbodyCoupe);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Кузов";
            // 
            // rBbodyFurgon
            // 
            this.rBbodyFurgon.AutoSize = true;
            this.rBbodyFurgon.Location = new System.Drawing.Point(250, 173);
            this.rBbodyFurgon.Name = "rBbodyFurgon";
            this.rBbodyFurgon.Size = new System.Drawing.Size(64, 17);
            this.rBbodyFurgon.TabIndex = 9;
            this.rBbodyFurgon.Text = "Фургон";
            this.rBbodyFurgon.UseVisualStyleBackColor = true;
            // 
            // rBbodyAny
            // 
            this.rBbodyAny.AutoSize = true;
            this.rBbodyAny.Checked = true;
            this.rBbodyAny.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBbodyAny.ForeColor = System.Drawing.Color.White;
            this.rBbodyAny.Location = new System.Drawing.Point(402, 75);
            this.rBbodyAny.Name = "rBbodyAny";
            this.rBbodyAny.Size = new System.Drawing.Size(76, 24);
            this.rBbodyAny.TabIndex = 8;
            this.rBbodyAny.TabStop = true;
            this.rBbodyAny.Text = "Любой";
            this.rBbodyAny.UseVisualStyleBackColor = true;
            // 
            // rBbodyMicrobus
            // 
            this.rBbodyMicrobus.AutoSize = true;
            this.rBbodyMicrobus.Location = new System.Drawing.Point(39, 173);
            this.rBbodyMicrobus.Name = "rBbodyMicrobus";
            this.rBbodyMicrobus.Size = new System.Drawing.Size(98, 17);
            this.rBbodyMicrobus.TabIndex = 7;
            this.rBbodyMicrobus.Text = "Микроавтобус";
            this.rBbodyMicrobus.UseVisualStyleBackColor = true;
            // 
            // rBbodyWagon
            // 
            this.rBbodyWagon.AutoSize = true;
            this.rBbodyWagon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBbodyWagon.ForeColor = System.Drawing.Color.White;
            this.rBbodyWagon.Location = new System.Drawing.Point(250, 75);
            this.rBbodyWagon.Name = "rBbodyWagon";
            this.rBbodyWagon.Size = new System.Drawing.Size(102, 24);
            this.rBbodyWagon.TabIndex = 6;
            this.rBbodyWagon.Text = "Универсал";
            this.rBbodyWagon.UseVisualStyleBackColor = true;
            // 
            // rBbodyHatch
            // 
            this.rBbodyHatch.AutoSize = true;
            this.rBbodyHatch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBbodyHatch.ForeColor = System.Drawing.Color.White;
            this.rBbodyHatch.Location = new System.Drawing.Point(39, 75);
            this.rBbodyHatch.Name = "rBbodyHatch";
            this.rBbodyHatch.Size = new System.Drawing.Size(81, 24);
            this.rBbodyHatch.TabIndex = 5;
            this.rBbodyHatch.Text = "Хэтчбек";
            this.rBbodyHatch.UseVisualStyleBackColor = true;
            // 
            // rBbodyMinivan
            // 
            this.rBbodyMinivan.AutoSize = true;
            this.rBbodyMinivan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBbodyMinivan.ForeColor = System.Drawing.Color.White;
            this.rBbodyMinivan.Location = new System.Drawing.Point(250, 104);
            this.rBbodyMinivan.Name = "rBbodyMinivan";
            this.rBbodyMinivan.Size = new System.Drawing.Size(92, 24);
            this.rBbodyMinivan.TabIndex = 4;
            this.rBbodyMinivan.Text = "Минивен";
            this.rBbodyMinivan.UseVisualStyleBackColor = true;
            // 
            // rBbodySUV
            // 
            this.rBbodySUV.AutoSize = true;
            this.rBbodySUV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBbodySUV.ForeColor = System.Drawing.Color.White;
            this.rBbodySUV.Location = new System.Drawing.Point(39, 104);
            this.rBbodySUV.Name = "rBbodySUV";
            this.rBbodySUV.Size = new System.Drawing.Size(54, 24);
            this.rBbodySUV.TabIndex = 3;
            this.rBbodySUV.Text = "SUV";
            this.rBbodySUV.UseVisualStyleBackColor = true;
            // 
            // rBbodySedan
            // 
            this.rBbodySedan.AutoSize = true;
            this.rBbodySedan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBbodySedan.ForeColor = System.Drawing.Color.White;
            this.rBbodySedan.Location = new System.Drawing.Point(39, 44);
            this.rBbodySedan.Name = "rBbodySedan";
            this.rBbodySedan.Size = new System.Drawing.Size(69, 24);
            this.rBbodySedan.TabIndex = 2;
            this.rBbodySedan.Text = "Седан";
            this.rBbodySedan.UseVisualStyleBackColor = true;
            // 
            // rBbodyCoupe
            // 
            this.rBbodyCoupe.AutoSize = true;
            this.rBbodyCoupe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBbodyCoupe.ForeColor = System.Drawing.Color.White;
            this.rBbodyCoupe.Location = new System.Drawing.Point(250, 44);
            this.rBbodyCoupe.Name = "rBbodyCoupe";
            this.rBbodyCoupe.Size = new System.Drawing.Size(60, 24);
            this.rBbodyCoupe.TabIndex = 1;
            this.rBbodyCoupe.Text = "Купе";
            this.rBbodyCoupe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Какой кузов автомобиля вы предпочитаете?";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage3.Controls.Add(this.rBtransAny);
            this.tabPage3.Controls.Add(this.rBtrans2);
            this.tabPage3.Controls.Add(this.rBtrans1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 150);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Коробка";
            // 
            // rBtransAny
            // 
            this.rBtransAny.AutoSize = true;
            this.rBtransAny.Checked = true;
            this.rBtransAny.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rBtransAny.ForeColor = System.Drawing.Color.White;
            this.rBtransAny.Location = new System.Drawing.Point(282, 66);
            this.rBtransAny.Name = "rBtransAny";
            this.rBtransAny.Size = new System.Drawing.Size(74, 24);
            this.rBtransAny.TabIndex = 5;
            this.rBtransAny.TabStop = true;
            this.rBtransAny.Text = "Любая";
            this.rBtransAny.UseVisualStyleBackColor = true;
            // 
            // rBtrans2
            // 
            this.rBtrans2.AutoSize = true;
            this.rBtrans2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rBtrans2.ForeColor = System.Drawing.Color.White;
            this.rBtrans2.Location = new System.Drawing.Point(157, 66);
            this.rBtrans2.Name = "rBtrans2";
            this.rBtrans2.Size = new System.Drawing.Size(85, 24);
            this.rBtrans2.TabIndex = 2;
            this.rBtrans2.Text = "Автомат";
            this.rBtrans2.UseVisualStyleBackColor = true;
            // 
            // rBtrans1
            // 
            this.rBtrans1.AutoSize = true;
            this.rBtrans1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rBtrans1.ForeColor = System.Drawing.Color.White;
            this.rBtrans1.Location = new System.Drawing.Point(40, 66);
            this.rBtrans1.Name = "rBtrans1";
            this.rBtrans1.Size = new System.Drawing.Size(96, 24);
            this.rBtrans1.TabIndex = 1;
            this.rBtrans1.Text = "Механика";
            this.rBtrans1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип коробки переключния передач:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage4.Controls.Add(this.rBprice4);
            this.tabPage4.Controls.Add(this.rBprice3);
            this.tabPage4.Controls.Add(this.rBprice2);
            this.tabPage4.Controls.Add(this.rBprice1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(673, 150);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Цена";
            // 
            // rBprice4
            // 
            this.rBprice4.AutoSize = true;
            this.rBprice4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rBprice4.ForeColor = System.Drawing.Color.White;
            this.rBprice4.Location = new System.Drawing.Point(266, 84);
            this.rBprice4.Name = "rBprice4";
            this.rBprice4.Size = new System.Drawing.Size(155, 24);
            this.rBprice4.TabIndex = 4;
            this.rBprice4.Text = "Свыше 6 000 000 ₽";
            this.rBprice4.UseVisualStyleBackColor = true;
            // 
            // rBprice3
            // 
            this.rBprice3.AutoSize = true;
            this.rBprice3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rBprice3.ForeColor = System.Drawing.Color.White;
            this.rBprice3.Location = new System.Drawing.Point(30, 84);
            this.rBprice3.Name = "rBprice3";
            this.rBprice3.Size = new System.Drawing.Size(124, 24);
            this.rBprice3.TabIndex = 3;
            this.rBprice3.Text = "до 6 000 000 ₽";
            this.rBprice3.UseVisualStyleBackColor = true;
            // 
            // rBprice2
            // 
            this.rBprice2.AutoSize = true;
            this.rBprice2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rBprice2.ForeColor = System.Drawing.Color.White;
            this.rBprice2.Location = new System.Drawing.Point(266, 47);
            this.rBprice2.Name = "rBprice2";
            this.rBprice2.Size = new System.Drawing.Size(124, 24);
            this.rBprice2.TabIndex = 2;
            this.rBprice2.Text = "до 2 500 000 ₽";
            this.rBprice2.UseVisualStyleBackColor = true;
            // 
            // rBprice1
            // 
            this.rBprice1.AutoSize = true;
            this.rBprice1.Checked = true;
            this.rBprice1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rBprice1.ForeColor = System.Drawing.Color.White;
            this.rBprice1.Location = new System.Drawing.Point(30, 47);
            this.rBprice1.Name = "rBprice1";
            this.rBprice1.Size = new System.Drawing.Size(124, 24);
            this.rBprice1.TabIndex = 1;
            this.rBprice1.TabStop = true;
            this.rBprice1.Text = "до 1 600 000 ₽";
            this.rBprice1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена автомобиля:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(663, 260);
            this.listBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вам подходит:";
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.CheckButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.CheckButton.ForeColor = System.Drawing.Color.White;
            this.CheckButton.Location = new System.Drawing.Point(529, 218);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(115, 32);
            this.CheckButton.TabIndex = 9;
            this.CheckButton.Text = "Подобрать";
            this.CheckButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // buttonToOrigin
            // 
            this.buttonToOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.buttonToOrigin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.buttonToOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToOrigin.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.buttonToOrigin.ForeColor = System.Drawing.Color.White;
            this.buttonToOrigin.Location = new System.Drawing.Point(246, 218);
            this.buttonToOrigin.Name = "buttonToOrigin";
            this.buttonToOrigin.Size = new System.Drawing.Size(91, 32);
            this.buttonToOrigin.TabIndex = 11;
            this.buttonToOrigin.Text = "Заново ↺";
            this.buttonToOrigin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonToOrigin.UseVisualStyleBackColor = false;
            this.buttonToOrigin.Click += new System.EventHandler(this.buttonToOrigin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(554, 560);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 32);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Выход";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-8, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 10);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 31);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Выбор легкового автомобиля";
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(-8, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 26);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(-8, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 28);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(663, 604);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToOrigin);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DownButton1);
            this.Controls.Add(this.NextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button DownButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBprice4;
        private System.Windows.Forms.RadioButton rBprice3;
        private System.Windows.Forms.RadioButton rBprice2;
        private System.Windows.Forms.RadioButton rBprice1;
        private System.Windows.Forms.RadioButton rBbodyMinivan;
        private System.Windows.Forms.RadioButton rBbodySUV;
        private System.Windows.Forms.RadioButton rBbodySedan;
        private System.Windows.Forms.RadioButton rBbodyCoupe;
        private System.Windows.Forms.RadioButton rBtrans2;
        private System.Windows.Forms.RadioButton rBtrans1;
        private System.Windows.Forms.RadioButton rBbodyWagon;
        private System.Windows.Forms.RadioButton rBbodyHatch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RadioButton rBtransAny;
        private System.Windows.Forms.RadioButton rBbodyAny;
        private System.Windows.Forms.RadioButton rBbodyMicrobus;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBdriveTravel;
        private System.Windows.Forms.RadioButton rBdriveDach;
        private System.Windows.Forms.RadioButton rBdriveCity;
        private System.Windows.Forms.RadioButton rBbodyFurgon;
        private System.Windows.Forms.RadioButton rBdriveNature;
        private System.Windows.Forms.RadioButton rBdriveFast;
        private System.Windows.Forms.Button buttonToOrigin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

