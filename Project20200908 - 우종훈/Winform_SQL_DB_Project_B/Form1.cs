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
            Form1_TreeView(); //public partial class Form1 : Form
            MessageBox.Show(DataManager.Connect_Oracle());
            dataGridView.DataSource = DataManager.ds.Tables[0];
        }
        
        

        private void button_Sql_exec_Click(object sender, EventArgs e)
        {
            DataManager.Cmd_Oracle(textBox_Right_Sql.Text);
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            

            if(textBox_Right_Select.Text=="")
            {
                textBox_Right_Sql.Text = "Select * from 테이블 이름을 입력하세요;";
            }
            else
            {
                textBox_Right_Sql.Text = "Select * from "+ textBox_Right_Select.Text+";";
            }
            textBox_Right_Select.Clear();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (textBox_Right_Insert.Text == "")
            {
                textBox_Right_Sql.Text = "Insert into 테이블 이름을 입력하세요;";
            }
            else
            {
                textBox_Right_Sql.Text = "Insert into " + textBox_Right_Insert.Text + ";";
            }
            textBox_Right_Insert.Clear();
        }

        private void button_Updata_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_Right_Delete.Text == "")
            {
                textBox_Right_Sql.Text = "Delete 테이블 이름을 입력하세요;";
            }
            else
            {
                textBox_Right_Sql.Text = "Delete from " + textBox_Right_Delete.Text + ";";
            }
            textBox_Right_Delete.Clear();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView_Left_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
