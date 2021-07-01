namespace monitortemp
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
            this.lbvid = new System.Windows.Forms.Label();
            this.lbmax = new System.Windows.Forms.Label();
            this.lbmin = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.lbvtemp = new System.Windows.Forms.Label();
            this.lbotchet = new System.Windows.Forms.Label();
            this.tbmax = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbtemp = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.tbmin = new System.Windows.Forms.TextBox();
            this.tbtimemin = new System.Windows.Forms.TextBox();
            this.tbtimemax = new System.Windows.Forms.TextBox();
            this.tbtemp = new System.Windows.Forms.TextBox();
            this.btstart = new System.Windows.Forms.Button();
            this.tbotchet = new System.Windows.Forms.TextBox();
            this.tbotchetinfo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbvid
            // 
            this.lbvid.AutoSize = true;
            this.lbvid.Location = new System.Drawing.Point(53, 76);
            this.lbvid.Name = "lbvid";
            this.lbvid.Size = new System.Drawing.Size(57, 13);
            this.lbvid.TabIndex = 1;
            this.lbvid.Text = "Вид рыбы";
            // 
            // lbmax
            // 
            this.lbmax.AutoSize = true;
            this.lbmax.Location = new System.Drawing.Point(53, 117);
            this.lbmax.Name = "lbmax";
            this.lbmax.Size = new System.Drawing.Size(27, 13);
            this.lbmax.TabIndex = 3;
            this.lbmax.Text = "Max";
            // 
            // lbmin
            // 
            this.lbmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbmin.Location = new System.Drawing.Point(56, 143);
            this.lbmin.Name = "lbmin";
            this.lbmin.Size = new System.Drawing.Size(77, 21);
            this.lbmin.TabIndex = 5;
            this.lbmin.Text = "Min";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Location = new System.Drawing.Point(53, 172);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(33, 13);
            this.lbdata.TabIndex = 7;
            this.lbdata.Text = "Дата";
            // 
            // lbvtemp
            // 
            this.lbvtemp.AutoSize = true;
            this.lbvtemp.Location = new System.Drawing.Point(53, 198);
            this.lbvtemp.Name = "lbvtemp";
            this.lbvtemp.Size = new System.Drawing.Size(74, 13);
            this.lbvtemp.TabIndex = 9;
            this.lbvtemp.Text = "Температура";
            // 
            // lbotchet
            // 
            this.lbotchet.AutoSize = true;
            this.lbotchet.Location = new System.Drawing.Point(53, 221);
            this.lbotchet.Name = "lbotchet";
            this.lbotchet.Size = new System.Drawing.Size(36, 13);
            this.lbotchet.TabIndex = 11;
            this.lbotchet.Text = "Отчет";
            // 
            // tbmax
            // 
            this.tbmax.Location = new System.Drawing.Point(136, 117);
            this.tbmax.Name = "tbmax";
            this.tbmax.Size = new System.Drawing.Size(100, 20);
            this.tbmax.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // lbtemp
            // 
            this.lbtemp.AutoSize = true;
            this.lbtemp.Location = new System.Drawing.Point(148, 101);
            this.lbtemp.Name = "lbtemp";
            this.lbtemp.Size = new System.Drawing.Size(74, 13);
            this.lbtemp.TabIndex = 16;
            this.lbtemp.Text = "Температура";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(273, 101);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(40, 13);
            this.lbtime.TabIndex = 18;
            this.lbtime.Text = "Время";
            // 
            // tbmin
            // 
            this.tbmin.Location = new System.Drawing.Point(136, 143);
            this.tbmin.Name = "tbmin";
            this.tbmin.Size = new System.Drawing.Size(100, 20);
            this.tbmin.TabIndex = 19;
            // 
            // tbtimemin
            // 
            this.tbtimemin.Location = new System.Drawing.Point(255, 143);
            this.tbtimemin.Name = "tbtimemin";
            this.tbtimemin.Size = new System.Drawing.Size(100, 20);
            this.tbtimemin.TabIndex = 21;
            // 
            // tbtimemax
            // 
            this.tbtimemax.Location = new System.Drawing.Point(255, 117);
            this.tbtimemax.Name = "tbtimemax";
            this.tbtimemax.Size = new System.Drawing.Size(100, 20);
            this.tbtimemax.TabIndex = 23;
            // 
            // tbtemp
            // 
            this.tbtemp.Location = new System.Drawing.Point(136, 195);
            this.tbtemp.Name = "tbtemp";
            this.tbtemp.Size = new System.Drawing.Size(206, 20);
            this.tbtemp.TabIndex = 25;
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(363, 190);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(75, 23);
            this.btstart.TabIndex = 26;
            this.btstart.Text = "Расчет";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // tbotchet
            // 
            this.tbotchet.Location = new System.Drawing.Point(56, 246);
            this.tbotchet.Multiline = true;
            this.tbotchet.Name = "tbotchet";
            this.tbotchet.Size = new System.Drawing.Size(400, 634);
            this.tbotchet.TabIndex = 28;
            // 
            // tbotchetinfo
            // 
            this.tbotchetinfo.Location = new System.Drawing.Point(136, 220);
            this.tbotchetinfo.Name = "tbotchetinfo";
            this.tbotchetinfo.Size = new System.Drawing.Size(652, 20);
            this.tbotchetinfo.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:m";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 840);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbotchetinfo);
            this.Controls.Add(this.tbotchet);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.tbtemp);
            this.Controls.Add(this.tbtimemax);
            this.Controls.Add(this.tbtimemin);
            this.Controls.Add(this.tbmin);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.lbtemp);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbmax);
            this.Controls.Add(this.lbotchet);
            this.Controls.Add(this.lbvtemp);
            this.Controls.Add(this.lbdata);
            this.Controls.Add(this.lbmin);
            this.Controls.Add(this.lbmax);
            this.Controls.Add(this.lbvid);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbvid;
        private System.Windows.Forms.Label lbmax;
        private System.Windows.Forms.Label lbmin;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label lbvtemp;
        private System.Windows.Forms.Label lbotchet;
        private System.Windows.Forms.TextBox tbmax;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbtemp;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.TextBox tbmin;
        private System.Windows.Forms.TextBox tbtimemin;
        private System.Windows.Forms.TextBox tbtimemax;
        private System.Windows.Forms.TextBox tbtemp;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.TextBox tbotchet;
        private System.Windows.Forms.TextBox tbotchetinfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

