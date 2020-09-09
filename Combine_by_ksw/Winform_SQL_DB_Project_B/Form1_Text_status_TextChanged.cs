using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_SQL_DB_Project_B
{
    public partial class Form1 : Form
    {
        private void textBox_status_TextChanged(object sender, EventArgs e)
        {
            textBox_Right_status.SelectionStart = textBox_Right_status.Text.Length;
            textBox_Right_status.ScrollToCaret();
        }
    }
}
