namespace knjiznica
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


        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.btnPrikaziKnjige = new System.Windows.Forms.Button();
            this.btnSpremiDatoteku = new System.Windows.Forms.Button();
            this.btnUcitajIzDatoteke = new System.Windows.Forms.Button();
            this.lstKnjige = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtID.Location = new System.Drawing.Point(115, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 1;

            this.txtNaslov.Location = new System.Drawing.Point(115, 125);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(200, 20);
            this.txtNaslov.TabIndex = 2;

            this.txtAutor.Location = new System.Drawing.Point(115, 179);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(200, 20);
            this.txtAutor.TabIndex = 3;

            this.txtGodina.Location = new System.Drawing.Point(115, 235);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(200, 20);
            this.txtGodina.TabIndex = 4;

            this.btnDodajKnjigu.Location = new System.Drawing.Point(115, 292);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKnjigu.TabIndex = 5;
            this.btnDodajKnjigu.Text = "Dodaj Knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.btnDodajKnjigu_Click);

            this.btnPrikaziKnjige.Location = new System.Drawing.Point(579, 292);
            this.btnPrikaziKnjige.Name = "btnPrikaziKnjige";
            this.btnPrikaziKnjige.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziKnjige.TabIndex = 6;
            this.btnPrikaziKnjige.Text = "Prikaži Knjige";
            this.btnPrikaziKnjige.UseVisualStyleBackColor = true;
            this.btnPrikaziKnjige.Click += new System.EventHandler(this.btnPrikaziKnjige_Click);

            this.btnSpremiDatoteku.Location = new System.Drawing.Point(240, 292);
            this.btnSpremiDatoteku.Name = "btnSpremiDatoteku";
            this.btnSpremiDatoteku.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiDatoteku.TabIndex = 7;
            this.btnSpremiDatoteku.Text = "Spremi";
            this.btnSpremiDatoteku.UseVisualStyleBackColor = true;
            this.btnSpremiDatoteku.Click += new System.EventHandler(this.btnSpremiUDatoteku_Click);

            this.btnUcitajIzDatoteke.Location = new System.Drawing.Point(670, 292);
            this.btnUcitajIzDatoteke.Name = "btnUcitajIzDatoteke";
            this.btnUcitajIzDatoteke.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajIzDatoteke.TabIndex = 8;
            this.btnUcitajIzDatoteke.Text = "Učitaj";
            this.btnUcitajIzDatoteke.UseVisualStyleBackColor = true;
            this.btnUcitajIzDatoteke.Click += new System.EventHandler(this.btnUcitajIzDatoteke_Click);
 
            this.lstKnjige.FormattingEnabled = true;
            this.lstKnjige.Location = new System.Drawing.Point(429, 74);
            this.lstKnjige.Name = "lstKnjige";
            this.lstKnjige.Size = new System.Drawing.Size(316, 212);
            this.lstKnjige.TabIndex = 9;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unos ID-a Knjige";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unos Naslova Knjige";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unos Autora Knjige";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unos Godine Izdanja";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKnjige);
            this.Controls.Add(this.btnUcitajIzDatoteke);
            this.Controls.Add(this.btnSpremiDatoteku);
            this.Controls.Add(this.btnPrikaziKnjige);
            this.Controls.Add(this.btnDodajKnjigu);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.Button btnPrikaziKnjige;
        private System.Windows.Forms.Button btnSpremiDatoteku;
        private System.Windows.Forms.Button btnUcitajIzDatoteke;
        private System.Windows.Forms.ListBox lstKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

