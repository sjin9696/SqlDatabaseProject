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
        public void button_Select_auto_fill() // 이수민
        {
           
            textBox_Right_Sql.Text = "select * from " + tabPage_Middle_datagridview.Text;
            
            textBox_Right_Select.Clear();
        }
        public void button_Insert_auto_fill() // 이수민
        {
            string str = "";
            for (int i = 1; i< dataGridView.ColumnCount; i++) 
            {
                str += ',';
            }

            textBox_Right_Sql.Text = "Insert into " + tabPage_Middle_datagridview.Text + " values "+"("+str+") --type이 char형식이면 괄호 넣으셔야합니다";
            textBox_Right_Insert.Clear();
        }
        public void button_Delete_auto_fill() // 이수민
        {
            textBox_Right_Sql.Text = "Delete from " + tabPage_Middle_datagridview.Text + " where 조건식" ;
            
            textBox_Right_Delete.Clear();
        }
    }
}
