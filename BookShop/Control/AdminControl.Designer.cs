﻿namespace BookShop
{
    partial class AdminControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControl));
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.CountUsers = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.CountBuyBooks = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnAddBook = new Guna.UI.WinForms.GunaPictureBox();
            this.CountBooks = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel3.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBook)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel6.Location = new System.Drawing.Point(7, 391);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(97, 19);
            this.gunaLabel6.TabIndex = 16;
            this.gunaLabel6.Text = "Пользователи";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(8, 96);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(46, 19);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Книги";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(11, 413);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(654, 155);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 261);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Controls.Add(this.CountUsers);
            this.gunaElipsePanel3.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(481, 9);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Size = new System.Drawing.Size(184, 77);
            this.gunaElipsePanel3.TabIndex = 10;
            // 
            // CountUsers
            // 
            this.CountUsers.BackColor = System.Drawing.Color.White;
            this.CountUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountUsers.Location = new System.Drawing.Point(0, 23);
            this.CountUsers.Name = "CountUsers";
            this.CountUsers.Size = new System.Drawing.Size(196, 45);
            this.CountUsers.TabIndex = 4;
            this.CountUsers.Text = "000";
            this.CountUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.White;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(0, 8);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(196, 15);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Количество пользователей";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.CountBuyBooks);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(261, 9);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(189, 77);
            this.gunaElipsePanel2.TabIndex = 11;
            // 
            // CountBuyBooks
            // 
            this.CountBuyBooks.BackColor = System.Drawing.Color.White;
            this.CountBuyBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBuyBooks.Location = new System.Drawing.Point(0, 23);
            this.CountBuyBooks.Name = "CountBuyBooks";
            this.CountBuyBooks.Size = new System.Drawing.Size(196, 45);
            this.CountBuyBooks.TabIndex = 3;
            this.CountBuyBooks.Text = "000";
            this.CountBuyBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(0, 8);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(196, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Купили книг";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.btnAddBook);
            this.gunaElipsePanel1.Controls.Add(this.CountBooks);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(12, 9);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(218, 77);
            this.gunaElipsePanel1.TabIndex = 8;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BaseColor = System.Drawing.Color.White;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.Location = new System.Drawing.Point(189, 48);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(26, 26);
            this.btnAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.TabStop = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // CountBooks
            // 
            this.CountBooks.BackColor = System.Drawing.Color.White;
            this.CountBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBooks.Location = new System.Drawing.Point(0, 23);
            this.CountBooks.Name = "CountBooks";
            this.CountBooks.Size = new System.Drawing.Size(196, 45);
            this.CountBooks.TabIndex = 2;
            this.CountBooks.Text = "000";
            this.CountBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(0, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(196, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Количество книг";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(680, 594);
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        public Guna.UI.WinForms.GunaLabel CountUsers;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        public Guna.UI.WinForms.GunaLabel CountBuyBooks;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox btnAddBook;
        public Guna.UI.WinForms.GunaLabel CountBooks;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
