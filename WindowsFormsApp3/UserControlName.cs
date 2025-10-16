﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.FolderforModel;

namespace WindowsFormsApp3
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }



        public void Fill (Table_Motorbike Motorbike)
        {
            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelIDData_Click(object sender, EventArgs e)
        {

        }
    }
}
