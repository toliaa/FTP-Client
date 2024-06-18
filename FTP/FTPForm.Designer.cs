namespace FTPClient
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxRemotePath;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreateDir;
        private System.Windows.Forms.Button buttonDeleteDir;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonListFiles;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderModified;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRemotePath;
        private System.Windows.Forms.Button buttonAppe;
        private System.Windows.Forms.Button buttonMdt;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.Button buttonNlist;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonStou;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxRemotePath = new System.Windows.Forms.TextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreateDir = new System.Windows.Forms.Button();
            this.buttonDeleteDir = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonListFiles = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelHost = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRemotePath = new System.Windows.Forms.Label();
            this.buttonAppe = new System.Windows.Forms.Button();
            this.buttonMdt = new System.Windows.Forms.Button();
            this.buttonSize = new System.Windows.Forms.Button();
            this.buttonNlist = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonStou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(100, 15);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(200, 20);
            this.textBoxHost.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(100, 45);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(100, 75);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(320, 15);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 80);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxRemotePath
            // 
            this.textBoxRemotePath.Location = new System.Drawing.Point(100, 105);
            this.textBoxRemotePath.Name = "textBoxRemotePath";
            this.textBoxRemotePath.Size = new System.Drawing.Size(320, 20);
            this.textBoxRemotePath.TabIndex = 4;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(15, 140);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 5;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(100, 140);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 6;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(185, 140);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreateDir
            // 
            this.buttonCreateDir.Location = new System.Drawing.Point(270, 140);
            this.buttonCreateDir.Name = "buttonCreateDir";
            this.buttonCreateDir.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateDir.TabIndex = 8;
            this.buttonCreateDir.Text = "Create Dir";
            this.buttonCreateDir.UseVisualStyleBackColor = true;
            this.buttonCreateDir.Click += new System.EventHandler(this.buttonCreateDir_Click);
            // 
            // buttonDeleteDir
            // 
            this.buttonDeleteDir.Location = new System.Drawing.Point(355, 140);
            this.buttonDeleteDir.Name = "buttonDeleteDir";
            this.buttonDeleteDir.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDir.TabIndex = 9;
            this.buttonDeleteDir.Text = "Delete Dir";
            this.buttonDeleteDir.UseVisualStyleBackColor = true;
            this.buttonDeleteDir.Click += new System.EventHandler(this.buttonDeleteDir_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(440, 140);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 23);
            this.buttonRename.TabIndex = 10;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonListFiles
            // 
            this.buttonListFiles.Location = new System.Drawing.Point(525, 140);
            this.buttonListFiles.Name = "buttonListFiles";
            this.buttonListFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonListFiles.TabIndex = 11;
            this.buttonListFiles.Text = "List Files";
            this.buttonListFiles.UseVisualStyleBackColor = true;
            this.buttonListFiles.Click += new System.EventHandler(this.buttonListFiles_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderModified});
            this.listView.Location = new System.Drawing.Point(15, 175);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(585, 200);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 100;
            // 
            // columnHeaderModified
            // 
            this.columnHeaderModified.Text = "Modified";
            this.columnHeaderModified.Width = 200;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(15, 18);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(29, 13);
            this.labelHost.TabIndex = 13;
            this.labelHost.Text = "Host";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(15, 48);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(15, 78);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password";
            // 
            // labelRemotePath
            // 
            this.labelRemotePath.AutoSize = true;
            this.labelRemotePath.Location = new System.Drawing.Point(15, 108);
            this.labelRemotePath.Name = "labelRemotePath";
            this.labelRemotePath.Size = new System.Drawing.Size(69, 13);
            this.labelRemotePath.TabIndex = 16;
            this.labelRemotePath.Text = "Remote Path";
            // 
            // buttonAppe
            // 
            this.buttonAppe.Location = new System.Drawing.Point(15, 380);
            this.buttonAppe.Name = "buttonAppe";
            this.buttonAppe.Size = new System.Drawing.Size(75, 23);
            this.buttonAppe.TabIndex = 17;
            this.buttonAppe.Text = "APPE";
            this.buttonAppe.UseVisualStyleBackColor = true;
            this.buttonAppe.Click += new System.EventHandler(this.buttonAppe_Click);
            // 
            // buttonMdt
            // 
            this.buttonMdt.Location = new System.Drawing.Point(100, 380);
            this.buttonMdt.Name = "buttonMdt";
            this.buttonMdt.Size = new System.Drawing.Size(75, 23);
            this.buttonMdt.TabIndex = 18;
            this.buttonMdt.Text = "MDT";
            this.buttonMdt.UseVisualStyleBackColor = true;
            this.buttonMdt.Click += new System.EventHandler(this.buttonMdt_Click);
            // 
            // buttonSize
            // 
            this.buttonSize.Location = new System.Drawing.Point(185, 380);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(75, 23);
            this.buttonSize.TabIndex = 19;
            this.buttonSize.Text = "SIZE";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // buttonNlist
            // 
            this.buttonNlist.Location = new System.Drawing.Point(270, 380);
            this.buttonNlist.Name = "buttonNlist";
            this.buttonNlist.Size = new System.Drawing.Size(75, 23);
            this.buttonNlist.TabIndex = 20;
            this.buttonNlist.Text = "NLIST";
            this.buttonNlist.UseVisualStyleBackColor = true;
            this.buttonNlist.Click += new System.EventHandler(this.buttonNlist_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(355, 380);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 21;
            this.buttonList.Text = "LIST";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonStou
            // 
            this.buttonStou.Location = new System.Drawing.Point(440, 380);
            this.buttonStou.Name = "buttonStou";
            this.buttonStou.Size = new System.Drawing.Size(75, 23);
            this.buttonStou.TabIndex = 22;
            this.buttonStou.Text = "STOU";
            this.buttonStou.UseVisualStyleBackColor = true;
            this.buttonStou.Click += new System.EventHandler(this.buttonStou_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.buttonStou);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonNlist);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.buttonMdt);
            this.Controls.Add(this.buttonAppe);
            this.Controls.Add(this.labelRemotePath);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonListFiles);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonDeleteDir);
            this.Controls.Add(this.buttonCreateDir);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textBoxRemotePath);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxHost);
            this.Name = "MainForm";
            this.Text = "FTP Client";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
