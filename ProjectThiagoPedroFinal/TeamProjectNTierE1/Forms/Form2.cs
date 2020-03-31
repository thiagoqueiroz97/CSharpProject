using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Student stu;
        private Resource ro;
        private Loan Lo;

        private void Form2_Load(object sender, EventArgs e)
        {
            LoanBL loBl = new LoanBL();
        }

        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceBL rebl = new ResourceBL();
                LoanBL loBL = new LoanBL();
                int count = 0;
                foreach (Resource r in resourcestoreturn)
                {
                    if (rebl.UpdateResource2(r) && loBL.UpdateLoan(loanstoupdate[count].LoanId, loanstoupdate[count].LoanStatusId))
                    {
                        count++;
                        if (resourcestoreturn.IndexOf(r) == resourcestoreturn.Count - 1)
                        {
                           
                            MessageBox.Show("Resources were returned.");
     

                        }
                    }
                    else
                    {
                        MessageBox.Show("There was a problem");
                    }
                }
                
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

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

                    StudentBL stuBl = new StudentBL();
                    List<Student> stuList = new List<Student>();
                    stu = stuBl.GetStudentByResourceId(ResourceId);
                    stuList.Add(stu);
                    dgvStudentInfo.DataSource = stuList;
                    dgvStudentInfo.Columns["ProgramId"].Visible = false;
                    dgvStudentInfo.Columns["Address"].Visible = false;
                    dgvStudentInfo.Columns["City"].Visible = false;
                    dgvStudentInfo.Columns["PhoneNumber"].Visible = false;
                    dgvStudentInfo.Columns["TimeStamp"].Visible = false;
                    dgvStudentInfo.Columns["PostalCode"].Visible = false;

                    LoanBL loBl = new LoanBL();
                    List<Loan> loanList = new List<Loan>();
                    //change indexes to column name
                    loanList = loBl.GetLoan(dgvStudentInfo.Rows[0].Cells["StudentId"].Value.ToString());
                    dgvLoanInfo.DataSource = loanList;
                    dgvLoanInfo.Columns[0].Visible = false;
                    dgvLoanInfo.Columns[1].Visible = false;
                    dgvLoanInfo.Columns[5].Visible = false;
                    dgvLoanInfo.Columns[6].Visible = false;
                    dgvLoanInfo.Columns[9].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        List<Resource> resourcestoreturn = new List<Resource>();
        List<Loan> loanstoupdate = new List<Loan>();

        private void dgvLoanInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResourceBL reBl = new ResourceBL();
                string resourceId = dgvLoanInfo.Rows[e.RowIndex].Cells["ResourceId"].Value.ToString();

                ro = reBl.GetResource(resourceId);

                string status = "";

                foreach (DataGridViewRow row in dgvLoanInfo.Rows)
                {
                    Loan l = row.DataBoundItem as Loan;

                    if (radioButton1.Checked == true)
                    {
                        ro.ResourceStatusId = 3;
                        l.LoanStatusId = 4;
                        status = "damaged";
                    }
                    if (radioButton2.Checked == true)
                    {
                        ro.ResourceStatusId = 3;
                        l.LoanStatusId = 3;
                        status = "missing";
                    }

                    if (!resourcestoreturn.Any(resource => resource.ResourceId == ro.ResourceId))
                    {
                        loanstoupdate.Add(l);
                    }

                }
                if (!resourcestoreturn.Any(resource => resource.ResourceId == ro.ResourceId))
                {
                    resourcestoreturn.Add(ro);
                    listBox1.Items.Add(dgvLoanInfo.Rows[e.RowIndex].Cells["ResourceId"].Value.ToString() + " " + status);
                    MessageBox.Show("Loan to return added");
                }

                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearData()
        {
            txtResourceID.Text = string.Empty;
            dgvLoanInfo.DataSource = null;
            dgvLoanInfo.Rows.Clear();
            dgvStudentInfo.DataSource = null;
            dgvStudentInfo.Rows.Clear();
            resourcestoreturn.Clear();
            loanstoupdate.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
