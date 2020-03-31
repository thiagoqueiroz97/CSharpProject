using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private Form1 checkout;


        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkout = new Form1();

            if (!CheckOpened(checkout.Text.ToString()))
            {
                checkout.Show();
            }
        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 checkin = new Form2();

            if (!CheckOpened(checkin.Text.ToString()))
            {
                checkin.Show();
            }
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 reserve = new Form3();

            if (!CheckOpened(reserve.Text.ToString()))
            {
                reserve.Show();
            }
        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 payment = new Form4();

            if (!CheckOpened(payment.Text.ToString()))
            {
                payment.Show();
            }
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 create = new Form5();

            if (!CheckOpened(create.Text.ToString()))
            {
                create.Show();
            }
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 management = new Form6();

            if (!CheckOpened(management.Text.ToString()))
            {
                management.Show();
            }
        }
    }
}
