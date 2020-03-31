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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        Student stu = new Student();

        private void lstSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string studentId = lstSearchResult.SelectedValue.ToString();


                StudentBL stuBl = new StudentBL();
                stu = stuBl.GetStudentForm6(studentId);

                txtFirstName.Text = stu.FirstName;
                txtLastName.Text = stu.LastName;
                if (stu.StudentStatus.ToString() == "Active")
                {
                    chkStatus.Checked = true;
                }
                else
                {
                    chkStatus.Checked = false;
                }
                
                dtpStart.Value = stu.StartDate;
                dtpEnd.Value = stu.EndDate;
                txtAmmountDue.Text = stu.AmountDue.ToString();
                comboBox1.SelectedValue = stu.ProgramId;
                txtPostalCode.Text = stu.PostalCode;
                txtAddress.Text = stu.Address;
                txtCity.Text = stu.City;
                txtPhoneNumber.Text = stu.PhoneNumber;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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

        public string ValidateForm()
        {
            string errMsg = string.Empty;

            if (txtFirstName.Text == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "First name cannot be blank.";
            }

            if (txtLastName.Text == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Last name cannot be blank.";
            }

            if (txtAmmountDue.Text == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Ammount due cannot be blank.";
            }

            return errMsg;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentSearchId.Text == string.Empty && txtStudentSearchName.Text == string.Empty)
                {
                    MessageBox.Show("You  must retrieve a record first.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string errMsg = ValidateForm();

                if (errMsg != string.Empty)
                {
                    MessageBox.Show(errMsg, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StudentBL stuBl = new StudentBL();
                PopulateStudentObject();


                if (stuBl.ModifyStudent(stu))
                {
                    MessageBox.Show("Update Successful!");
                    ClearData();
                }
                else
                {
                    
                    MessageBox.Show("Update Failed!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateStudentObject()
        {

            stu.StudentId = stu.StudentId;
            stu.FirstName = txtFirstName.Text.Trim();
            stu.LastName = txtLastName.Text.Trim();
            stu.StartDate = dtpStart.Value;
            stu.EndDate = dtpEnd.Value;
            stu.ProgramId = Convert.ToInt32(comboBox1.SelectedValue);
            stu.StudentStatus = chkStatus.Checked.ToString();
            stu.AmountDue = Convert.ToDecimal(txtAmmountDue.Text);
            stu.Address = txtAddress.Text.Trim();
            stu.PostalCode = txtPostalCode.Text.Trim().ToUpper();
            stu.PhoneNumber = txtPhoneNumber.Text.Trim();
            stu.City = txtCity.Text.Trim();

        }

        private void ClearData()
        {
            txtFirstName.Text = string.Empty;
            txtStudentSearchId.Text = string.Empty;
            txtStudentSearchName.Text = string.Empty;
            comboBox1.SelectedValue = 1;
            txtLastName.Text = string.Empty;
            chkStatus.Checked = false;
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;
            txtAmmountDue.Text = string.Empty;
            lstSearchResult.SelectedIndexChanged -= new EventHandler(lstSearchResult_SelectedIndexChanged);
            lstSearchResult.DataSource = null;
            lstSearchResult.Items.Clear();
            lstSearchResult.SelectedIndexChanged += new EventHandler(lstSearchResult_SelectedIndexChanged);
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> CourseTypes = new Dictionary<string, int>()
            {
                { "Regular Program", 1 },
                { "Block Release", 2 },
            };

            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = new BindingSource(CourseTypes, null);
        }

        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentSearchId.Text == string.Empty && txtStudentSearchName.Text == string.Empty)
                {
                    MessageBox.Show("You  must retrieve a record first.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete the current record?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    txtStudentSearchName.Focus();
                    return;
                }

                StudentBL stuBL = new StudentBL();

                if (stuBL.DeleteStudent(stu.StudentId))
                {
                    ClearData();
                    MessageBox.Show("Delete Successful");
                }
                else
                {
                    string msg = string.Empty;

                    foreach (ValidationError error in stuBL.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }

                    MessageBox.Show(msg);
                    MessageBox.Show("Delete Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
