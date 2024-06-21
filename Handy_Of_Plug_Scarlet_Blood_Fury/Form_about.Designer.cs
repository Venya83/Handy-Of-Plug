
namespace Handy_Of_Plug_Scarlet_Blood_Fury
{
    partial class Form_about
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
            this.Close_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close_butt
            // 
            this.Close_butt.BackColor = System.Drawing.Color.Transparent;
            this.Close_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_butt.FlatAppearance.BorderSize = 0;
            this.Close_butt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close_butt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_butt.ForeColor = System.Drawing.Color.White;
            this.Close_butt.Location = new System.Drawing.Point(770, -4);
            this.Close_butt.Name = "Close_butt";
            this.Close_butt.Size = new System.Drawing.Size(31, 31);
            this.Close_butt.TabIndex = 19;
            this.Close_butt.Text = "×";
            this.Close_butt.UseVisualStyleBackColor = false;
            this.Close_butt.Click += new System.EventHandler(this.Close_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "О ПРОГРАММЕ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(341, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Здесь ничего нет.";
            // 
            // Form_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_butt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_about";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_about";
            this.Load += new System.EventHandler(this.Form_about_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}