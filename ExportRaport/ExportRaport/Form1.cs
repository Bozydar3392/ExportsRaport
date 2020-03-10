using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExportRaport
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlConnectionStringBuilder connStringBuilder;
        MonthCalendar calendar = new MonthCalendar();
        bool isStartSelected;

        public Form1()
        {
            InitializeComponent();
            
            //create calendar
            calendar.Location = new Point(0, 0);
            calendar.Name = "myCalendar";
            calendar.Size = new Size(160, 160);
            calendar.Visible = false;
            calendar.DateSelected += new DateRangeEventHandler(myCalendar_DateSelected);
            groupBox1.Controls.Add(calendar);
        }

        void ConnectTo()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = tbServer.Text; //"BOZY\\SQLEXPRESS";
            connStringBuilder.InitialCatalog = tbDatabase.Text; //"ExportsDB";
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
        }

        bool CreateTable()
        {
            string cmdText = "if exists(SELECT * FROM sys.tables WHERE name like 'Exports') " +
                            "drop table Exports " +
                            "create table Exports(Id int not null, ExportName text, Date datetime, UserName text, Local varchar(50)) "+
                            "";
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Data Base Connection Error");
                return false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return true;
        }

        void FillTable()
        {
            try
            {
                DateTime time = DateTime.Now;
                string cmdText = "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(1, 'Test1', '01-13-2020 12:01:17', 'Jan', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 12:17:12', 'Lech', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 12:36:27', 'Lech', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 13:47:52', 'Lech', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 14:03:18', 'Jan', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 14:11:12', 'Artur', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 14:28:55', 'Jan', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 14:47:12', 'Lech', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 15:29:32', 'Jan', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 15:31:33', 'Artur', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 15:52:59', 'Lech', 'Lokal4');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 16:16:12', 'Artur', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 16:42:18', 'Jan', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 16:58:37', 'Artur', 'Lokal4');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '01-13-2020 17:00:00', 'Artur', 'Lokal4');"

                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 12:17:12', 'Lech', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 12:36:27', 'Lech', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 13:47:52', 'Lech', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 14:03:18', 'Jan', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 14:11:12', 'Artur', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 14:28:55', 'Jan', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 14:47:12', 'Lech', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 15:29:32', 'Jan', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 15:31:33', 'Artur', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 15:52:59', 'Lech', 'Lokal4');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 16:16:12', 'Artur', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 16:42:18', 'Jan', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 16:58:37', 'Artur', 'Lokal4');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '02-13-2020 17:00:00', 'Artur', 'Lokal4');"

                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 12:17:12', 'Lech', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 12:36:27', 'Lech', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 13:47:52', 'Lech', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 14:03:18', 'Jan', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 14:11:12', 'Artur', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 14:28:55', 'Jan', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 14:47:12', 'Lech', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 15:29:32', 'Jan', 'Lokal3');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 15:31:33', 'Artur', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 15:52:59', 'Lech', 'Lokal4');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 16:16:12', 'Artur', 'Lokal1');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 16:42:18', 'Jan', 'Lokal2');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 16:58:37', 'Artur', 'Lokal4');"
                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(2, 'Test2', '03-13-2020 17:00:00', 'Artur', 'Lokal4');"

                                + "INSERT INTO dbo.Exports(Id, ExportName, Date, UserName, Local) VALUES(3, 'Test3', '04-09-2020 07:03:28', 'Henio', 'Local16');";
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Base Connection Error");
                throw;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public List<string> SelectLocal()
        {
            SortedSet<string> sortedLocalList = new SortedSet<string>();

            try
            {
                string cmdText = "SELECT Local FROM dbo.Exports";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sortedLocalList.Add(reader["Local"].ToString());
                }
                return sortedLocalList.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Base Connection Error");
                throw;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void myCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if(isStartSelected == true)
                cbDateStart.Text = calendar.SelectionStart.ToShortDateString();
            else
                cbDateEnd.Text = calendar.SelectionStart.ToShortDateString();
            calendar.Visible = false;
            if(cbDateStart.Text != "Od:" && cbDateEnd.Text != "Do:")
            {
                btZatwierdz.Enabled = true;
            }
        }

        private void btZatwierdz_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT ExportName, Date, UserName, Local FROM dbo.Exports WHERE Local = '" 
                    + cbLokal.Text + "' AND  Date >= '" + cbDateStart.Text +  "' AND Date <= '" + cbDateEnd.Text + "'", conn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView.DataSource = dtbl;

            }
            catch (Exception)
            {
                MessageBox.Show("Data Base Connection Error");
                throw;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void cbLokal_MouseClick(object sender, MouseEventArgs e)
        {
            cbLokal.DataSource = this.SelectLocal();
        }

        private void cbDateStart_MouseClick(object sender, MouseEventArgs e)
        {
            isStartSelected = true;
            if (cbDateEnd.Text != "Do:")
            {
                DateTime oDate = DateTime.Parse(cbDateEnd.Text);
                calendar.MinDate = new System.DateTime(1970, 1, 1);
                calendar.MaxDate = new System.DateTime(oDate.Year, oDate.Month, oDate.Day);
            }
            calendar.Location = new Point(25, 80);
            calendar.BringToFront();
            calendar.Visible = true;
        }

        private void cbDateEnd_MouseClick(object sender, MouseEventArgs e)
        {
            isStartSelected = false;
            if (cbDateEnd.Text != "Od:")
            {
                DateTime oDate = DateTime.Parse(cbDateStart.Text);
                calendar.MinDate = new System.DateTime(oDate.Year, oDate.Month, oDate.Day);
                calendar.MaxDate = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            calendar.Location = new Point(25, 120);
            calendar.BringToFront();
            calendar.Visible = true;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            ConnectTo();
            if (!CreateTable())
                return;
            FillTable();
            cbLokal.DataSource = this.SelectLocal();
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
            
        }
    }
}
