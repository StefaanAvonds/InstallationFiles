namespace InstallationFiles.Pages
{
    partial class InstallFiles
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
            this.panelDirectories = new System.Windows.Forms.Panel();
            this.panelVersions = new System.Windows.Forms.Panel();
            this.panelVersionToolbar = new System.Windows.Forms.Panel();
            this.btnNewVersion = new System.Windows.Forms.Button();
            this.gridVersions = new System.Windows.Forms.DataGridView();
            this.splitterApplicationsVersions = new System.Windows.Forms.Splitter();
            this.panelApplications = new System.Windows.Forms.Panel();
            this.panelApplicationsToolbar = new System.Windows.Forms.Panel();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.gridApplications = new System.Windows.Forms.DataGridView();
            this.splitterDirectoryFile = new System.Windows.Forms.Splitter();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.panelFilesToolbar = new System.Windows.Forms.Panel();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.gridFiles = new System.Windows.Forms.DataGridView();
            this.panelDirectories.SuspendLayout();
            this.panelVersions.SuspendLayout();
            this.panelVersionToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVersions)).BeginInit();
            this.panelApplications.SuspendLayout();
            this.panelApplicationsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridApplications)).BeginInit();
            this.panelFiles.SuspendLayout();
            this.panelFilesToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDirectories
            // 
            this.panelDirectories.Controls.Add(this.panelVersions);
            this.panelDirectories.Controls.Add(this.splitterApplicationsVersions);
            this.panelDirectories.Controls.Add(this.panelApplications);
            this.panelDirectories.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectories.Location = new System.Drawing.Point(0, 0);
            this.panelDirectories.Name = "panelDirectories";
            this.panelDirectories.Size = new System.Drawing.Size(1304, 304);
            this.panelDirectories.TabIndex = 0;
            // 
            // panelVersions
            // 
            this.panelVersions.Controls.Add(this.panelVersionToolbar);
            this.panelVersions.Controls.Add(this.gridVersions);
            this.panelVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVersions.Location = new System.Drawing.Point(638, 0);
            this.panelVersions.MinimumSize = new System.Drawing.Size(666, 304);
            this.panelVersions.Name = "panelVersions";
            this.panelVersions.Size = new System.Drawing.Size(666, 304);
            this.panelVersions.TabIndex = 2;
            // 
            // panelVersionToolbar
            // 
            this.panelVersionToolbar.Controls.Add(this.btnNewVersion);
            this.panelVersionToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVersionToolbar.Location = new System.Drawing.Point(0, 249);
            this.panelVersionToolbar.Name = "panelVersionToolbar";
            this.panelVersionToolbar.Size = new System.Drawing.Size(666, 55);
            this.panelVersionToolbar.TabIndex = 2;
            // 
            // btnNewVersion
            // 
            this.btnNewVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewVersion.Location = new System.Drawing.Point(542, 3);
            this.btnNewVersion.Name = "btnNewVersion";
            this.btnNewVersion.Size = new System.Drawing.Size(121, 55);
            this.btnNewVersion.TabIndex = 0;
            this.btnNewVersion.Text = "New version";
            this.btnNewVersion.UseVisualStyleBackColor = true;
            this.btnNewVersion.Click += new System.EventHandler(this.btnNewVersion_Click);
            // 
            // gridVersions
            // 
            this.gridVersions.AllowUserToAddRows = false;
            this.gridVersions.AllowUserToDeleteRows = false;
            this.gridVersions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVersions.Location = new System.Drawing.Point(0, 0);
            this.gridVersions.Name = "gridVersions";
            this.gridVersions.ReadOnly = true;
            this.gridVersions.RowTemplate.Height = 24;
            this.gridVersions.Size = new System.Drawing.Size(666, 304);
            this.gridVersions.TabIndex = 0;
            this.gridVersions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVersions_CellDoubleClick);
            // 
            // splitterApplicationsVersions
            // 
            this.splitterApplicationsVersions.Location = new System.Drawing.Point(635, 0);
            this.splitterApplicationsVersions.Name = "splitterApplicationsVersions";
            this.splitterApplicationsVersions.Size = new System.Drawing.Size(3, 304);
            this.splitterApplicationsVersions.TabIndex = 1;
            this.splitterApplicationsVersions.TabStop = false;
            // 
            // panelApplications
            // 
            this.panelApplications.Controls.Add(this.panelApplicationsToolbar);
            this.panelApplications.Controls.Add(this.gridApplications);
            this.panelApplications.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelApplications.Location = new System.Drawing.Point(0, 0);
            this.panelApplications.MinimumSize = new System.Drawing.Size(635, 304);
            this.panelApplications.Name = "panelApplications";
            this.panelApplications.Size = new System.Drawing.Size(635, 304);
            this.panelApplications.TabIndex = 0;
            // 
            // panelApplicationsToolbar
            // 
            this.panelApplicationsToolbar.Controls.Add(this.btnNewApplication);
            this.panelApplicationsToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelApplicationsToolbar.Location = new System.Drawing.Point(0, 249);
            this.panelApplicationsToolbar.Name = "panelApplicationsToolbar";
            this.panelApplicationsToolbar.Size = new System.Drawing.Size(635, 55);
            this.panelApplicationsToolbar.TabIndex = 1;
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewApplication.Location = new System.Drawing.Point(514, 0);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(121, 55);
            this.btnNewApplication.TabIndex = 0;
            this.btnNewApplication.Text = "New application";
            this.btnNewApplication.UseVisualStyleBackColor = true;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // gridApplications
            // 
            this.gridApplications.AllowUserToAddRows = false;
            this.gridApplications.AllowUserToDeleteRows = false;
            this.gridApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridApplications.Location = new System.Drawing.Point(0, 0);
            this.gridApplications.Name = "gridApplications";
            this.gridApplications.ReadOnly = true;
            this.gridApplications.RowTemplate.Height = 24;
            this.gridApplications.Size = new System.Drawing.Size(635, 304);
            this.gridApplications.TabIndex = 0;
            this.gridApplications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridApplications_CellDoubleClick);
            // 
            // splitterDirectoryFile
            // 
            this.splitterDirectoryFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterDirectoryFile.Location = new System.Drawing.Point(0, 304);
            this.splitterDirectoryFile.Name = "splitterDirectoryFile";
            this.splitterDirectoryFile.Size = new System.Drawing.Size(1304, 3);
            this.splitterDirectoryFile.TabIndex = 1;
            this.splitterDirectoryFile.TabStop = false;
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.panelFilesToolbar);
            this.panelFiles.Controls.Add(this.gridFiles);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(0, 307);
            this.panelFiles.MinimumSize = new System.Drawing.Size(1304, 264);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(1304, 264);
            this.panelFiles.TabIndex = 2;
            // 
            // panelFilesToolbar
            // 
            this.panelFilesToolbar.Controls.Add(this.btnUploadFile);
            this.panelFilesToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFilesToolbar.Location = new System.Drawing.Point(0, 209);
            this.panelFilesToolbar.Name = "panelFilesToolbar";
            this.panelFilesToolbar.Size = new System.Drawing.Size(1304, 55);
            this.panelFilesToolbar.TabIndex = 1;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadFile.Location = new System.Drawing.Point(1180, 3);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(121, 55);
            this.btnUploadFile.TabIndex = 1;
            this.btnUploadFile.Text = "New installation";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // gridFiles
            // 
            this.gridFiles.AllowUserToAddRows = false;
            this.gridFiles.AllowUserToDeleteRows = false;
            this.gridFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFiles.Location = new System.Drawing.Point(0, 0);
            this.gridFiles.Name = "gridFiles";
            this.gridFiles.ReadOnly = true;
            this.gridFiles.RowTemplate.Height = 24;
            this.gridFiles.Size = new System.Drawing.Size(1304, 264);
            this.gridFiles.TabIndex = 0;
            this.gridFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFiles_CellDoubleClick);
            // 
            // InstallFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 571);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.splitterDirectoryFile);
            this.Controls.Add(this.panelDirectories);
            this.MinimumSize = new System.Drawing.Size(1322, 618);
            this.Name = "InstallFiles";
            this.Text = "Installations";
            this.Load += new System.EventHandler(this.InstallFiles_Load);
            this.panelDirectories.ResumeLayout(false);
            this.panelVersions.ResumeLayout(false);
            this.panelVersionToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVersions)).EndInit();
            this.panelApplications.ResumeLayout(false);
            this.panelApplicationsToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridApplications)).EndInit();
            this.panelFiles.ResumeLayout(false);
            this.panelFilesToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDirectories;
        private System.Windows.Forms.Panel panelVersions;
        private System.Windows.Forms.DataGridView gridVersions;
        private System.Windows.Forms.Splitter splitterApplicationsVersions;
        private System.Windows.Forms.Panel panelApplications;
        private System.Windows.Forms.DataGridView gridApplications;
        private System.Windows.Forms.Splitter splitterDirectoryFile;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.DataGridView gridFiles;
        private System.Windows.Forms.Panel panelApplicationsToolbar;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.Panel panelVersionToolbar;
        private System.Windows.Forms.Button btnNewVersion;
        private System.Windows.Forms.Panel panelFilesToolbar;
        private System.Windows.Forms.Button btnUploadFile;
    }
}

