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
            Form1_TreeView();   //public partial class Form1 : Form [File : Form1_Left_TreeView.cs]
            InitializeUpdate_Form();      //public partial class Form1 : Form [File : Form1_Right_Update_form.cs]
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
            button_Select_auto_fill(); //우종훈
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            button_Insert_auto_fill(); //우종훈
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            button_Delete_auto_fill(); //우종훈
        }
        private void treeView_Left_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataManager.Tree_Oracle(e.Node.Text);
            dataGridView.DataSource = DataManager.ds.Tables[0];
        }

        private void button_Updata_Click(object sender, EventArgs e)
        {
            Form1_Click_Update_form();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("11");
        }
    }
}
