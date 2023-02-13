namespace brrrPitpm1vo2sem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.genBtn = new System.Windows.Forms.Button();
            this.genTb = new System.Windows.Forms.TextBox();
            this.vstavkaBtn = new System.Windows.Forms.Button();
            this.obmenBtn = new System.Windows.Forms.Button();
            this.choBtn = new System.Windows.Forms.Button();
            this.vyvodTb = new System.Windows.Forms.TextBox();
            this.upRb = new System.Windows.Forms.RadioButton();
            this.downRb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(561, 27);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(182, 29);
            this.genBtn.TabIndex = 0;
            this.genBtn.Text = "Сгенерировать массив";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // genTb
            // 
            this.genTb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.genTb.Location = new System.Drawing.Point(109, 27);
            this.genTb.Name = "genTb";
            this.genTb.ReadOnly = true;
            this.genTb.Size = new System.Drawing.Size(415, 27);
            this.genTb.TabIndex = 1;
            // 
            // vstavkaBtn
            // 
            this.vstavkaBtn.Location = new System.Drawing.Point(139, 97);
            this.vstavkaBtn.Name = "vstavkaBtn";
            this.vstavkaBtn.Size = new System.Drawing.Size(94, 29);
            this.vstavkaBtn.TabIndex = 2;
            this.vstavkaBtn.Text = "Вставка";
            this.vstavkaBtn.UseVisualStyleBackColor = true;
            this.vstavkaBtn.Click += new System.EventHandler(this.vstavkaBtn_Click);
            // 
            // obmenBtn
            // 
            this.obmenBtn.Location = new System.Drawing.Point(273, 97);
            this.obmenBtn.Name = "obmenBtn";
            this.obmenBtn.Size = new System.Drawing.Size(94, 29);
            this.obmenBtn.TabIndex = 3;
            this.obmenBtn.Text = "Обмен";
            this.obmenBtn.UseVisualStyleBackColor = true;
            this.obmenBtn.Click += new System.EventHandler(this.obmenBtn_Click);
            // 
            // choBtn
            // 
            this.choBtn.Location = new System.Drawing.Point(403, 97);
            this.choBtn.Name = "choBtn";
            this.choBtn.Size = new System.Drawing.Size(94, 29);
            this.choBtn.TabIndex = 4;
            this.choBtn.Text = "Выбор";
            this.choBtn.UseVisualStyleBackColor = true;
            this.choBtn.Click += new System.EventHandler(this.choBtn_Click);
            // 
            // vyvodTb
            // 
            this.vyvodTb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vyvodTb.Location = new System.Drawing.Point(114, 154);
            this.vyvodTb.Name = "vyvodTb";
            this.vyvodTb.ReadOnly = true;
            this.vyvodTb.Size = new System.Drawing.Size(415, 27);
            this.vyvodTb.TabIndex = 5;
            // 
            // upRb
            // 
            this.upRb.AutoSize = true;
            this.upRb.Checked = true;
            this.upRb.Location = new System.Drawing.Point(578, 62);
            this.upRb.Name = "upRb";
            this.upRb.Size = new System.Drawing.Size(146, 24);
            this.upRb.TabIndex = 6;
            this.upRb.TabStop = true;
            this.upRb.Text = "По возрастанию";
            this.upRb.UseVisualStyleBackColor = true;
            // 
            // downRb
            // 
            this.downRb.AutoSize = true;
            this.downRb.Location = new System.Drawing.Point(578, 92);
            this.downRb.Name = "downRb";
            this.downRb.Size = new System.Drawing.Size(127, 24);
            this.downRb.TabIndex = 7;
            this.downRb.Text = "По убыванию";
            this.downRb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downRb);
            this.Controls.Add(this.upRb);
            this.Controls.Add(this.vyvodTb);
            this.Controls.Add(this.choBtn);
            this.Controls.Add(this.obmenBtn);
            this.Controls.Add(this.vstavkaBtn);
            this.Controls.Add(this.genTb);
            this.Controls.Add(this.genBtn);
            this.Name = "Form1";
            this.Text = "PITPM 1 laba 2 semestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button genBtn;
        private TextBox genTb;
        private Button vstavkaBtn;
        private Button obmenBtn;
        private Button choBtn;
        private TextBox vyvodTb;
        private RadioButton upRb;
        private RadioButton downRb;
    }
}