using IBroker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBroker
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            BindGridView();
        }

        public  void BindGridView()
        {
            List<DashboardCase> cases= new List<DashboardCase>();
            cases.Add(new DashboardCase("David Grey", "Lorem Ipsum is simply dummy text", "Completed", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("Stella Johnson", "Lorem Ipsum is simply dummy text", "In-Process", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("Marina Michel", "Lorem Ipsum is simply dummy text", "On Hold", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("John Doe", "Lorem Ipsum is simply dummy text", "Rejected", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("David Grey", "Lorem Ipsum is simply dummy text", "Completed", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("Stella Johnson", "Lorem Ipsum is simply dummy text", "In-Process", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("Marina Michel", "Lorem Ipsum is simply dummy text", "On Hold", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("John Doe", "Lorem Ipsum is simply dummy text", "Rejected", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("Marina Michel", "Lorem Ipsum is simply dummy text", "On Hold", "Aug 14, 2022 11:00 AM", "IB-123456"));
            cases.Add(new DashboardCase("John Doe", "Lorem Ipsum is simply dummy text", "Rejected", "Aug 14, 2022 11:00 AM", "IB-123456"));
            foreach(DashboardCase d in cases)
            {
                int rowindex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowindex];
                row.Cells[0].Value = d.User;
                row.Cells[1].Value = d.Case_Desc;
                row.Cells[2].Value = d.Status;
                row.Cells[3].Value = d.Last_Update;
                row.Cells[4].Value = d.Tracking_ID;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblTask_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try {
                Login l1 = new Login();
                l1.Show();
                DashBoard d1 = new DashBoard();
                d1.Hide();
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
           
        }
    }
}
