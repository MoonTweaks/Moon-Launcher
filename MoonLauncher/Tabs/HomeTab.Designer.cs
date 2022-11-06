namespace MoonLauncher.Tabs
{
    partial class HomeTab
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(120, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 73);
            this.button3.TabIndex = 11;
            this.button3.Text = "Play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(92, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 23);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(90, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Epic Games Launcher Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(90, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fortnite Game Directory:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(92, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 23);
            this.textBox2.TabIndex = 14;
            // 
            // HomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(441, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HomeTab";
            this.Text = "HomeTab";
            this.Load += new System.EventHandler(this.HomeTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}