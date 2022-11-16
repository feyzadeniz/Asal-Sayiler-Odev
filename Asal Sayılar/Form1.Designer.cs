namespace Asal_Sayılar
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
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_bul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_asal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(148, 93);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(170, 23);
            this.textBox_tc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. Kimlik Numaranız:";
            // 
            // button_bul
            // 
            this.button_bul.Location = new System.Drawing.Point(195, 182);
            this.button_bul.Name = "button_bul";
            this.button_bul.Size = new System.Drawing.Size(75, 23);
            this.button_bul.TabIndex = 2;
            this.button_bul.Text = "Bul";
            this.button_bul.UseVisualStyleBackColor = true;
            this.button_bul.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "T.C. Kimlik Numaranızda Kaç Tane Asal Sayı Var?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "tane asal sayı var.";
            // 
            // label_asal
            // 
            this.label_asal.AutoSize = true;
            this.label_asal.Location = new System.Drawing.Point(186, 224);
            this.label_asal.Name = "label_asal";
            this.label_asal.Size = new System.Drawing.Size(13, 15);
            this.label_asal.TabIndex = 5;
            this.label_asal.Text = "x";
            this.label_asal.Click += new System.EventHandler(this.label_asal_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(473, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 169);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_bul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 315);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_asal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_bul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_tc;
        private Label label1;
        private Button button_bul;
        private Label label2;
        private Label label3;
        private Label label_asal;
        private ListBox listBox1;
    }
}