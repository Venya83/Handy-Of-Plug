
namespace Handy_Of_Plug_Scarlet_Blood_Fury
{
    partial class Form_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_admin));
            this.DataBaseGrid = new System.Windows.Forms.DataGridView();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.Mark_Box = new System.Windows.Forms.TextBox();
            this.Owner = new System.Windows.Forms.Label();
            this.Owner_Box = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.Date_Box = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.Price_Box = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.Label();
            this.Discounts_Box = new System.Windows.Forms.TextBox();
            this.Debt = new System.Windows.Forms.Label();
            this.Debt_Box = new System.Windows.Forms.TextBox();
            this.Add_butt = new System.Windows.Forms.Button();
            this.Edit_butt = new System.Windows.Forms.Button();
            this.Delete_butt = new System.Windows.Forms.Button();
            this.Close_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date2_Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBaseGrid
            // 
            this.DataBaseGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.DataBaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseGrid.Location = new System.Drawing.Point(12, 32);
            this.DataBaseGrid.Name = "DataBaseGrid";
            this.DataBaseGrid.Size = new System.Drawing.Size(1170, 284);
            this.DataBaseGrid.TabIndex = 0;
            this.DataBaseGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseGrid_CellContentClick);
            // 
            // ID_Box
            // 
            this.ID_Box.BackColor = System.Drawing.Color.Gray;
            this.ID_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_Box.ForeColor = System.Drawing.Color.White;
            this.ID_Box.Location = new System.Drawing.Point(12, 348);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(81, 20);
            this.ID_Box.TabIndex = 1;
            this.ID_Box.TextChanged += new System.EventHandler(this.ID_Box_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(12, 332);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.ForeColor = System.Drawing.Color.White;
            this.Mark.Location = new System.Drawing.Point(99, 332);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(66, 13);
            this.Mark.TabIndex = 4;
            this.Mark.Text = "Марка авто";
            // 
            // Mark_Box
            // 
            this.Mark_Box.BackColor = System.Drawing.Color.Gray;
            this.Mark_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark_Box.ForeColor = System.Drawing.Color.White;
            this.Mark_Box.Location = new System.Drawing.Point(99, 348);
            this.Mark_Box.Name = "Mark_Box";
            this.Mark_Box.Size = new System.Drawing.Size(91, 20);
            this.Mark_Box.TabIndex = 3;
            this.Mark_Box.TextChanged += new System.EventHandler(this.Mark_Box_TextChanged);
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.ForeColor = System.Drawing.Color.White;
            this.Owner.Location = new System.Drawing.Point(196, 332);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(56, 13);
            this.Owner.TabIndex = 6;
            this.Owner.Text = "Владелец";
            // 
            // Owner_Box
            // 
            this.Owner_Box.BackColor = System.Drawing.Color.Gray;
            this.Owner_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Owner_Box.ForeColor = System.Drawing.Color.White;
            this.Owner_Box.Location = new System.Drawing.Point(196, 348);
            this.Owner_Box.Name = "Owner_Box";
            this.Owner_Box.Size = new System.Drawing.Size(81, 20);
            this.Owner_Box.TabIndex = 5;
            this.Owner_Box.TextChanged += new System.EventHandler(this.Owner_Box_TextChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(283, 332);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(117, 13);
            this.Date.TabIndex = 8;
            this.Date.Text = "Дата и время въезда";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Date_Box
            // 
            this.Date_Box.BackColor = System.Drawing.Color.Gray;
            this.Date_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_Box.ForeColor = System.Drawing.Color.White;
            this.Date_Box.Location = new System.Drawing.Point(283, 348);
            this.Date_Box.Name = "Date_Box";
            this.Date_Box.Size = new System.Drawing.Size(118, 20);
            this.Date_Box.TabIndex = 7;
            this.Date_Box.TextChanged += new System.EventHandler(this.Date_Box_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.ForeColor = System.Drawing.Color.White;
            this.Price.Location = new System.Drawing.Point(408, 332);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(62, 13);
            this.Price.TabIndex = 10;
            this.Price.Text = "Стоимость";
            // 
            // Price_Box
            // 
            this.Price_Box.BackColor = System.Drawing.Color.Gray;
            this.Price_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price_Box.ForeColor = System.Drawing.Color.White;
            this.Price_Box.Location = new System.Drawing.Point(408, 348);
            this.Price_Box.Name = "Price_Box";
            this.Price_Box.Size = new System.Drawing.Size(91, 20);
            this.Price_Box.TabIndex = 9;
            this.Price_Box.TextChanged += new System.EventHandler(this.Price_Box_TextChanged);
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.ForeColor = System.Drawing.Color.White;
            this.Discount.Location = new System.Drawing.Point(505, 332);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(44, 13);
            this.Discount.TabIndex = 12;
            this.Discount.Text = "Скидки";
            // 
            // Discounts_Box
            // 
            this.Discounts_Box.BackColor = System.Drawing.Color.Gray;
            this.Discounts_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Discounts_Box.ForeColor = System.Drawing.Color.White;
            this.Discounts_Box.Location = new System.Drawing.Point(505, 348);
            this.Discounts_Box.Name = "Discounts_Box";
            this.Discounts_Box.Size = new System.Drawing.Size(100, 20);
            this.Discounts_Box.TabIndex = 11;
            this.Discounts_Box.TextChanged += new System.EventHandler(this.Discounts_Box_TextChanged);
            // 
            // Debt
            // 
            this.Debt.AutoSize = true;
            this.Debt.ForeColor = System.Drawing.Color.White;
            this.Debt.Location = new System.Drawing.Point(611, 332);
            this.Debt.Name = "Debt";
            this.Debt.Size = new System.Drawing.Size(81, 13);
            this.Debt.TabIndex = 14;
            this.Debt.Text = "Задолженость";
            // 
            // Debt_Box
            // 
            this.Debt_Box.BackColor = System.Drawing.Color.Gray;
            this.Debt_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Debt_Box.ForeColor = System.Drawing.Color.White;
            this.Debt_Box.Location = new System.Drawing.Point(611, 348);
            this.Debt_Box.Name = "Debt_Box";
            this.Debt_Box.Size = new System.Drawing.Size(119, 20);
            this.Debt_Box.TabIndex = 13;
            this.Debt_Box.TextChanged += new System.EventHandler(this.Debt_Box_TextChanged);
            // 
            // Add_butt
            // 
            this.Add_butt.BackColor = System.Drawing.Color.DarkGray;
            this.Add_butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_butt.ForeColor = System.Drawing.Color.White;
            this.Add_butt.Location = new System.Drawing.Point(12, 385);
            this.Add_butt.Name = "Add_butt";
            this.Add_butt.Size = new System.Drawing.Size(81, 29);
            this.Add_butt.TabIndex = 15;
            this.Add_butt.Text = "Добавить";
            this.Add_butt.UseVisualStyleBackColor = false;
            this.Add_butt.Click += new System.EventHandler(this.Add_butt_Click);
            // 
            // Edit_butt
            // 
            this.Edit_butt.BackColor = System.Drawing.Color.DarkGray;
            this.Edit_butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_butt.ForeColor = System.Drawing.Color.White;
            this.Edit_butt.Location = new System.Drawing.Point(99, 385);
            this.Edit_butt.Name = "Edit_butt";
            this.Edit_butt.Size = new System.Drawing.Size(122, 29);
            this.Edit_butt.TabIndex = 16;
            this.Edit_butt.Text = "Редактировать";
            this.Edit_butt.UseVisualStyleBackColor = false;
            this.Edit_butt.Click += new System.EventHandler(this.Edit_butt_Click);
            // 
            // Delete_butt
            // 
            this.Delete_butt.BackColor = System.Drawing.Color.DarkGray;
            this.Delete_butt.FlatAppearance.BorderSize = 2;
            this.Delete_butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_butt.ForeColor = System.Drawing.Color.White;
            this.Delete_butt.Location = new System.Drawing.Point(227, 385);
            this.Delete_butt.Name = "Delete_butt";
            this.Delete_butt.Size = new System.Drawing.Size(81, 29);
            this.Delete_butt.TabIndex = 17;
            this.Delete_butt.Text = "Удалить";
            this.Delete_butt.UseVisualStyleBackColor = false;
            this.Delete_butt.Click += new System.EventHandler(this.Delete_butt_Click);
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
            this.Close_butt.Location = new System.Drawing.Point(1161, -5);
            this.Close_butt.Name = "Close_butt";
            this.Close_butt.Size = new System.Drawing.Size(31, 31);
            this.Close_butt.TabIndex = 18;
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
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "РЕДАКТОР";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(733, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Датат и время выезда";
            // 
            // Date2_Box
            // 
            this.Date2_Box.BackColor = System.Drawing.Color.Gray;
            this.Date2_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date2_Box.ForeColor = System.Drawing.Color.White;
            this.Date2_Box.Location = new System.Drawing.Point(736, 348);
            this.Date2_Box.Name = "Date2_Box";
            this.Date2_Box.Size = new System.Drawing.Size(120, 20);
            this.Date2_Box.TabIndex = 21;
            this.Date2_Box.TextChanged += new System.EventHandler(this.Date2_Box_TextChanged);
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1194, 426);
            this.Controls.Add(this.Date2_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_butt);
            this.Controls.Add(this.Delete_butt);
            this.Controls.Add(this.Edit_butt);
            this.Controls.Add(this.Add_butt);
            this.Controls.Add(this.Debt);
            this.Controls.Add(this.Debt_Box);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Discounts_Box);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Price_Box);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Date_Box);
            this.Controls.Add(this.Owner);
            this.Controls.Add(this.Owner_Box);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Mark_Box);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.DataBaseGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_admin";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_admin";
            this.Load += new System.EventHandler(this.Form_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBaseGrid;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.TextBox Mark_Box;
        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.TextBox Owner_Box;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox Date_Box;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox Price_Box;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.TextBox Discounts_Box;
        private System.Windows.Forms.Label Debt;
        private System.Windows.Forms.TextBox Debt_Box;
        private System.Windows.Forms.Button Add_butt;
        private System.Windows.Forms.Button Edit_butt;
        private System.Windows.Forms.Button Delete_butt;
        private System.Windows.Forms.Button Close_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Date2_Box;
    }
}