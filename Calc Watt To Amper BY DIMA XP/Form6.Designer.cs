namespace Calc_Watt_To_Amper_BY_DIMA_XP
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.r13 = new System.Windows.Forms.RadioButton();
            this.r45 = new System.Windows.Forms.RadioButton();
            this.r155 = new System.Windows.Forms.RadioButton();
            this.r400 = new System.Windows.Forms.RadioButton();
            this.r900 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(70, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 2;
            // 
            // r13
            // 
            this.r13.AutoSize = true;
            this.r13.Checked = true;
            this.r13.Location = new System.Drawing.Point(12, 78);
            this.r13.Name = "r13";
            this.r13.Size = new System.Drawing.Size(54, 17);
            this.r13.TabIndex = 3;
            this.r13.TabStop = true;
            this.r13.Text = "1,13in";
            this.r13.UseVisualStyleBackColor = true;
            this.r13.CheckedChanged += new System.EventHandler(this.r13_CheckedChanged);
            // 
            // r45
            // 
            this.r45.AutoSize = true;
            this.r45.Location = new System.Drawing.Point(70, 78);
            this.r45.Name = "r45";
            this.r45.Size = new System.Drawing.Size(54, 17);
            this.r45.TabIndex = 4;
            this.r45.Text = "1,45in";
            this.r45.UseVisualStyleBackColor = true;
            this.r45.CheckedChanged += new System.EventHandler(this.r45_CheckedChanged);
            // 
            // r155
            // 
            this.r155.AutoSize = true;
            this.r155.Location = new System.Drawing.Point(130, 78);
            this.r155.Name = "r155";
            this.r155.Size = new System.Drawing.Size(54, 17);
            this.r155.TabIndex = 6;
            this.r155.Text = "2.55in";
            this.r155.UseVisualStyleBackColor = true;
            this.r155.CheckedChanged += new System.EventHandler(this.r155_CheckedChanged);
            // 
            // r400
            // 
            this.r400.AutoSize = true;
            this.r400.Location = new System.Drawing.Point(188, 78);
            this.r400.Name = "r400";
            this.r400.Size = new System.Drawing.Size(42, 17);
            this.r400.TabIndex = 5;
            this.r400.Text = "5-in";
            this.r400.UseVisualStyleBackColor = true;
            this.r400.CheckedChanged += new System.EventHandler(this.r400_CheckedChanged);
            // 
            // r900
            // 
            this.r900.AutoSize = true;
            this.r900.Location = new System.Drawing.Point(242, 78);
            this.r900.Name = "r900";
            this.r900.Size = new System.Drawing.Size(48, 17);
            this.r900.TabIndex = 7;
            this.r900.Text = "10-in";
            this.r900.UseVisualStyleBackColor = true;
            this.r900.CheckedChanged += new System.EventHandler(this.r900_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номинал автомата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Рассчет номинала автомата";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(10, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Показать сечения\r\nкабелей и их токи.\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(2, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 130);
            this.label4.TabIndex = 13;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(161, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 371);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r900);
            this.Controls.Add(this.r155);
            this.Controls.Add(this.r400);
            this.Controls.Add(this.r45);
            this.Controls.Add(this.r13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "Рассчет номинала автомата";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton r13;
        private System.Windows.Forms.RadioButton r45;
        private System.Windows.Forms.RadioButton r155;
        private System.Windows.Forms.RadioButton r400;
        private System.Windows.Forms.RadioButton r900;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}