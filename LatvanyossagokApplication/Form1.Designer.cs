namespace LatvanyossagokApplication
{
    partial class Form1
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
            this.listBoxVarosok = new System.Windows.Forms.ListBox();
            this.listBoxLatvanyossagok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVaros = new System.Windows.Forms.TextBox();
            this.numericUpDownLakossag = new System.Windows.Forms.NumericUpDown();
            this.buttonVarosSubmit = new System.Windows.Forms.Button();
            this.buttonLatvanyossagHozzaad = new System.Windows.Forms.Button();
            this.numericUpDownLatvanyossag = new System.Windows.Forms.NumericUpDown();
            this.textBoxLatvanyossag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLatvanyossagLeiras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxLatvanyossagVarosa = new System.Windows.Forms.ListBox();
            this.buttonVarosDelete = new System.Windows.Forms.Button();
            this.buttonLatvanyossagDelete = new System.Windows.Forms.Button();
            this.buttonVarosEdit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEditVaros = new System.Windows.Forms.TextBox();
            this.numericUpDownEditVaros = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLatvanyossagAr = new System.Windows.Forms.NumericUpDown();
            this.textBoxEditLatvanyossagNev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonLatvanyossagEdit = new System.Windows.Forms.Button();
            this.textBoxEditLatvanyossagLeiras = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditVaros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossagAr)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxVarosok
            // 
            this.listBoxVarosok.FormattingEnabled = true;
            this.listBoxVarosok.Location = new System.Drawing.Point(509, 12);
            this.listBoxVarosok.Name = "listBoxVarosok";
            this.listBoxVarosok.Size = new System.Drawing.Size(279, 368);
            this.listBoxVarosok.TabIndex = 1;
            this.listBoxVarosok.SelectedValueChanged += new System.EventHandler(this.listBoxVarosok_SelectedValueChanged);
            // 
            // listBoxLatvanyossagok
            // 
            this.listBoxLatvanyossagok.FormattingEnabled = true;
            this.listBoxLatvanyossagok.Location = new System.Drawing.Point(224, 12);
            this.listBoxLatvanyossagok.Name = "listBoxLatvanyossagok";
            this.listBoxLatvanyossagok.Size = new System.Drawing.Size(279, 368);
            this.listBoxLatvanyossagok.TabIndex = 2;
            this.listBoxLatvanyossagok.SelectedValueChanged += new System.EventHandler(this.listBoxLatvanyossagok_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Város hozzáadása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lakosság";
            // 
            // textBoxVaros
            // 
            this.textBoxVaros.Location = new System.Drawing.Point(118, 33);
            this.textBoxVaros.Name = "textBoxVaros";
            this.textBoxVaros.Size = new System.Drawing.Size(100, 20);
            this.textBoxVaros.TabIndex = 6;
            // 
            // numericUpDownLakossag
            // 
            this.numericUpDownLakossag.Location = new System.Drawing.Point(118, 58);
            this.numericUpDownLakossag.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownLakossag.Name = "numericUpDownLakossag";
            this.numericUpDownLakossag.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownLakossag.TabIndex = 7;
            // 
            // buttonVarosSubmit
            // 
            this.buttonVarosSubmit.Location = new System.Drawing.Point(15, 86);
            this.buttonVarosSubmit.Name = "buttonVarosSubmit";
            this.buttonVarosSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonVarosSubmit.TabIndex = 8;
            this.buttonVarosSubmit.Text = "Hozzáad";
            this.buttonVarosSubmit.UseVisualStyleBackColor = true;
            this.buttonVarosSubmit.Click += new System.EventHandler(this.buttonVarosSubmit_Click);
            // 
            // buttonLatvanyossagHozzaad
            // 
            this.buttonLatvanyossagHozzaad.Location = new System.Drawing.Point(15, 309);
            this.buttonLatvanyossagHozzaad.Name = "buttonLatvanyossagHozzaad";
            this.buttonLatvanyossagHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonLatvanyossagHozzaad.TabIndex = 14;
            this.buttonLatvanyossagHozzaad.Text = "Hozzáad";
            this.buttonLatvanyossagHozzaad.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagHozzaad.Click += new System.EventHandler(this.buttonLatvanyossagHozzaad_Click);
            // 
            // numericUpDownLatvanyossag
            // 
            this.numericUpDownLatvanyossag.Location = new System.Drawing.Point(118, 167);
            this.numericUpDownLatvanyossag.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownLatvanyossag.Name = "numericUpDownLatvanyossag";
            this.numericUpDownLatvanyossag.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownLatvanyossag.TabIndex = 13;
            // 
            // textBoxLatvanyossag
            // 
            this.textBoxLatvanyossag.Location = new System.Drawing.Point(118, 142);
            this.textBoxLatvanyossag.Name = "textBoxLatvanyossag";
            this.textBoxLatvanyossag.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatvanyossag.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ár";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Név";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Látványosság hozzáadása";
            // 
            // textBoxLatvanyossagLeiras
            // 
            this.textBoxLatvanyossagLeiras.Location = new System.Drawing.Point(118, 193);
            this.textBoxLatvanyossagLeiras.Name = "textBoxLatvanyossagLeiras";
            this.textBoxLatvanyossagLeiras.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatvanyossagLeiras.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Leírás";
            // 
            // listBoxLatvanyossagVarosa
            // 
            this.listBoxLatvanyossagVarosa.FormattingEnabled = true;
            this.listBoxLatvanyossagVarosa.Location = new System.Drawing.Point(12, 219);
            this.listBoxLatvanyossagVarosa.Name = "listBoxLatvanyossagVarosa";
            this.listBoxLatvanyossagVarosa.Size = new System.Drawing.Size(206, 82);
            this.listBoxLatvanyossagVarosa.TabIndex = 17;
            // 
            // buttonVarosDelete
            // 
            this.buttonVarosDelete.Location = new System.Drawing.Point(713, 415);
            this.buttonVarosDelete.Name = "buttonVarosDelete";
            this.buttonVarosDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonVarosDelete.TabIndex = 18;
            this.buttonVarosDelete.Text = "Törlés";
            this.buttonVarosDelete.UseVisualStyleBackColor = true;
            this.buttonVarosDelete.Click += new System.EventHandler(this.buttonVarosDelete_Click);
            // 
            // buttonLatvanyossagDelete
            // 
            this.buttonLatvanyossagDelete.Location = new System.Drawing.Point(425, 415);
            this.buttonLatvanyossagDelete.Name = "buttonLatvanyossagDelete";
            this.buttonLatvanyossagDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonLatvanyossagDelete.TabIndex = 24;
            this.buttonLatvanyossagDelete.Text = "Törlés";
            this.buttonLatvanyossagDelete.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagDelete.Click += new System.EventHandler(this.buttonLatvanyossagDelete_Click);
            // 
            // buttonVarosEdit
            // 
            this.buttonVarosEdit.Location = new System.Drawing.Point(713, 386);
            this.buttonVarosEdit.Name = "buttonVarosEdit";
            this.buttonVarosEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonVarosEdit.TabIndex = 19;
            this.buttonVarosEdit.Text = "Módosítás";
            this.buttonVarosEdit.UseVisualStyleBackColor = true;
            this.buttonVarosEdit.Click += new System.EventHandler(this.buttonVarosEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Név";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lakosság";
            // 
            // textBoxEditVaros
            // 
            this.textBoxEditVaros.Enabled = false;
            this.textBoxEditVaros.Location = new System.Drawing.Point(607, 388);
            this.textBoxEditVaros.Name = "textBoxEditVaros";
            this.textBoxEditVaros.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditVaros.TabIndex = 22;
            // 
            // numericUpDownEditVaros
            // 
            this.numericUpDownEditVaros.Enabled = false;
            this.numericUpDownEditVaros.Location = new System.Drawing.Point(607, 418);
            this.numericUpDownEditVaros.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownEditVaros.Name = "numericUpDownEditVaros";
            this.numericUpDownEditVaros.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownEditVaros.TabIndex = 23;
            // 
            // numericUpDownLatvanyossagAr
            // 
            this.numericUpDownLatvanyossagAr.Enabled = false;
            this.numericUpDownLatvanyossagAr.Location = new System.Drawing.Point(323, 415);
            this.numericUpDownLatvanyossagAr.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownLatvanyossagAr.Name = "numericUpDownLatvanyossagAr";
            this.numericUpDownLatvanyossagAr.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownLatvanyossagAr.TabIndex = 29;
            // 
            // textBoxEditLatvanyossagNev
            // 
            this.textBoxEditLatvanyossagNev.Enabled = false;
            this.textBoxEditLatvanyossagNev.Location = new System.Drawing.Point(323, 389);
            this.textBoxEditLatvanyossagNev.Name = "textBoxEditLatvanyossagNev";
            this.textBoxEditLatvanyossagNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditLatvanyossagNev.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ár";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Név";
            // 
            // buttonLatvanyossagEdit
            // 
            this.buttonLatvanyossagEdit.Location = new System.Drawing.Point(426, 386);
            this.buttonLatvanyossagEdit.Name = "buttonLatvanyossagEdit";
            this.buttonLatvanyossagEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonLatvanyossagEdit.TabIndex = 25;
            this.buttonLatvanyossagEdit.Text = "Módosítás";
            this.buttonLatvanyossagEdit.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagEdit.Click += new System.EventHandler(this.buttonLatvanyossagEdit_Click);
            // 
            // textBoxEditLatvanyossagLeiras
            // 
            this.textBoxEditLatvanyossagLeiras.Enabled = false;
            this.textBoxEditLatvanyossagLeiras.Location = new System.Drawing.Point(323, 444);
            this.textBoxEditLatvanyossagLeiras.Name = "textBoxEditLatvanyossagLeiras";
            this.textBoxEditLatvanyossagLeiras.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditLatvanyossagLeiras.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Leírás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.textBoxEditLatvanyossagLeiras);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownLatvanyossagAr);
            this.Controls.Add(this.textBoxEditLatvanyossagNev);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonLatvanyossagEdit);
            this.Controls.Add(this.buttonLatvanyossagDelete);
            this.Controls.Add(this.numericUpDownEditVaros);
            this.Controls.Add(this.textBoxEditVaros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonVarosEdit);
            this.Controls.Add(this.buttonVarosDelete);
            this.Controls.Add(this.listBoxLatvanyossagVarosa);
            this.Controls.Add(this.textBoxLatvanyossagLeiras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonLatvanyossagHozzaad);
            this.Controls.Add(this.numericUpDownLatvanyossag);
            this.Controls.Add(this.textBoxLatvanyossag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonVarosSubmit);
            this.Controls.Add(this.numericUpDownLakossag);
            this.Controls.Add(this.textBoxVaros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLatvanyossagok);
            this.Controls.Add(this.listBoxVarosok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditVaros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossagAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVarosok;
        private System.Windows.Forms.ListBox listBoxLatvanyossagok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVaros;
        private System.Windows.Forms.NumericUpDown numericUpDownLakossag;
        private System.Windows.Forms.Button buttonVarosSubmit;
        private System.Windows.Forms.Button buttonLatvanyossagHozzaad;
        private System.Windows.Forms.NumericUpDown numericUpDownLatvanyossag;
        private System.Windows.Forms.TextBox textBoxLatvanyossag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLatvanyossagLeiras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxLatvanyossagVarosa;
        private System.Windows.Forms.Button buttonVarosDelete;
        private System.Windows.Forms.Button buttonLatvanyossagDelete;
        private System.Windows.Forms.Button buttonVarosEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEditVaros;
        private System.Windows.Forms.NumericUpDown numericUpDownEditVaros;
        private System.Windows.Forms.NumericUpDown numericUpDownLatvanyossagAr;
        private System.Windows.Forms.TextBox textBoxEditLatvanyossagNev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonLatvanyossagEdit;
        private System.Windows.Forms.TextBox textBoxEditLatvanyossagLeiras;
        private System.Windows.Forms.Label label12;
    }
}

