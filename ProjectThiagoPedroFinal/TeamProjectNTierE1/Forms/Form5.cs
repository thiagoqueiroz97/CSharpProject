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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string errMsg = ValidateForm();

                if (errMsg != string.Empty)
                {
                    MessageBox.Show(errMsg, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StudentBL stuBl = new StudentBL();
                    Student stu2 = new Student();

                    if (stuBl.AddStudent(PopulateStudentObject()))
                    {
                        MessageBox.Show("Insert Successful!");
                        ClearData();
                    }
                    else
                    {
                        string msg = string.Empty;
                        foreach (ValidationError error in stuBl.Errors)
                        {
                            msg += error.Description + Environment.NewLine;
                        }
                        stuBl.Errors.Clear();
                        MessageBox.Show(msg);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearData()
        {
            txtFirstName.Text = string.Empty;
            txtID.Text = string.Empty;
            comboBox1.SelectedValue = 1;
            txtLastName.Text = string.Empty;
            chkStatus.Checked = false;
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
        }

        public string ValidateForm()
        {
            string errMsg = string.Empty;

            if (txtID.Text == string.Empty)
            {
                errMsg = "Student ID cannot be blank";
            }

            if (txtFirstName.Text == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "First name cannot be blank.";
            }

            if (txtLastName.Text == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "Last name cannot be blank.";
            }

            if (comboBox1.SelectedIndex < 0)
            {
                errMsg = errMsg + Environment.NewLine + "Please select a program type.";
                }

            return errMsg;

        }

        private Student PopulateStudentObject()
        {
            return new Student()
            {
                StudentId = txtID.Text,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value,
                ProgramId = Convert.ToInt32(comboBox1.SelectedValue),
                StudentStatus = chkStatus.Checked.ToString(),
                Address = txtAddress.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim().ToUpper(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                City = txtCity.Text.Trim()

            };
        }

        private void Form5_Load(object sender, EventArgs e)
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
    }

}

