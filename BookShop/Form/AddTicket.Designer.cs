﻿namespace BookShop
{
    partial class AddBook
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.BoxCategory = new Guna.UI.WinForms.GunaComboBox();
            this.TextBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxYear = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxAge = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.PictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddBook = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxDiscription = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnBrowse = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.AutoScroll = true;
            this.gunaPanel2.Controls.Add(this.gunaLabel7);
            this.gunaPanel2.Controls.Add(this.BoxCategory);
            this.gunaPanel2.Controls.Add(this.TextBoxName);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Controls.Add(this.gunaLabel5);
            this.gunaPanel2.Controls.Add(this.TextBoxYear);
            this.gunaPanel2.Controls.Add(this.TextBoxAge);
            this.gunaPanel2.Location = new System.Drawing.Point(184, 30);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(351, 201);
            this.gunaPanel2.TabIndex = 35;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(3, 44);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel7.TabIndex = 37;
            this.gunaLabel7.Text = "Категория";
            // 
            // BoxCategory
            // 
            this.BoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.BoxCategory.BaseColor = System.Drawing.Color.White;
            this.BoxCategory.BorderColor = System.Drawing.Color.Silver;
            this.BoxCategory.BorderSize = 1;
            this.BoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxCategory.FocusedColor = System.Drawing.Color.Empty;
            this.BoxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BoxCategory.ForeColor = System.Drawing.Color.Black;
            this.BoxCategory.FormattingEnabled = true;
            this.BoxCategory.Items.AddRange(new object[] {
            "К-поп",
            "Рок",
            "Поп",
            "Джаз"});
            this.BoxCategory.Location = new System.Drawing.Point(68, 39);
            this.BoxCategory.Name = "BoxCategory";
            this.BoxCategory.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.BoxCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.BoxCategory.Radius = 10;
            this.BoxCategory.Size = new System.Drawing.Size(266, 26);
            this.BoxCategory.TabIndex = 8;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxName.BaseColor = System.Drawing.Color.White;
            this.TextBoxName.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxName.BorderSize = 1;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.Location = new System.Drawing.Point(68, 3);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.Radius = 10;
            this.TextBoxName.Size = new System.Drawing.Size(266, 30);
            this.TextBoxName.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Название";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 79);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(100, 15);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Дата проведения";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(3, 115);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(147, 15);
            this.gunaLabel5.TabIndex = 6;
            this.gunaLabel5.Text = "Возрастные ограничения";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxYear.BaseColor = System.Drawing.Color.White;
            this.TextBoxYear.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxYear.BorderSize = 1;
            this.TextBoxYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxYear.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxYear.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxYear.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxYear.Location = new System.Drawing.Point(109, 72);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.PasswordChar = '\0';
            this.TextBoxYear.Radius = 10;
            this.TextBoxYear.Size = new System.Drawing.Size(225, 30);
            this.TextBoxYear.TabIndex = 9;
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxAge.BaseColor = System.Drawing.Color.White;
            this.TextBoxAge.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxAge.BorderSize = 1;
            this.TextBoxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAge.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxAge.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAge.Location = new System.Drawing.Point(156, 108);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.PasswordChar = '\0';
            this.TextBoxAge.Radius = 10;
            this.TextBoxAge.Size = new System.Drawing.Size(178, 30);
            this.TextBoxAge.TabIndex = 17;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaPanel1.Controls.Add(this.PictureBox);
            this.gunaPanel1.Location = new System.Drawing.Point(33, 30);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(133, 164);
            this.gunaPanel1.TabIndex = 32;
            // 
            // PictureBox
            // 
            this.PictureBox.BaseColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(133, 164);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImage = null;
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(428, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 13;
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "  Закрыть";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.AnimationHoverSpeed = 0.07F;
            this.btnAddBook.AnimationSpeed = 0.03F;
            this.btnAddBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBook.BaseColor = System.Drawing.Color.DimGray;
            this.btnAddBook.BorderColor = System.Drawing.Color.Black;
            this.btnAddBook.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddBook.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddBook.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddBook.CheckedImage = null;
            this.btnAddBook.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBook.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddBook.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Image = null;
            this.btnAddBook.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddBook.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddBook.Location = new System.Drawing.Point(315, 393);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAddBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddBook.OnHoverImage = null;
            this.btnAddBook.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddBook.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBook.Radius = 13;
            this.btnAddBook.Size = new System.Drawing.Size(107, 31);
            this.btnAddBook.TabIndex = 29;
            this.btnAddBook.Text = " Добавить";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // TextBoxDiscription
            // 
            this.TextBoxDiscription.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxDiscription.BaseColor = System.Drawing.Color.White;
            this.TextBoxDiscription.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxDiscription.BorderSize = 1;
            this.TextBoxDiscription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDiscription.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxDiscription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxDiscription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxDiscription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDiscription.Location = new System.Drawing.Point(33, 257);
            this.TextBoxDiscription.MultiLine = true;
            this.TextBoxDiscription.Name = "TextBoxDiscription";
            this.TextBoxDiscription.PasswordChar = '\0';
            this.TextBoxDiscription.Radius = 10;
            this.TextBoxDiscription.Size = new System.Drawing.Size(502, 130);
            this.TextBoxDiscription.TabIndex = 28;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(30, 239);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "Описаие";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationHoverSpeed = 0.07F;
            this.btnBrowse.AnimationSpeed = 0.03F;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedForeColor = System.Drawing.Color.White;
            this.btnBrowse.CheckedImage = null;
            this.btnBrowse.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = null;
            this.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.Location = new System.Drawing.Point(33, 200);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnHoverImage = null;
            this.btnBrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowse.Radius = 10;
            this.btnBrowse.Size = new System.Drawing.Size(133, 31);
            this.btnBrowse.TabIndex = 26;
            this.btnBrowse.Text = "Добавить картинку";
            this.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPrice.BaseColor = System.Drawing.Color.White;
            this.TextBoxPrice.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPrice.BorderSize = 1;
            this.TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPrice.Location = new System.Drawing.Point(74, 394);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.PasswordChar = '\0';
            this.TextBoxPrice.Radius = 10;
            this.TextBoxPrice.Size = new System.Drawing.Size(92, 30);
            this.TextBoxPrice.TabIndex = 36;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(36, 401);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel8.TabIndex = 37;
            this.gunaLabel8.Text = "Цена";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 454);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.TextBoxDiscription);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTextBox TextBoxName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        public Guna.UI.WinForms.GunaTextBox TextBoxYear;
        private Guna.UI.WinForms.GunaTextBox TextBoxAge;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox PictureBox;
        public Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        public Guna.UI.WinForms.GunaAdvenceButton btnAddBook;
        private Guna.UI.WinForms.GunaTextBox TextBoxDiscription;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaAdvenceButton btnBrowse;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaComboBox BoxCategory;
        private Guna.UI.WinForms.GunaTextBox TextBoxPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
    }
}