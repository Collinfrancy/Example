using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1Project
{
    public partial class SalaryPage : Form
    {
        public SalaryPage()
        {
            InitializeComponent();
        }
        private List<JobTitle> jobs = new List<JobTitle> {
            new JobTitle { Title = "a", Salary = 1.0 },
            new JobTitle { Title = "b", Salary = 2.0 },
            new JobTitle { Title = "c", Salary = 3.0 }
        };
        private JobTitle newJob = new JobTitle { Title = "", Salary = 0.0 };
        private JobTitle editJob = null;

        private void RefreshPage()
        {
            grdSalaries.DataSource = null;
            grdSalaries.DataSource = jobs;

            //cmbSalaries.DataSource = null;
            //cmbSalaries.DisplayMember = "Display";
            //cmbSalaries.ValueMember = "Title";
            //cmbSalaries.DataSource = jobs;

            //lstSalaries.DataSource = null;
            //lstSalaries.DisplayMember = "Display";
            //lstSalaries.ValueMember = "Title";
            //lstSalaries.DataSource = jobs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RefreshPage();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            newJob = new JobTitle { Title = "", Salary = 0.0 };
            txtJobTitle.Text = newJob.Title;
            txtSalary.Text = newJob.Salary.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newJob.Title = txtJobTitle.Text;
            newJob.Salary = double.Parse(txtSalary.Text);
            jobs.Add(newJob);
            //
            RefreshPage();
            btnClear_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editJob.Title = txtEditJobTitle.Text;
            editJob.Salary = double.Parse(txtEditSalary.Text);

            RefreshPage();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdSalaries.SelectionMode != DataGridViewSelectionMode.FullRowSelect)
            {
                MessageBox.Show("Design Grid well.");
                return;
            }
            if (grdSalaries.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select Salary");
                return;
            }

            this.editJob = (JobTitle)grdSalaries.SelectedRows[0].DataBoundItem;
            txtEditJobTitle.Text = editJob.Title;
            txtEditSalary.Text = editJob.Salary.ToString();

            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdSalaries.SelectionMode != DataGridViewSelectionMode.FullRowSelect)
            {
                MessageBox.Show("Design Grid well.");
                return;
            }
            if (grdSalaries.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select Salary");
                return;
            }
            this.editJob = (JobTitle)grdSalaries.SelectedRows[0].DataBoundItem;
            this.jobs.Remove(this.editJob);
            btnSave.Enabled = false;
            this.editJob = null;

            RefreshPage();
        }

       
    }
}
