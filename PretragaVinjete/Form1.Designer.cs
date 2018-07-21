namespace PretragaVinjete
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dodaj_ref = new System.Windows.Forms.Button();
            this.izbiris_ref = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 95);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reference excel fajlova :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pretrazi element";
            // 
            // dodaj_ref
            // 
            this.dodaj_ref.Location = new System.Drawing.Point(379, 174);
            this.dodaj_ref.Name = "dodaj_ref";
            this.dodaj_ref.Size = new System.Drawing.Size(97, 39);
            this.dodaj_ref.TabIndex = 3;
            this.dodaj_ref.Text = "Dodaj referencu";
            this.dodaj_ref.UseVisualStyleBackColor = true;
            this.dodaj_ref.Click += new System.EventHandler(this.dodaj_ref_Click);
            // 
            // izbiris_ref
            // 
            this.izbiris_ref.Location = new System.Drawing.Point(379, 118);
            this.izbiris_ref.Name = "izbiris_ref";
            this.izbiris_ref.Size = new System.Drawing.Size(97, 39);
            this.izbiris_ref.TabIndex = 4;
            this.izbiris_ref.Text = "Izbrisi referencu";
            this.izbiris_ref.UseVisualStyleBackColor = true;
            this.izbiris_ref.Click += new System.EventHandler(this.izbiris_ref_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Otvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.izbiris_ref);
            this.Controls.Add(this.dodaj_ref);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(563, 340);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pretrazi vinjete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodaj_ref;
        private System.Windows.Forms.Button izbiris_ref;
        private System.Windows.Forms.Button button1;
    }
}

