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
        bool RegCollapsed;
        public DashBoard()
        {
            InitializeComponent();
            BindTreeView();
            BindGridView();
        }
        public void BindTreeView()
        {
            treeView1.Nodes.Add("Dashboard  >");
            treeView1.Nodes.Add("Manage Registration ");
            treeView1.Nodes[1].Nodes.Add("View Registration");
            treeView1.Nodes[1].Nodes.Add("Party Registration");
            treeView1.Nodes.Add("Manage E-Forms");
            treeView1.Nodes[2].Nodes.Add("Manage E-Forms");
            treeView1.Nodes.Add("Manage Case");
            treeView1.Nodes[3].Nodes.Add("Manage E-Case");
            treeView1.Nodes.Add("Manage Rules");
            treeView1.Nodes.Add("Manage Partner");
            treeView1.Nodes.Add("Manage Product");
            treeView1.Nodes.Add("Manage Party");
            treeView1.Nodes[7].Nodes.Add("Manage Party");
            treeView1.Nodes.Add("Manage User");
            treeView1.Nodes[8].Nodes.Add("User Details");
            treeView1.Nodes[8].Nodes.Add("Role Details");
            treeView1.Nodes[8].Nodes[1].Nodes.Add("Role List");
            treeView1.Nodes[8].Nodes[1].Nodes.Add("Role Permission");
            treeView1.Nodes[8].Nodes[1].Nodes.Add("Role Assign");
            treeView1.Nodes[8].Nodes.Add("Office Details");
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
                int rowindex = grdCases.Rows.Add();
                DataGridViewRow row = grdCases.Rows[rowindex];
                row.Cells[0].Value = d.User;
                row.Cells[1].Value = d.Case_Desc;
                row.Cells[2].Value = d.Status;
                row.Cells[3].Value = d.Last_Update;
                row.Cells[4].Value = d.Tracking_ID;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Login l1 = new Login();
                l1.Show();
                DashBoard d1 = new DashBoard();
                d1.Hide();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        } 

    }
}
