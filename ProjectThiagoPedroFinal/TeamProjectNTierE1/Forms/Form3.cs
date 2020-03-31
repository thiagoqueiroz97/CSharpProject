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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private Resource ro;
        private Student stu;

        private void btnResouceSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResourceID.Text == string.Empty)
                {
                    MessageBox.Show("Search cannot be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string ResourceId = txtResourceID.Text;

                    ResourceBL reBl = new ResourceBL();
                    List<Resource> reList = new List<Resource>();
                    ro = reBl.GetResourceForm3(ResourceId);
                    reList.Add(ro);
                    dgvResourceInfo.DataSource = reList;
                    dgvResourceInfo.Columns[0].Visible = false;
                    dgvResourceInfo.Columns[2].Visible = false;
                    dgvResourceInfo.Columns[5].Visible = false;
                    dgvResourceInfo.Columns[6].Visible = false;
                    dgvResourceInfo.Columns[7].Visible = false;
                    dgvResourceInfo.Columns[8].Visible = false;
                    dgvResourceInfo.Columns[9].Visible = false;
                    dgvResourceInfo.Columns[11].Visible = false;
                    dgvResourceInfo.Columns[12].Visible = false;

                    if (reBl.Errors.Count > 0)
                    {
                        string msg = string.Empty;
                        foreach (ValidationError error in reBl.Errors)
                        {
                            msg += error.Description + Environment.NewLine;
                        }
                        reBl.Errors.Clear();
                        MessageBox.Show(msg);

                        ClearData();

                    }

                }
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

        private void lstSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string studentId = lstSearchResult.SelectedValue.ToString();

                StudentBL stuBl = new StudentBL();
                List<Student> stuList = new List<Student>();
                stu = stuBl.GetStudentForm3(studentId);
                stuList.Add(stu);
                dgvStudentInfo.DataSource = stuList;
                dgvStudentInfo.Columns[0].Visible = false;
                dgvStudentInfo.Columns[6].Visible = false;
                dgvStudentInfo.Columns["Address"].Visible = false;
                dgvStudentInfo.Columns["City"].Visible = false;
                dgvStudentInfo.Columns["PhoneNumber"].Visible = false;
                dgvStudentInfo.Columns["TimeStamp"].Visible = false;
                dgvStudentInfo.Columns["PostalCode"].Visible = false;

                if (stuBl.Errors.Count > 0)
                {
                    string msg = string.Empty;
                    foreach (ValidationError error in stuBl.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    stuBl.Errors.Clear();
                    MessageBox.Show(msg);

                    ClearData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            ResourceBL reBl = new ResourceBL();

            if (reBl.ReserveResource(dgvResourceInfo.Rows[0].Cells["ResourceId"].Value.ToString(), dgvStudentInfo.Rows[0].Cells["StudentId"].Value.ToString(), dgvStudentInfo.Rows[0].Cells["FirstName"].Value.ToString() + " " + dgvStudentInfo.Rows[0].Cells["LastName"].Value.ToString()))
            {
                MessageBox.Show("Reserve successful");
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
            txtResourceID.Text = string.Empty;
            txtStudentSearchId.Text = string.Empty;
            txtStudentSearchName.Text = string.Empty;
            dgvResourceInfo.DataSource = null;
            dgvResourceInfo.Rows.Clear();
            dgvStudentInfo.DataSource = null;
            dgvStudentInfo.Rows.Clear();
            lstSearchResult.SelectedIndexChanged -= new EventHandler(lstSearchResult_SelectedIndexChanged);
            lstSearchResult.DataSource = null;
            lstSearchResult.Items.Clear();
            lstSearchResult.SelectedIndexChanged += new EventHandler(lstSearchResult_SelectedIndexChanged);
        }

    }
}
