namespace FinalProject
{
    partial class IP4Validator
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
            this.exitbtn = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.validateip = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(534, 239);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(187, 40);
            this.exitbtn.TabIndex = 15;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(321, 239);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(187, 40);
            this.resetbutton.TabIndex = 14;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // validateip
            // 
            this.validateip.Location = new System.Drawing.Point(95, 239);
            this.validateip.Name = "validateip";
            this.validateip.Size = new System.Drawing.Size(187, 40);
            this.validateip.TabIndex = 13;
            this.validateip.Text = "Validate IP";
            this.validateip.UseVisualStyleBackColor = true;
            this.validateip.Click += new System.EventHandler(this.validateip_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(321, 180);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(343, 22);
            this.textbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter IP address: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Today :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IP4Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.validateip);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label1);
            this.Name = "IP4Validator";
            this.Text = "IP4-Validator";
            this.Load += new System.EventHandler(this.IP4Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button validateip;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}