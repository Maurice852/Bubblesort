namespace Bubblesort
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
            this.Listbox1 = new System.Windows.Forms.ListBox();
            this.FillRandom = new System.Windows.Forms.Button();
            this.Listbox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Listbox1
            // 
            this.Listbox1.FormattingEnabled = true;
            this.Listbox1.ItemHeight = 16;
            this.Listbox1.Location = new System.Drawing.Point(23, 123);
            this.Listbox1.Name = "Listbox1";
            this.Listbox1.Size = new System.Drawing.Size(120, 228);
            this.Listbox1.TabIndex = 0;
            // 
            // FillRandom
            // 
            this.FillRandom.Location = new System.Drawing.Point(23, 51);
            this.FillRandom.Name = "FillRandom";
            this.FillRandom.Size = new System.Drawing.Size(99, 23);
            this.FillRandom.TabIndex = 1;
            this.FillRandom.Text = "Fill random";
            this.FillRandom.UseVisualStyleBackColor = true;
            this.FillRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // Listbox2
            // 
            this.Listbox2.FormattingEnabled = true;
            this.Listbox2.ItemHeight = 16;
            this.Listbox2.Location = new System.Drawing.Point(176, 123);
            this.Listbox2.Name = "Listbox2";
            this.Listbox2.Size = new System.Drawing.Size(120, 228);
            this.Listbox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.Listbox2);
            this.Controls.Add(this.FillRandom);
            this.Controls.Add(this.Listbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Listbox1;
        private System.Windows.Forms.Button FillRandom;
        private System.Windows.Forms.ListBox Listbox2;
    }
}

