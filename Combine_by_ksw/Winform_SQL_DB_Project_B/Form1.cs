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
        }

        private void button_Sql_exec_Click(object sender, EventArgs e) // 곽상우,허선용
        {
            string time_set = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string errmsg = DataManager.Cmd_Oracle(textBox_Right_Sql.Text, tabPage_Middle_datagridview.Text);

            if (errmsg == "1")
            {
                tabControl_Right_status.SelectedIndex = 0;
                textBox_Right_status.Text += time_set + " " + textBox_Right_Sql.Text + Environment.NewLine;
            }
            else
            {
                tabControl_Right_status.SelectedIndex = 1;
                textBox_Right_error.Text = errmsg;
            }
            DataManager.Cmd_Oracle(textBox_Right_Sql.Text, tabPage_Middle_datagridview.Text);

            dataGridView.DataSource = DataManager.ds.Tables[0];
        }

        private void button_Select_Click(object sender, EventArgs e) // 우종훈
        {
            button_Select_auto_fill();
        }

        private void button_Insert_Click(object sender, EventArgs e) // 우종훈
        {
            button_Insert_auto_fill();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) // 곽상우
        {
            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Yellow;
        }

        private void button_Updata_Click(object sender, EventArgs e) // 우종훈 -> 이수민
        {
            button_Update_auto_fill();
        }

        private void button_Delete_Click(object sender, EventArgs e) // 우종훈 -> 이수민
        {
            button_Delete_auto_fill();
        }

        private void treeView_Left_AfterSelect(object sender, TreeViewEventArgs e) // 허선용 -> 곽상우
        {
            if (e.Node.Text == "테이블" || e.Node.Text == "프로시저" || e.Node.Text == "시퀀스")
            {

            }
            else
            {
                if (e.Node.Parent.Text == "프로시저" || e.Node.Parent.Text == "시퀀스")
                    tabControl_Middle.SelectedIndex = 1;
                else
                {
                    tabControl_Middle.SelectedIndex = 0;
                }

                textBox_Middle.Text = null;
                string notice = null;
                notice = DataManager.Tree_Oracle(e.Node.Text, e.Node.Parent.Text);
                if (e.Node.Parent.Text == "프로시저" || e.Node.Parent.Text == "시퀀스")
                    tabPage_Middle_textbox.Text = e.Node.Text;
                else
                {
                    tabPage_Middle_datagridview.Text = e.Node.Text;

                }

                dataGridView.DataSource = DataManager.ds.Tables[0];
                textBox_Middle.Text = notice;

                string time_set = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                textBox_Right_status.Text += time_set + " " + e.Node.Text + "가 선택되었습니다" + Environment.NewLine;
            }
        }
    }
}
