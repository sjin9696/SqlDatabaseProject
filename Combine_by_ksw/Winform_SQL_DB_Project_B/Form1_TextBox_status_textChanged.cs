using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_SQL_DB_Project_B
{
    public partial class Form1 : Form //송진영
    {
        private void Form1_TextBox_status_textChanged()
        {
            ///
            /// 텍스트 박스 상태 체인지 이벤트핸들러 연결하기
            ///
            textBox_Middle.TextChanged += new EventHandler(this.textBox_status_TextChanged);
            textBox_Right_Sql.TextChanged += new EventHandler(this.textBox_status_TextChanged);
            textBox_Right_status.TextChanged += new EventHandler(this.textBox_status_TextChanged);
            textBox_Right_error.TextChanged += new EventHandler(this.textBox_status_TextChanged);
        }
        private void textBox_status_TextChanged(object sender, EventArgs e)
        {
            ///
            /// 텍스트 박스 기능 : 텍스트 입력 되면 스크롤 최 하단으로 가기
            ///
            textBox_Right_status.SelectionStart = textBox_Right_status.Text.Length;
            textBox_Right_status.ScrollToCaret();
        }
    }
}
