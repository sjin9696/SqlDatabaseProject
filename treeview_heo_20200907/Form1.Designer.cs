namespace _20200904_DB메뉴_윈폼에표시
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("테이블");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("프로시저");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("시퀀스");
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테이블ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테이블11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로시저ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시퀀스ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(584, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테이블ToolStripMenuItem,
            this.프로시저ToolStripMenuItem,
            this.시퀀스ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            this.메뉴ToolStripMenuItem.Click += new System.EventHandler(this.메뉴ToolStripMenuItem_Click);
            // 
            // 테이블ToolStripMenuItem
            // 
            this.테이블ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테이블11ToolStripMenuItem});
            this.테이블ToolStripMenuItem.Name = "테이블ToolStripMenuItem";
            this.테이블ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.테이블ToolStripMenuItem.Text = "테이블";
            // 
            // 테이블11ToolStripMenuItem
            // 
            this.테이블11ToolStripMenuItem.Name = "테이블11ToolStripMenuItem";
            this.테이블11ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.테이블11ToolStripMenuItem.Text = "테이블11";
            // 
            // 프로시저ToolStripMenuItem
            // 
            this.프로시저ToolStripMenuItem.Name = "프로시저ToolStripMenuItem";
            this.프로시저ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.프로시저ToolStripMenuItem.Text = "프로시저";
            // 
            // 시퀀스ToolStripMenuItem
            // 
            this.시퀀스ToolStripMenuItem.Name = "시퀀스ToolStripMenuItem";
            this.시퀀스ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.시퀀스ToolStripMenuItem.Text = "시퀀스";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 319);
            this.textBox1.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(603, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "테이블";
            treeNode1.Text = "테이블";
            treeNode2.Name = "프로시저";
            treeNode2.Text = "프로시저";
            treeNode3.Name = "시퀀스";
            treeNode3.Text = "시퀀스";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(121, 437);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.메뉴ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.프로시저1ToolStripMenuItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 테이블ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로시저ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시퀀스ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem 테이블11ToolStripMenuItem;
    }
}

