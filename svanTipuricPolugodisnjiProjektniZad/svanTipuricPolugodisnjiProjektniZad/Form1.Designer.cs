namespace svanTipuricPolugodisnjiProjektniZad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxPredmet = new System.Windows.Forms.ComboBox();
            this.textBoxGradivo = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.textBoxProfesor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObradi
            // 
            this.btnObradi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObradi.Location = new System.Drawing.Point(475, 142);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(75, 60);
            this.btnObradi.TabIndex = 0;
            this.btnObradi.Text = "OBRADI";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnos.Location = new System.Drawing.Point(234, 142);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 60);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "UNOS";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIspis.Location = new System.Drawing.Point(352, 142);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 60);
            this.btnIspis.TabIndex = 2;
            this.btnIspis.Text = "ISPIS";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gradivo";
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(16, 258);
            this.rtb1.Name = "rtb1";
            this.rtb1.ReadOnly = true;
            this.rtb1.Size = new System.Drawing.Size(534, 251);
            this.rtb1.TabIndex = 4;
            this.rtb1.Text = "\n\n\n\n\n\n\n\n\n";
            // 
            // comboBoxPredmet
            // 
            this.comboBoxPredmet.AllowDrop = true;
            this.comboBoxPredmet.FormattingEnabled = true;
            this.comboBoxPredmet.Items.AddRange(new object[] {
            "Programiranje",
            "Matematika",
            "Hrvatski jezik",
            "Engleski jezik",
            "Skriptni jezici i web programiranje",
            "Programiranje mobilnih uredaja"});
            this.comboBoxPredmet.Location = new System.Drawing.Point(16, 82);
            this.comboBoxPredmet.Name = "comboBoxPredmet";
            this.comboBoxPredmet.Size = new System.Drawing.Size(170, 21);
            this.comboBoxPredmet.TabIndex = 5;
            this.comboBoxPredmet.SelectedIndexChanged += new System.EventHandler(this.comboBoxPredmet_SelectedIndexChanged);
            // 
            // textBoxGradivo
            // 
            this.textBoxGradivo.Location = new System.Drawing.Point(16, 34);
            this.textBoxGradivo.Name = "textBoxGradivo";
            this.textBoxGradivo.Size = new System.Drawing.Size(170, 20);
            this.textBoxGradivo.TabIndex = 6;
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(16, 132);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(170, 20);
            this.textBoxDatum.TabIndex = 7;
            // 
            // textBoxProfesor
            // 
            this.textBoxProfesor.Location = new System.Drawing.Point(16, 182);
            this.textBoxProfesor.Name = "textBoxProfesor";
            this.textBoxProfesor.Size = new System.Drawing.Size(170, 20);
            this.textBoxProfesor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Predmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum pisanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Profesor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(596, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProfesor);
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.textBoxGradivo);
            this.Controls.Add(this.comboBoxPredmet);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnObradi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "E-dnevnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.ComboBox comboBoxPredmet;
        private System.Windows.Forms.TextBox textBoxGradivo;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.TextBox textBoxProfesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

