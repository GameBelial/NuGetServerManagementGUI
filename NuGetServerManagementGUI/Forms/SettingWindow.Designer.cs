namespace NuGetServerManagementGUI.Forms
{
    partial class SettingWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ServerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ServerApiKey = new System.Windows.Forms.TextBox();
            this.button_SaveAndApplySettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NuGet 服务器地址:";
            // 
            // textBox_ServerAddress
            // 
            this.textBox_ServerAddress.Location = new System.Drawing.Point(122, 7);
            this.textBox_ServerAddress.Name = "textBox_ServerAddress";
            this.textBox_ServerAddress.Size = new System.Drawing.Size(221, 24);
            this.textBox_ServerAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "NuGet ApiKey:";
            // 
            // textBox_ServerApiKey
            // 
            this.textBox_ServerApiKey.Location = new System.Drawing.Point(122, 45);
            this.textBox_ServerApiKey.Name = "textBox_ServerApiKey";
            this.textBox_ServerApiKey.Size = new System.Drawing.Size(221, 24);
            this.textBox_ServerApiKey.TabIndex = 1;
            // 
            // button_SaveAndApplySettings
            // 
            this.button_SaveAndApplySettings.Location = new System.Drawing.Point(255, 84);
            this.button_SaveAndApplySettings.Name = "button_SaveAndApplySettings";
            this.button_SaveAndApplySettings.Size = new System.Drawing.Size(88, 27);
            this.button_SaveAndApplySettings.TabIndex = 2;
            this.button_SaveAndApplySettings.Text = "保存并应用";
            this.button_SaveAndApplySettings.UseVisualStyleBackColor = true;
            this.button_SaveAndApplySettings.Click += new System.EventHandler(this.button_SaveAndApplySettings_Click);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 125);
            this.Controls.Add(this.button_SaveAndApplySettings);
            this.Controls.Add(this.textBox_ServerApiKey);
            this.Controls.Add(this.textBox_ServerAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuGet 服务器设置";
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ServerAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ServerApiKey;
        private System.Windows.Forms.Button button_SaveAndApplySettings;
    }
}