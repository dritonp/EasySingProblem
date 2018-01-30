namespace Detyra2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVargu = new System.Windows.Forms.TextBox();
            this.btnAlgoritmi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sheno intonacionet";
            // 
            // txtVargu
            // 
            this.txtVargu.Location = new System.Drawing.Point(12, 25);
            this.txtVargu.Name = "txtVargu";
            this.txtVargu.Size = new System.Drawing.Size(535, 20);
            this.txtVargu.TabIndex = 11;
            // 
            // btnAlgoritmi
            // 
            this.btnAlgoritmi.BackColor = System.Drawing.Color.Teal;
            this.btnAlgoritmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlgoritmi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlgoritmi.Location = new System.Drawing.Point(12, 51);
            this.btnAlgoritmi.Name = "btnAlgoritmi";
            this.btnAlgoritmi.Size = new System.Drawing.Size(207, 34);
            this.btnAlgoritmi.TabIndex = 12;
            this.btnAlgoritmi.Text = "Gjenero vështërsinë minimale";
            this.btnAlgoritmi.UseVisualStyleBackColor = false;
            this.btnAlgoritmi.Click += new System.EventHandler(this.btnAlgoritmi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVargu);
            this.Controls.Add(this.btnAlgoritmi);
            this.Name = "Form1";
            this.Text = "EasySing Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVargu;
        private System.Windows.Forms.Button btnAlgoritmi;
    }
}

