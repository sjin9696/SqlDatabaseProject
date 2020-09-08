using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_SQL_DB_Project_B
{
    public partial class Form1 : Form
    {
        Form form_Update = new Form();
        DataGridView dataGridView_Update = new DataGridView();
        public void Initialized()
        {
            form_Update.Text = "수정 기능 창";
            form_Update.AutoSize = false;
            form_Update.StartPosition = FormStartPosition.CenterScreen;
            dataGridView_Update.Dock = DockStyle.Fill;
            form_Update.Controls.Add(dataGridView_Update);
        }
        public void Form1_Click_Update_form()
        {
            dataGridView_Update.DataSource = dataGridView.DataSource;
            form_Update.ShowDialog();
        }
        private void button_Updata_Click(object sender, EventArgs e)
        {
            Form1_Click_Update_form();
        }
    }
}
