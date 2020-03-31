using BLL;
using Model;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private Student stu;

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentSearchId.Text == string.Empty && txtStudentSearchName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter either the student ID or Last name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    LoadStudentList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadStudentList()
        {
            ListsBL listsBl = new ListsBL();
            var l = listsBl.GetStudent(txtStudentSearchName.Text, txtStudentSearchId.Text);


            SelectionMode selectionMode = lstSearchResult.SelectionMode;

            lstSearchResult.SelectionMode = SelectionMode.None;

            lstSearchResult.DataSource = l;
            lstSearchResult.DisplayMember = "FullName";
            lstSearchResult.ValueMember = "StudentId";

            lstSearchResult.SelectionMode = selectionMode;
        }

        private void lstSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string studentId = lstSearchResult.SelectedValue.ToString();

                StudentBL stuBl = new StudentBL();
                List<Student> stuList = new List<Student>();
                stu = stuBl.GetStudent(studentId);
                stuList.Add(stu);
                dgvStudentInfo.DataSource = stuList;
                dgvStudentInfo.Columns[0].Visible = false;
                dgvStudentInfo.Columns["Address"].Visible = false;
                dgvStudentInfo.Columns["City"].Visible = false;
                dgvStudentInfo.Columns["PhoneNumber"].Visible = false;
                dgvStudentInfo.Columns["TimeStamp"].Visible = false;
                dgvStudentInfo.Columns["PostalCode"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            StudentBL stuBl = new StudentBL();

            if (Convert.ToDecimal(txtAmmountToPay.Text) < 1)
            {
                MessageBox.Show("Invalid ammount please enter a number greater than 0");
            }
            else if (stuBl.MakePayment(dgvStudentInfo.Rows[0].Cells["StudentId"].Value.ToString(), dgvStudentInfo.Rows[0].Cells["FirstName"].Value.ToString() + " " + dgvStudentInfo.Rows[0].Cells["LastName"].Value.ToString(), Convert.ToDecimal(txtAmmountToPay.Text)))
            {
                MessageBox.Show("Payment successful");
                ClearData();
            }
            else
            {
                MessageBox.Show("There was a problem");
                ClearData();
            }

        }

        private void ClearData()
        {
            
            txtStudentSearchId.Text = string.Empty;
            txtStudentSearchName.Text = string.Empty;
            
            dgvStudentInfo.DataSource = null;
            dgvStudentInfo.Rows.Clear();
            lstSearchResult.SelectedIndexChanged -= new EventHandler(lstSearchResult_SelectedIndexChanged);
            lstSearchResult.DataSource = null;
            lstSearchResult.Items.Clear();
            lstSearchResult.SelectedIndexChanged += new EventHandler(lstSearchResult_SelectedIndexChanged);
        }

    }
}
