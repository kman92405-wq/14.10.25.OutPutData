using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Model1 DB = new Model1();
        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControlName1.Fill(Motorbikes[AccNumber]);
            userControlName2.Fill(Motorbikes[AccNumber+1]);
        }

        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
            {
                AccNumber++;
            }

            else if (Incr == false && 0 <= AccNumber - 1)
            {
                AccNumber--;
            }

            else
                return;

            Loading();
        }


        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Loading();
        }
    }
}
