using Oracle.ManagedDataAccess.Client;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200904_DB메뉴_윈폼에표시
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		private void 메뉴ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool retValue = false;
			string dbIp = "localhost";
			string dbName = "XE";
			string dbId = "hr";
			string dbPw = "1234";

			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand("select table_name from user_tables", pgOraConn);
				OracleCommand pgOraCmd1 = new OracleCommand("SELECT object_name FROM user_objects WHERE object_type = 'PROCEDURE'", pgOraConn);
				OracleCommand pgOraCmd2 = new OracleCommand("SELECT sequence_name FROM USER_SEQUENCES", pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				OracleDataAdapter oda1 = new OracleDataAdapter(pgOraCmd1);
				OracleDataAdapter oda2 = new OracleDataAdapter(pgOraCmd2);
				DataSet ds = new DataSet();
				DataSet ds1 = new DataSet();
				DataSet ds2 = new DataSet();

				oda.Fill(ds);
				oda1.Fill(ds1);
				oda2.Fill(ds2);
				int idx = ds.Tables[0].Rows.Count;
				int idx1 = ds1.Tables[0].Rows.Count;
				int idx2 = ds2.Tables[0].Rows.Count;

				pgOraConn.Close();
				
				this.테이블ToolStripMenuItem.DropDownItems.Clear();
				for (int i = 0; i < idx; i++)
				{
					System.Windows.Forms.ToolStripMenuItem temp = new ToolStripMenuItem();
					temp.Size = new System.Drawing.Size(180, 22);
					temp.Text = ds.Tables[0].Rows[i][0].ToString();
					this.테이블ToolStripMenuItem.DropDownItems.Add(temp);
					temp.Click += new System.EventHandler(this.테이블1ToolStripMenuItem_Click);
				}
				this.프로시저ToolStripMenuItem.DropDownItems.Clear();
				for (int i = 0; i < idx1; i++)
				{
					System.Windows.Forms.ToolStripMenuItem temp = new ToolStripMenuItem();
					temp.Size = new System.Drawing.Size(180, 22);
					temp.Text = ds1.Tables[0].Rows[i][0].ToString();
					this.프로시저ToolStripMenuItem.DropDownItems.Add(temp);
					temp.Click += new System.EventHandler(this.프로시저1ToolStripMenuItem_Click);
				}
				this.시퀀스ToolStripMenuItem.DropDownItems.Clear();
				for (int i = 0; i < idx2; i++)
				{
					System.Windows.Forms.ToolStripMenuItem temp = new ToolStripMenuItem();
					temp.Size = new System.Drawing.Size(180, 22);
					temp.Text = ds2.Tables[0].Rows[i][0].ToString();
					this.시퀀스ToolStripMenuItem.DropDownItems.Add(temp);
					temp.Click += new System.EventHandler(this.시퀀스1ToolStripMenuItem_Click);
				}
			}
			catch (Exception ae)
			{
				retValue = false;
				MessageBox.Show($"DB connection fail.\n {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


        private void 테이블1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
            bool retValue = false;
			string dbIp = "localhost";
			string dbName = "XE";
			string dbId = "hr";
			string dbPw = "1234";

			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand("select * from "+sender, pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds = new DataSet();
				oda.Fill(ds);
				dataGridView1.DataSource = ds.Tables[0];
				pgOraConn.Close();
			}
			catch (Exception ae)
			{
				retValue = false;
				MessageBox.Show($"DB connection fail.\n {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void 프로시저1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender+"호출하자");
			bool retValue = false;
			string dbIp = "localhost";
			string dbName = "XE";
			string dbId = "hr";
			string dbPw = "1234";

			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand("SELECT * FROM user_source WHERE name=upper('"+sender+"')", pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds = new DataSet();
				oda.Fill(ds);
				int idx = ds.Tables[0].Rows.Count;
				dataGridView1.DataSource = ds.Tables[0];
				textBox1.Text = null;
                for (int i = 0; i < idx; i++)
                {
					textBox1.Text += ds.Tables[0].Rows[i][3].ToString()+Environment.NewLine;
				}
				
				pgOraConn.Close();
			}
			catch (Exception ae)
			{
				retValue = false;
				MessageBox.Show($"DB connection fail.\n {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        private void 시퀀스1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MessageBox.Show(sender + "호출하자");

			bool retValue = false;
			string dbIp = "localhost";
			string dbName = "XE";
			string dbId = "hr";
			string dbPw = "1234";

			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand("SELECT * FROM USER_SEQUENCES WHERE SEQUENCE_NAME = '"+sender+"'", pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds = new DataSet();
				oda.Fill(ds);
				int idx = ds.Tables[0].Rows.Count;
				dataGridView1.DataSource = ds.Tables[0];
				textBox1.Text = null;
				for (int i = 0; i < 8; i++)
				{
					textBox1.Text += ds.Tables[0].Rows[0][i].ToString() + Environment.NewLine;
				}

				pgOraConn.Close();
			}
			catch (Exception ae)
			{
				retValue = false;
				MessageBox.Show($"DB connection fail.\n {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
			bool retValue = false;
			string dbIp = "localhost";
			string dbName = "XE";
			string dbId = "hr";
			string dbPw = "1234";

			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand("select table_name from user_tables", pgOraConn);
				OracleCommand pgOraCmd1 = new OracleCommand("SELECT object_name FROM user_objects WHERE object_type = 'PROCEDURE'", pgOraConn);
				OracleCommand pgOraCmd2 = new OracleCommand("SELECT sequence_name FROM USER_SEQUENCES", pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				OracleDataAdapter oda1 = new OracleDataAdapter(pgOraCmd1);
				OracleDataAdapter oda2 = new OracleDataAdapter(pgOraCmd2);
				DataSet ds = new DataSet();
				DataSet ds1 = new DataSet();
				DataSet ds2 = new DataSet();

				oda.Fill(ds);
				oda1.Fill(ds1);
				oda2.Fill(ds2);
				int idx = ds.Tables[0].Rows.Count;
				int idx1 = ds1.Tables[0].Rows.Count;
				int idx2 = ds2.Tables[0].Rows.Count;

				pgOraConn.Close();

				
				treeView1.Nodes.Clear();
				TreeNode treeNode_table = new TreeNode("테이블", 0, 0);
				for (int i = 0; i < idx; i++)
				{
					treeNode_table.Nodes.Add("", ds.Tables[0].Rows[i][0].ToString(), 0, 0);
				}
				treeView1.Nodes.Add(treeNode_table);

				TreeNode treeNode_procedure = new TreeNode("프로시저", 0, 0);
				for (int i = 0; i < idx1; i++)
				{
					treeNode_procedure.Nodes.Add("", ds.Tables[0].Rows[i][0].ToString(), 0, 0);
				}
				treeView1.Nodes.Add(treeNode_procedure);

				TreeNode treeNode_sequence = new TreeNode("시퀀스", 0, 0);
				for (int i = 0; i < idx2; i++)
				{
					treeNode_sequence.Nodes.Add("", ds.Tables[0].Rows[i][0].ToString(), 0, 0);
				}
				treeView1.Nodes.Add(treeNode_sequence);

			}
			catch (Exception ae)
			{
				retValue = false;
				MessageBox.Show($"DB connection fail.\n {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
