using Dropbox.Api;
using InstallationFiles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallationFiles.Pages
{
    public partial class InstallFiles : Form
    {
        private ApplicationModel _selectedApplication;
        private VersionModel _selectedVersion;

        public InstallFiles()
        {
            InitializeComponent();
        }

        private void InstallFiles_Load(object sender, EventArgs e)
        {
            if (!App.DropboxManager.IsDropboxSettingValid())
            {
                App.DropboxManager.OpenSettingsFile();
                MessageBox.Show("The Access Token to communicate with Dropbox is not valid! Please enter a valid Access Token!", "Invalid Access Token", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ReloadApplications();
        }

        /// <summary>
        /// Reload the grid with all the applications.
        /// </summary>
        private async void ReloadApplications()
        {
            var applications = await App.DropboxManager.GetAllApplications();
            gridApplications.DataSource = applications;
        }

        /// <summary>
        /// Reload the grid with all the versions for a specific application.
        /// </summary>
        private async void ReloadVersions()
        {
            var versions = await App.DropboxManager.GetAllVersions(_selectedApplication);
            gridVersions.DataSource = versions;
        }

        /// <summary>
        /// Reload the grid with all the installation-files for a specific version.
        /// </summary>
        private async void ReloadInstallationFiles()
        {
            var files = await App.DropboxManager.GetAllInstallFiles(_selectedVersion);
            gridFiles.DataSource = files;
        }

        /// <summary>
        /// Download the installation-file.
        /// </summary>
        /// <param name="file">The installation-file that needs to be downloaded.</param>
        private async void DownloadInstallationFile(FileModel file)
        {
            if (MessageBox.Show("Do you want to download file '" + file.Name + "'?", "Download file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            
            SetEnabledButtons(false);
            var downloaded = await App.DropboxManager.DownloadInstallFile(file);
            SetEnabledButtons(true);

            if (downloaded)
            {
                MessageBox.Show("File has been downloaded!", "Download succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error upon downloading file!", "Download failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add a new application.
        /// </summary>
        private async void AddNewApplication()
        {
            var newApplication = new AddApplication();
            var result = newApplication.ShowDialog();

            if (result != DialogResult.OK) return;
            
            SetEnabledButtons(false);
            await App.DropboxManager.AddNewApplication(newApplication.ApplicationName);
            SetEnabledButtons(true);

            ReloadApplications();
        }

        /// <summary>
        /// Add a new version.
        /// </summary>
        private async void AddNewVersion()
        {
            var newVersion = new AddVersion();
            var result = newVersion.ShowDialog();

            if (result != DialogResult.OK) return;
            
            SetEnabledButtons(false);
            await App.DropboxManager.AddNewVersion(newVersion.VersionName, _selectedApplication.Path);
            SetEnabledButtons(true);

            ReloadVersions();
        }

        /// <summary>
        /// Add a new installation-file.
        /// </summary>
        private async void AddNewInstallationFile()
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK) return;
            
            SetEnabledButtons(false);
            await App.DropboxManager.AddNewInstallationFile(_selectedVersion.Path + "/" + dialog.SafeFileName, dialog.FileName);
            SetEnabledButtons(true);

            ReloadInstallationFiles();
        }

        /// <summary>
        /// Set the Enabled-Property of the buttons.
        /// </summary>
        /// <param name="enable"></param>
        private void SetEnabledButtons(bool enable)
        {
            btnNewApplication.Enabled = enable;
            btnNewVersion.Enabled = enable;
            btnUploadFile.Enabled = enable;

            gridApplications.Enabled = enable;
            gridVersions.Enabled = enable;
            gridFiles.Enabled = enable;

            if (enable)
            {
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
            }
        }

        private void gridApplications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedApplication = null;
            if (gridApplications.DataSource == null) return;

            _selectedApplication = (gridApplications.DataSource as List<ApplicationModel>)[e.RowIndex];

            if (_selectedApplication != null) ReloadVersions();
        }

        private void gridVersions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedVersion = null;
            if (gridVersions.DataSource == null) return;

            _selectedVersion = (gridVersions.DataSource as List<VersionModel>)[e.RowIndex];

            if (_selectedVersion != null) ReloadInstallationFiles();
        }

        private void gridFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFiles.DataSource == null) return;

            var selectedFile = (gridFiles.DataSource as List<FileModel>)[e.RowIndex];

            if (selectedFile != null) DownloadInstallationFile(selectedFile);
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            AddNewApplication();
        }

        private void btnNewVersion_Click(object sender, EventArgs e)
        {
            if (gridVersions.DataSource == null) return;
            AddNewVersion();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (gridVersions.DataSource == null) return;
            AddNewInstallationFile();
        }
    }
}
