namespace NuGetServerManagementGUI.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TopMenu_ServerSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_NuGetPackages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_UploadPackages = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_ConsoleWindow = new System.Windows.Forms.TextBox();
            this.button_deleteSelectPackages = new System.Windows.Forms.Button();
            this.button_UpdateNuGetList = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopMenu_ServerSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TopMenu_ServerSettings
            // 
            this.TopMenu_ServerSettings.Name = "TopMenu_ServerSettings";
            this.TopMenu_ServerSettings.Size = new System.Drawing.Size(115, 21);
            this.TopMenu_ServerSettings.Text = "NuGet服务器设置";
            this.TopMenu_ServerSettings.Click += new System.EventHandler(this.TopMenu_ServerSettings_Click);
            // 
            // listView_NuGetPackages
            // 
            this.listView_NuGetPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_NuGetPackages.Location = new System.Drawing.Point(12, 31);
            this.listView_NuGetPackages.Name = "listView_NuGetPackages";
            this.listView_NuGetPackages.Size = new System.Drawing.Size(439, 438);
            this.listView_NuGetPackages.TabIndex = 1;
            this.listView_NuGetPackages.UseCompatibleStateImageBehavior = false;
            this.listView_NuGetPackages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "包名";
            this.columnHeader1.Width = 361;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "包版本";
            // 
            // button_UploadPackages
            // 
            this.button_UploadPackages.Location = new System.Drawing.Point(457, 31);
            this.button_UploadPackages.Name = "button_UploadPackages";
            this.button_UploadPackages.Size = new System.Drawing.Size(144, 51);
            this.button_UploadPackages.TabIndex = 2;
            this.button_UploadPackages.Text = "上传 NuGet 包";
            this.button_UploadPackages.UseVisualStyleBackColor = true;
            this.button_UploadPackages.Click += new System.EventHandler(this.button_UploadPackages_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "替换选中的 NuGet 包";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox_ConsoleWindow
            // 
            this.textBox_ConsoleWindow.BackColor = System.Drawing.Color.Black;
            this.textBox_ConsoleWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_ConsoleWindow.Location = new System.Drawing.Point(12, 475);
            this.textBox_ConsoleWindow.Multiline = true;
            this.textBox_ConsoleWindow.Name = "textBox_ConsoleWindow";
            this.textBox_ConsoleWindow.ReadOnly = true;
            this.textBox_ConsoleWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ConsoleWindow.Size = new System.Drawing.Size(584, 189);
            this.textBox_ConsoleWindow.TabIndex = 3;
            // 
            // button_deleteSelectPackages
            // 
            this.button_deleteSelectPackages.Location = new System.Drawing.Point(457, 147);
            this.button_deleteSelectPackages.Name = "button_deleteSelectPackages";
            this.button_deleteSelectPackages.Size = new System.Drawing.Size(144, 51);
            this.button_deleteSelectPackages.TabIndex = 2;
            this.button_deleteSelectPackages.Text = "删除选中的包";
            this.button_deleteSelectPackages.UseVisualStyleBackColor = true;
            this.button_deleteSelectPackages.Click += new System.EventHandler(this.button_deleteSelectPackages_Click);
            // 
            // button_UpdateNuGetList
            // 
            this.button_UpdateNuGetList.Location = new System.Drawing.Point(457, 204);
            this.button_UpdateNuGetList.Name = "button_UpdateNuGetList";
            this.button_UpdateNuGetList.Size = new System.Drawing.Size(144, 51);
            this.button_UpdateNuGetList.TabIndex = 2;
            this.button_UpdateNuGetList.Text = "刷新列表";
            this.button_UpdateNuGetList.UseVisualStyleBackColor = true;
            this.button_UpdateNuGetList.Click += new System.EventHandler(this.button_UpdateNuGetList_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 670);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(584, 27);
            this.progressBar1.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 713);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox_ConsoleWindow);
            this.Controls.Add(this.button_UpdateNuGetList);
            this.Controls.Add(this.button_deleteSelectPackages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_UploadPackages);
            this.Controls.Add(this.listView_NuGetPackages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuGet 包简易管理工具";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TopMenu_ServerSettings;
        private System.Windows.Forms.ListView listView_NuGetPackages;
        private System.Windows.Forms.Button button_UploadPackages;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_ConsoleWindow;
        private System.Windows.Forms.Button button_deleteSelectPackages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_UpdateNuGetList;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}