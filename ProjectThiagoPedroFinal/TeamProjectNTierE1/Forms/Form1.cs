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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Student stu;
        private Resource ro;
        private Loan Lo;

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
                dtvStudentInfo.DataSource = stuList;

                LoanBL loBl = new LoanBL();
                List<Loan> loanList = new List<Loan>();
                loanList = loBl.GetLoan(studentId);
                dtgStudentLoanInfo.DataSource = loanList;

                dtvStudentInfo.Columns[0].Visible = false;
                dtgStudentLoanInfo.Columns[0].Visible = false;
                dtgStudentLoanInfo.Columns[1].Visible = false;
                dtgStudentLoanInfo.Columns[5].Visible = false;
                dtgStudentLoanInfo.Columns[6].Visible = false;
                dtgStudentLoanInfo.Columns[9].Visible = false;
                dtvStudentInfo.Columns["ProgramId"].Visible = false;
                dtvStudentInfo.Columns["Address"].Visible = false;
                dtvStudentInfo.Columns["City"].Visible = false;
                dtvStudentInfo.Columns["PhoneNumber"].Visible = false;
                dtvStudentInfo.Columns["TimeStamp"].Visible = false;
                dtvStudentInfo.Columns["PostalCode"].Visible = false;

            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        List<Resource> resourcestoborrow = new List<Resource>();

        private void btnResourceRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReourceIdSearch.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the resources ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ResourceBL reBl = new ResourceBL();
                    string resourceId = txtReourceIdSearch.Text;
                    List<Resource> displayRe = new List<Resource>();
                    ro = reBl.GetResource(resourceId);


                  
                        displayRe.Add(ro);
                        dtgResourceInfo.DataSource = displayRe;
                      

                    dtgResourceInfo.Columns[0].Visible = false;
                    dtgResourceInfo.Columns[2].Visible = false;
                    dtgResourceInfo.Columns[5].Visible = false;
                    dtgResourceInfo.Columns[6].Visible = false;
                    dtgResourceInfo.Columns[7].Visible = false;
                    dtgResourceInfo.Columns[8].Visible = false;
                    dtgResourceInfo.Columns[9].Visible = false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceBL rebl = new ResourceBL();
                LoanBL loBL = new LoanBL();
                int counter = 0;
                foreach (Resource r in resourcestoborrow)
                {
                    if (loBL.CreateLoan(PopulateLoanObject(r, counter), r) && rebl.UpdateResource(r.ResourceId))
                    {
                        LoanBL loBl = new LoanBL();
                        List<Loan> loanList = new List<Loan>();
                        loanList = loBl.GetLoan(dtvStudentInfo.Rows[0].Cells["StudentId"].Value.ToString());
                        dtgStudentLoanInfo.DataSource = loanList;

                        if (resourcestoborrow.IndexOf(r) == resourcestoborrow.Count - 1)
                        {
                            MessageBox.Show("Resources were borrowed.");
                        }

                    }
                    else
                    {
                        string msg = string.Empty;
                        foreach (ValidationError error in loBL.Errors)
                        {
                            msg += error.Description + Environment.NewLine;
                        }
                        loBL.Errors.Clear();
                        MessageBox.Show(msg);
                        
                    }
                    
                }
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Loan PopulateLoanObject(Resource r, int c)
        {
            Loan loan = new Loan();

            loan.StudentId = dtvStudentInfo.Rows[0].Cells["StudentId"].Value.ToString();
            loan.ResourceId = r.ResourceId;
            loan.CheckOutDate = DateTime.Now;
            loan.DueDate = DateTime.Now.AddDays(2);
            loan.LoanStatusId = 1;

            //bool isOnList = false;

            //foreach (DataGridViewRow row in dtgStudentLoanInfo.Rows)
            //{
            //    if (rid == row.Cells["ResourceId"].Value.ToString())
            //    {
            //        isOnList = true;
            //    }
            //    else
            //    {
            //        isOnList = false;
            //    }
            //}

            //if (isOnList == false)
            //{
                
            //}
            //else
            //{
                loan.ResourceTypeId = r.ResourceTypeId;
                
            //}
            
            return loan;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            try
            {

                if (resourcestoborrow.Any(resource => resource.ResourceId == ro.ResourceId))
                {
                }
                else
                {
                    resourcestoborrow.Add(ro);
                }

                //find another way to stop adding
                if (lstItemsToLoan.Items.Contains(dtgResourceInfo.Rows[0].Cells["ResourceId"].Value.ToString() + " " + "Date to return: " + DateTime.Today.AddDays(3).AddHours(-3.5).ToString()))
                {
                    MessageBox.Show("That resource is already on the list");
                }
                else
                {
                    lstItemsToLoan.Items.Add(dtgResourceInfo.Rows[0].Cells["ResourceId"].Value.ToString() + " " + "Date to return: " + DateTime.Today.AddDays(3).AddHours(-3.5).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgResourceInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearStudent_Click(object sender, EventArgs e)
        {

            txtStudentSearchName.Text = string.Empty;
            txtStudentSearchId.Text = string.Empty;
            dtgStudentLoanInfo.DataSource = null;
            dtgStudentLoanInfo.Rows.Clear();
            dtvStudentInfo.DataSource = null;
            dtvStudentInfo.Rows.Clear();
            lstSearchResult.SelectedIndexChanged -= new EventHandler(lstSearchResult_SelectedIndexChanged);
            lstSearchResult.DataSource = null;
            lstSearchResult.Items.Clear();
            lstSearchResult.SelectedIndexChanged += new EventHandler(lstSearchResult_SelectedIndexChanged);

        }

        private void btnClearResource_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtReourceIdSearch.Text = string.Empty;
            dtgResourceInfo.DataSource = null;
            dtgResourceInfo.Rows.Clear();
            lstItemsToLoan.DataSource = null;
            lstItemsToLoan.Items.Clear();
            resourcestoborrow.Clear();
        }
    }
}
