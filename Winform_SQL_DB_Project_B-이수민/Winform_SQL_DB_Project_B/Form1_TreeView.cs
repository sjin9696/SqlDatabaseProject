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
            int length = 5;
            TreeNode table = new TreeNode("Table", 0, 0);
            // for (int i = 1; i <= length; i++)
            //     table.Nodes.Add("테이블" + i, i + "번테이블", 0, 0);

            table.Nodes.Add("사원");
            table.Nodes.Add("대출");


            TreeNode proseger = new TreeNode("프로시저", 1, 1);
            for (int i = 1; i <= length; i++)
                proseger.Nodes.Add("프로시저" + i, i + "번프로시저", 1, 1);

            //트리노드를 트리뷰에 적용한다.
            treeView_Left.Nodes.Add(table);
            treeView_Left.Nodes.Add(proseger);

            //모든 트리 노드를 보여준다.
            treeView_Left.ExpandAll();
        }

    }
}
