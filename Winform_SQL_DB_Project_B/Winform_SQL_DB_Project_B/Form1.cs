using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_SQL_DB_Project_B
{
    public partial class Form1 : Form
    {
        Class_DM DataManager = new Class_DM();
        public Form1()
        {
            InitializeComponent();
            Form1_TreeView();   //public partial class Form1 : Form [File : Form1_TreeView.cs]
            Initialized();      //public partial class Form1 : Form [File : Form1_Click_Update_form.cs]
            MessageBox.Show(DataManager.Connect_Oracle());
            dataGridView.DataSource = DataManager.ds.Tables[0];
        }
        
        

        private void button_Sql_exec_Click(object sender, EventArgs e)
        {
            DataManager.Cmd_Oracle(textBox_Right_Sql.Text);
            dataGridView.DataSource = DataManager.ds.Tables[0];
        }

        private void button_Select_Click(object sender, EventArgs e)
        {

        }

        private void button_Insert_Click(object sender, EventArgs e)
        {

        }
        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView_Left_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataManager.Tree_Oracle(e.Node.Text);
            dataGridView.DataSource = DataManager.ds.Tables[0];
        }

        
    }
}
