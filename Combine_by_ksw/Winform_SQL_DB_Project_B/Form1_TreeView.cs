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

        public void Form1_TreeView()
        {
            Tree_Set();
            //Tree_Delete();
        }
        private void Tree_Set() // 허선용 -> 곽상우
        {
            int idx_table = DataManager.Make_Index("table");
            TreeNode table = new TreeNode("테이블", 0, 0);
            for (int i = 1; i < idx_table; i++)
            {
                table.Nodes.Add("", DataManager.ds.Tables[0].Rows[i][0].ToString(), 0, 0);
            }
            treeView_Left.Nodes.Add(table);

            int idx_proseger = DataManager.Make_Index("proseger");
            TreeNode proseger = new TreeNode("프로시저", 1, 1);
            for (int i = 0; i < idx_proseger; i++)
            {
                proseger.Nodes.Add("", DataManager.ds.Tables[0].Rows[i][0].ToString(), 1, 1);

            }
            treeView_Left.Nodes.Add(proseger);

            int idx_sequence = DataManager.Make_Index("sequence");
            TreeNode sequence = new TreeNode("시퀀스", 2, 2);
            for (int i = 0; i < idx_sequence; i++)
            {
                sequence.Nodes.Add("", DataManager.ds.Tables[0].Rows[i][0].ToString(), 2, 2);
            }
            treeView_Left.Nodes.Add(sequence);

            treeView_Left.ExpandAll();
        }
        private void Tree_Delete() // 곽상우
        {
            treeView_Left.Nodes.Clear();
        }
    }
}
