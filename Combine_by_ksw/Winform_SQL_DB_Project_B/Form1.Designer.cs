namespace Winform_SQL_DB_Project_B
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Left_Treeview = new System.Windows.Forms.Panel();
            this.treeView_Left = new System.Windows.Forms.TreeView();
            this.imageList_Tree_Icon = new System.Windows.Forms.ImageList(this.components);
            this.panel_Middle = new System.Windows.Forms.Panel();
            this.tabControl_Middle = new System.Windows.Forms.TabControl();
            this.tabPage_Middle_datagridview = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage_Middle_textbox = new System.Windows.Forms.TabPage();
            this.textBox_Middle = new System.Windows.Forms.TextBox();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.groupBox_Right = new System.Windows.Forms.GroupBox();
            this.panel_Right_DMLs = new System.Windows.Forms.TableLayoutPanel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Right_Select = new System.Windows.Forms.TextBox();
            this.textBox_Right_Delete = new System.Windows.Forms.TextBox();
            this.textBox_Right_Insert = new System.Windows.Forms.TextBox();
            this.textBox_Right_Update = new System.Windows.Forms.TextBox();
            this.button_Updata = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.panel_Right_status = new System.Windows.Forms.Panel();
            this.tabControl_Right_status = new System.Windows.Forms.TabControl();
            this.tabPage_Right_status = new System.Windows.Forms.TabPage();
            this.textBox_Right_status = new System.Windows.Forms.TextBox();
            this.tabPage_Right_error = new System.Windows.Forms.TabPage();
            this.textBox_Right_error = new System.Windows.Forms.TextBox();
            this.panel_Right_Sql_exec = new System.Windows.Forms.Panel();
            this.button_Sql_exec = new System.Windows.Forms.Button();
            this.panel_Right_Sql_Text = new System.Windows.Forms.Panel();
            this.textBox_Right_Sql = new System.Windows.Forms.TextBox();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Left_Treeview.SuspendLayout();
            this.panel_Middle.SuspendLayout();
            this.tabControl_Middle.SuspendLayout();
            this.tabPage_Middle_datagridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage_Middle_textbox.SuspendLayout();
            this.panel_Right.SuspendLayout();
            this.groupBox_Right.SuspendLayout();
            this.panel_Right_DMLs.SuspendLayout();
            this.panel_Right_status.SuspendLayout();
            this.tabControl_Right_status.SuspendLayout();
            this.tabPage_Right_status.SuspendLayout();
            this.tabPage_Right_error.SuspendLayout();
            this.panel_Right_Sql_exec.SuspendLayout();
            this.panel_Right_Sql_Text.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Left_Treeview
            // 
            this.panel_Left_Treeview.Controls.Add(this.treeView_Left);
            this.panel_Left_Treeview.Location = new System.Drawing.Point(3, 21);
            this.panel_Left_Treeview.Name = "panel_Left_Treeview";
            this.panel_Left_Treeview.Size = new System.Drawing.Size(194, 561);
            this.panel_Left_Treeview.TabIndex = 0;
            // 
            // treeView_Left
            // 
            this.treeView_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Left.Location = new System.Drawing.Point(0, 0);
            this.treeView_Left.Name = "treeView_Left";
            this.treeView_Left.Size = new System.Drawing.Size(194, 561);
            this.treeView_Left.TabIndex = 0;
            this.treeView_Left.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Left_AfterSelect);
            // 
            // imageList_Tree_Icon
            // 
            this.imageList_Tree_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Tree_Icon.ImageStream")));
            this.imageList_Tree_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Tree_Icon.Images.SetKeyName(0, "folder.png");
            // 
            // panel_Middle
            // 
            this.panel_Middle.Controls.Add(this.tabControl_Middle);
            this.panel_Middle.Location = new System.Drawing.Point(206, 12);
            this.panel_Middle.Name = "panel_Middle";
            this.panel_Middle.Size = new System.Drawing.Size(543, 577);
            this.panel_Middle.TabIndex = 1;
            // 
            // tabControl_Middle
            // 
            this.tabControl_Middle.AccessibleName = "";
            this.tabControl_Middle.Controls.Add(this.tabPage_Middle_datagridview);
            this.tabControl_Middle.Controls.Add(this.tabPage_Middle_textbox);
            this.tabControl_Middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Middle.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Middle.Name = "tabControl_Middle";
            this.tabControl_Middle.SelectedIndex = 0;
            this.tabControl_Middle.Size = new System.Drawing.Size(543, 577);
            this.tabControl_Middle.TabIndex = 1;
            // 
            // tabPage_Middle_datagridview
            // 
            this.tabPage_Middle_datagridview.Controls.Add(this.dataGridView);
            this.tabPage_Middle_datagridview.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Middle_datagridview.Name = "tabPage_Middle_datagridview";
            this.tabPage_Middle_datagridview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Middle_datagridview.Size = new System.Drawing.Size(535, 551);
            this.tabPage_Middle_datagridview.TabIndex = 0;
            this.tabPage_Middle_datagridview.Text = "테이블";
            this.tabPage_Middle_datagridview.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(529, 545);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // tabPage_Middle_textbox
            // 
            this.tabPage_Middle_textbox.Controls.Add(this.textBox_Middle);
            this.tabPage_Middle_textbox.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Middle_textbox.Name = "tabPage_Middle_textbox";
            this.tabPage_Middle_textbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Middle_textbox.Size = new System.Drawing.Size(535, 551);
            this.tabPage_Middle_textbox.TabIndex = 1;
            this.tabPage_Middle_textbox.Text = "프로시저";
            this.tabPage_Middle_textbox.UseVisualStyleBackColor = true;
            // 
            // textBox_Middle
            // 
            this.textBox_Middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Middle.Location = new System.Drawing.Point(3, 3);
            this.textBox_Middle.Multiline = true;
            this.textBox_Middle.Name = "textBox_Middle";
            this.textBox_Middle.Size = new System.Drawing.Size(529, 545);
            this.textBox_Middle.TabIndex = 0;
            // 
            // panel_Right
            // 
            this.panel_Right.Controls.Add(this.groupBox_Right);
            this.panel_Right.Controls.Add(this.panel_Right_status);
            this.panel_Right.Controls.Add(this.panel_Right_Sql_exec);
            this.panel_Right.Controls.Add(this.panel_Right_Sql_Text);
            this.panel_Right.Location = new System.Drawing.Point(755, 12);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(325, 577);
            this.panel_Right.TabIndex = 2;
            // 
            // groupBox_Right
            // 
            this.groupBox_Right.Controls.Add(this.panel_Right_DMLs);
            this.groupBox_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Right.Location = new System.Drawing.Point(0, 197);
            this.groupBox_Right.Name = "groupBox_Right";
            this.groupBox_Right.Size = new System.Drawing.Size(325, 150);
            this.groupBox_Right.TabIndex = 5;
            this.groupBox_Right.TabStop = false;
            this.groupBox_Right.Text = "자동완성기능";
            // 
            // panel_Right_DMLs
            // 
            this.panel_Right_DMLs.ColumnCount = 2;
            this.panel_Right_DMLs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05263F));
            this.panel_Right_DMLs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94737F));
            this.panel_Right_DMLs.Controls.Add(this.button_Delete, 1, 3);
            this.panel_Right_DMLs.Controls.Add(this.textBox_Right_Select, 0, 0);
            this.panel_Right_DMLs.Controls.Add(this.textBox_Right_Delete, 0, 3);
            this.panel_Right_DMLs.Controls.Add(this.textBox_Right_Insert, 0, 1);
            this.panel_Right_DMLs.Controls.Add(this.textBox_Right_Update, 0, 2);
            this.panel_Right_DMLs.Controls.Add(this.button_Updata, 1, 2);
            this.panel_Right_DMLs.Controls.Add(this.button_Insert, 1, 1);
            this.panel_Right_DMLs.Controls.Add(this.button_Select, 1, 0);
            this.panel_Right_DMLs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Right_DMLs.Location = new System.Drawing.Point(3, 17);
            this.panel_Right_DMLs.Name = "panel_Right_DMLs";
            this.panel_Right_DMLs.RowCount = 4;
            this.panel_Right_DMLs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_Right_DMLs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_Right_DMLs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_Right_DMLs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_Right_DMLs.Size = new System.Drawing.Size(319, 130);
            this.panel_Right_DMLs.TabIndex = 3;
            // 
            // button_Delete
            // 
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delete.Location = new System.Drawing.Point(197, 99);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(119, 28);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete (삭제)기능";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Right_Select
            // 
            this.textBox_Right_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Right_Select.Location = new System.Drawing.Point(3, 3);
            this.textBox_Right_Select.Name = "textBox_Right_Select";
            this.textBox_Right_Select.Size = new System.Drawing.Size(188, 21);
            this.textBox_Right_Select.TabIndex = 0;
            // 
            // textBox_Right_Delete
            // 
            this.textBox_Right_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Right_Delete.Location = new System.Drawing.Point(3, 99);
            this.textBox_Right_Delete.Name = "textBox_Right_Delete";
            this.textBox_Right_Delete.Size = new System.Drawing.Size(188, 21);
            this.textBox_Right_Delete.TabIndex = 0;
            // 
            // textBox_Right_Insert
            // 
            this.textBox_Right_Insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Right_Insert.Location = new System.Drawing.Point(3, 35);
            this.textBox_Right_Insert.Name = "textBox_Right_Insert";
            this.textBox_Right_Insert.Size = new System.Drawing.Size(188, 21);
            this.textBox_Right_Insert.TabIndex = 0;
            // 
            // textBox_Right_Update
            // 
            this.textBox_Right_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Right_Update.Enabled = false;
            this.textBox_Right_Update.Location = new System.Drawing.Point(3, 67);
            this.textBox_Right_Update.Name = "textBox_Right_Update";
            this.textBox_Right_Update.Size = new System.Drawing.Size(188, 21);
            this.textBox_Right_Update.TabIndex = 0;
            this.textBox_Right_Update.Text = "\"셀을 수정하고 눌러주세요\"";
            this.textBox_Right_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Updata
            // 
            this.button_Updata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Updata.Location = new System.Drawing.Point(197, 67);
            this.button_Updata.Name = "button_Updata";
            this.button_Updata.Size = new System.Drawing.Size(119, 26);
            this.button_Updata.TabIndex = 1;
            this.button_Updata.Text = "Updata (수정)기능";
            this.button_Updata.UseVisualStyleBackColor = true;
            this.button_Updata.Click += new System.EventHandler(this.button_Updata_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Insert.Location = new System.Drawing.Point(197, 35);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(119, 26);
            this.button_Insert.TabIndex = 1;
            this.button_Insert.Text = "Insert (입력)기능";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Select
            // 
            this.button_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Select.Location = new System.Drawing.Point(197, 3);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(119, 26);
            this.button_Select.TabIndex = 1;
            this.button_Select.Text = "Select (조회)기능";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // panel_Right_status
            // 
            this.panel_Right_status.Controls.Add(this.tabControl_Right_status);
            this.panel_Right_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Right_status.Location = new System.Drawing.Point(0, 347);
            this.panel_Right_status.Name = "panel_Right_status";
            this.panel_Right_status.Size = new System.Drawing.Size(325, 230);
            this.panel_Right_status.TabIndex = 4;
            // 
            // tabControl_Right_status
            // 
            this.tabControl_Right_status.Controls.Add(this.tabPage_Right_status);
            this.tabControl_Right_status.Controls.Add(this.tabPage_Right_error);
            this.tabControl_Right_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Right_status.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Right_status.Name = "tabControl_Right_status";
            this.tabControl_Right_status.SelectedIndex = 0;
            this.tabControl_Right_status.Size = new System.Drawing.Size(325, 230);
            this.tabControl_Right_status.TabIndex = 0;
            // 
            // tabPage_Right_status
            // 
            this.tabPage_Right_status.Controls.Add(this.textBox_Right_status);
            this.tabPage_Right_status.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Right_status.Name = "tabPage_Right_status";
            this.tabPage_Right_status.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Right_status.Size = new System.Drawing.Size(317, 204);
            this.tabPage_Right_status.TabIndex = 0;
            this.tabPage_Right_status.Text = "출력창";
            this.tabPage_Right_status.UseVisualStyleBackColor = true;
            // 
            // textBox_Right_status
            // 
            this.textBox_Right_status.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Right_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Right_status.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Right_status.Location = new System.Drawing.Point(3, 3);
            this.textBox_Right_status.Multiline = true;
            this.textBox_Right_status.Name = "textBox_Right_status";
            this.textBox_Right_status.Size = new System.Drawing.Size(311, 198);
            this.textBox_Right_status.TabIndex = 0;
            // 
            // tabPage_Right_error
            // 
            this.tabPage_Right_error.Controls.Add(this.textBox_Right_error);
            this.tabPage_Right_error.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Right_error.Name = "tabPage_Right_error";
            this.tabPage_Right_error.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Right_error.Size = new System.Drawing.Size(317, 204);
            this.tabPage_Right_error.TabIndex = 1;
            this.tabPage_Right_error.Text = "오류메세지";
            this.tabPage_Right_error.UseVisualStyleBackColor = true;
            // 
            // textBox_Right_error
            // 
            this.textBox_Right_error.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Right_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Right_error.Location = new System.Drawing.Point(3, 3);
            this.textBox_Right_error.Multiline = true;
            this.textBox_Right_error.Name = "textBox_Right_error";
            this.textBox_Right_error.Size = new System.Drawing.Size(311, 198);
            this.textBox_Right_error.TabIndex = 0;
            // 
            // panel_Right_Sql_exec
            // 
            this.panel_Right_Sql_exec.Controls.Add(this.button_Sql_exec);
            this.panel_Right_Sql_exec.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Right_Sql_exec.Location = new System.Drawing.Point(0, 143);
            this.panel_Right_Sql_exec.Name = "panel_Right_Sql_exec";
            this.panel_Right_Sql_exec.Size = new System.Drawing.Size(325, 54);
            this.panel_Right_Sql_exec.TabIndex = 3;
            // 
            // button_Sql_exec
            // 
            this.button_Sql_exec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Sql_exec.Location = new System.Drawing.Point(0, 0);
            this.button_Sql_exec.Name = "button_Sql_exec";
            this.button_Sql_exec.Size = new System.Drawing.Size(325, 54);
            this.button_Sql_exec.TabIndex = 0;
            this.button_Sql_exec.Text = "SQL 실행";
            this.button_Sql_exec.UseVisualStyleBackColor = true;
            this.button_Sql_exec.Click += new System.EventHandler(this.button_Sql_exec_Click);
            // 
            // panel_Right_Sql_Text
            // 
            this.panel_Right_Sql_Text.Controls.Add(this.textBox_Right_Sql);
            this.panel_Right_Sql_Text.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Right_Sql_Text.Location = new System.Drawing.Point(0, 0);
            this.panel_Right_Sql_Text.Name = "panel_Right_Sql_Text";
            this.panel_Right_Sql_Text.Size = new System.Drawing.Size(325, 143);
            this.panel_Right_Sql_Text.TabIndex = 1;
            // 
            // textBox_Right_Sql
            // 
            this.textBox_Right_Sql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Right_Sql.Location = new System.Drawing.Point(0, 0);
            this.textBox_Right_Sql.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_Right_Sql.Multiline = true;
            this.textBox_Right_Sql.Name = "textBox_Right_Sql";
            this.textBox_Right_Sql.Size = new System.Drawing.Size(325, 143);
            this.textBox_Right_Sql.TabIndex = 0;
            this.textBox_Right_Sql.Text = "\"Oracle SQL문을 입력하세요.\"";
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.panel_Left_Treeview);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(200, 596);
            this.panel_Left.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 596);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Middle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Left_Treeview.ResumeLayout(false);
            this.panel_Middle.ResumeLayout(false);
            this.tabControl_Middle.ResumeLayout(false);
            this.tabPage_Middle_datagridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage_Middle_textbox.ResumeLayout(false);
            this.tabPage_Middle_textbox.PerformLayout();
            this.panel_Right.ResumeLayout(false);
            this.groupBox_Right.ResumeLayout(false);
            this.panel_Right_DMLs.ResumeLayout(false);
            this.panel_Right_DMLs.PerformLayout();
            this.panel_Right_status.ResumeLayout(false);
            this.tabControl_Right_status.ResumeLayout(false);
            this.tabPage_Right_status.ResumeLayout(false);
            this.tabPage_Right_status.PerformLayout();
            this.tabPage_Right_error.ResumeLayout(false);
            this.tabPage_Right_error.PerformLayout();
            this.panel_Right_Sql_exec.ResumeLayout(false);
            this.panel_Right_Sql_Text.ResumeLayout(false);
            this.panel_Right_Sql_Text.PerformLayout();
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left_Treeview;
        private System.Windows.Forms.TreeView treeView_Left;
        private System.Windows.Forms.ImageList imageList_Tree_Icon;
        private System.Windows.Forms.Panel panel_Middle;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.TextBox textBox_Right_Sql;
        private System.Windows.Forms.Panel panel_Right_Sql_exec;
        private System.Windows.Forms.Button button_Sql_exec;
        private System.Windows.Forms.Panel panel_Right_status;
        private System.Windows.Forms.TabControl tabControl_Right_status;
        private System.Windows.Forms.TabPage tabPage_Right_status;
        private System.Windows.Forms.TextBox textBox_Right_status;
        private System.Windows.Forms.TabPage tabPage_Right_error;
        private System.Windows.Forms.TextBox textBox_Right_error;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Updata;
        private System.Windows.Forms.TextBox textBox_Right_Delete;
        private System.Windows.Forms.TextBox textBox_Right_Insert;
        private System.Windows.Forms.TextBox textBox_Right_Update;
        private System.Windows.Forms.TextBox textBox_Right_Select;
        private System.Windows.Forms.TableLayoutPanel panel_Right_DMLs;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Panel panel_Right_Sql_Text;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.GroupBox groupBox_Right;
        private System.Windows.Forms.TabControl tabControl_Middle;
        private System.Windows.Forms.TabPage tabPage_Middle_datagridview;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPage_Middle_textbox;
        private System.Windows.Forms.TextBox textBox_Middle;
    }
}

