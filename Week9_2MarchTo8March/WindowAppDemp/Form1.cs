using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowAppDemp
{

    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-ELLK6DL\\SQLEXPRESS;Database=WindowForm; Integrated Security=True;TrustServerCertificate=True");
        SqlCommandBuilder Bldr; SqlDataAdapter da; DataRow rec;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("Select *  from Employeetb", con);
            ds = new DataSet();
            da.Fill(ds, "Employeetb");
            dataGridView1.DataSource = ds.Tables[0];
            da.FillSchema(ds, SchemaType.Source, "Employeetb");
            Bldr = new SqlCommandBuilder(da);
        }





        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                rec[1] = lblEmpName.Text;
                rec[2] = lblEmpDesig.Text;
                rec[3] = DateTime.Parse(lblEmpDOJ.Text);
                rec[4] = Convert.ToInt32(lblEmpSalary.Text);
                rec[5] = lblDeptNO.Text;
                btnUpdate.Enabled = false;
                MessageBox.Show("record is updated into dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].NewRow();
                rec[0] = Convert.ToInt32(txtEmpId.Text);
                rec[1] = lblEmpName.Text;
                rec[2] = lblEmpDesig.Text;
                rec[3] =DateTime.Parse(lblEmpDOJ.Text);
                rec[4] = int.Parse(lblEmpSalary.Text);
                rec[5] = lblDeptNO.Text;
                ds.Tables[0].Rows.Add(rec);
                MessageBox.Show("Record is Inserted into dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId=" + lblEmpId.Text)[0];
                lblEmpName.Text = rec[1].ToString();
                lblEmpDesig.Text = rec[2].ToString();
                lblEmpDOJ.Text = rec[3].ToString();
                lblEmpSalary.Text = rec[4].ToString();
                lblDeptNO.Text = rec[5].ToString();
                btnUpdate.Enabled = true;
                MessageBox.Show("record find");
            }
            catch
            {
                MessageBox.Show("record Not Found");
            }

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Text = "";
            }

        }

     
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId" + lblEmpId.Text)[0];
                rec.Delete();
                MessageBox.Show("Record is deleted from dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.HasChanges() == true)
                {
                    da.Update(ds, "Employeetb");
                    MessageBox.Show("Dataset data is Upadated into database");
                }
                else
                {
                    MessageBox.Show("No modifiaction in Dataset");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}


