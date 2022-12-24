﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace BookShop
{
    public partial class InfoBookControl : UserControl
    {
        public OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");
        
        public InfoBookControl()
        {
            InitializeComponent();
        }


        bool changet3 = false;
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (changet3)
            {
                gunaAdvenceButton1.ForeColor = Color.Black;
                gunaAdvenceButton1.BackColor = SystemColors.Control;
                gunaAdvenceButton1.Text = "Добавить в корзину";
                gunaAdvenceButton1.ImageOffsetX = 0;
                DeleteBasketBook();
            }
            else
            {
                gunaAdvenceButton1.ForeColor = Color.White;
                gunaAdvenceButton1.BackColor = Color.Black;
                gunaAdvenceButton1.Text = "Книга в корзине";
                gunaAdvenceButton1.ImageOffsetX = 10;
                AddBasketBook();
            }
            changet3 = !changet3;
        }
        
        private void AddBasketBook()
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                gunaPictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);

                OleDbCommand command = new OleDbCommand("INSERT INTO Basket (bName, bPhoto, bPrice) VALUES ('" + gunaLabel1.Text + "', @photo, '" + gunaLabel12.Text + "')", myConnection);
                command.Parameters.AddWithValue("@photo", Photo);

                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }

        private void DeleteBasketBook()
        {
            try
            {
                OleDbCommand command = new OleDbCommand("DELETE FROM Basket WHERE bName='" + gunaLabel1.Text + "'", myConnection);
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
            }
        }
        
    }
}
