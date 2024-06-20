
namespace Handy_Of_Plug_Scarlet_Blood_Fury
{
    partial class Form_Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.login_butt = new System.Windows.Forms.Button();
            this.user_comboBox = new System.Windows.Forms.ComboBox();
            this.password_Box = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.close_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // login_butt
            // 
            this.login_butt.BackColor = System.Drawing.Color.Transparent;
            this.login_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_butt.FlatAppearance.BorderSize = 0;
            this.login_butt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login_butt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_butt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_butt.ForeColor = System.Drawing.Color.White;
            this.login_butt.Location = new System.Drawing.Point(191, 631);
            this.login_butt.Name = "login_butt";
            this.login_butt.Size = new System.Drawing.Size(101, 31);
            this.login_butt.TabIndex = 0;
            this.login_butt.Text = "Войти";
            this.login_butt.UseVisualStyleBackColor = false;
            this.login_butt.Click += new System.EventHandler(this.login_butt_Click);
            // 
            // user_comboBox
            // 
            this.user_comboBox.BackColor = System.Drawing.Color.Silver;
            this.user_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_comboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_comboBox.FormattingEnabled = true;
            this.user_comboBox.Location = new System.Drawing.Point(133, 564);
            this.user_comboBox.Name = "user_comboBox";
            this.user_comboBox.Size = new System.Drawing.Size(230, 26);
            this.user_comboBox.TabIndex = 1;
            this.user_comboBox.SelectedIndexChanged += new System.EventHandler(this.user_comboBox_SelectedIndexChanged);
            // 
            // password_Box
            // 
            this.password_Box.BackColor = System.Drawing.Color.LightGray;
            this.password_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_Box.Location = new System.Drawing.Point(133, 596);
            this.password_Box.Name = "password_Box";
            this.password_Box.PasswordChar = '*';
            this.password_Box.Size = new System.Drawing.Size(230, 24);
            this.password_Box.TabIndex = 2;
            this.password_Box.TextChanged += new System.EventHandler(this.password_Box_TextChanged);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(133, 405);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(562, 134);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // close_butt
            // 
            this.close_butt.BackColor = System.Drawing.Color.Transparent;
            this.close_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_butt.FlatAppearance.BorderSize = 0;
            this.close_butt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_butt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_butt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_butt.ForeColor = System.Drawing.Color.White;
            this.close_butt.Location = new System.Drawing.Point(191, 668);
            this.close_butt.Name = "close_butt";
            this.close_butt.Size = new System.Drawing.Size(101, 34);
            this.close_butt.TabIndex = 4;
            this.close_butt.Text = "Выход";
            this.close_butt.UseVisualStyleBackColor = false;
            this.close_butt.Click += new System.EventHandler(this.close_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин:";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_butt);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.password_Box);
            this.Controls.Add(this.user_comboBox);
            this.Controls.Add(this.login_butt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handy Of Plug";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_butt;
        private System.Windows.Forms.ComboBox user_comboBox;
        private System.Windows.Forms.TextBox password_Box;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button close_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

