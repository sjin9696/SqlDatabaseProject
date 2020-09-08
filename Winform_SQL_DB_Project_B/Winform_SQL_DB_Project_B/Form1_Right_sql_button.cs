using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Form1_Right_sql_button.cs 우종훈 2020-09-08
namespace Winform_SQL_DB_Project_B
{
    public partial class Form1 : Form
    {
        public void button_Select_auto_fill()
        {
            if (textBox_Right_Select.Text == "")
            {
                textBox_Right_Sql.Text = "Select * from 테이블 이름을 입력하세요;";
            }
            else
            {
                textBox_Right_Sql.Text = "Select * from " + textBox_Right_Select.Text + ";";
            }
            textBox_Right_Select.Clear();
        }
        public void button_Insert_auto_fill()
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
        public void button_Delete_auto_fill()
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
    }
}
