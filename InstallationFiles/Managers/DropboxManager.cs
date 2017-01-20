using Dropbox.Api;
using Dropbox.Api.Files;
using InstallationFiles.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallationFiles.Managers
{
    public class DropboxManager
    {
        private string _accessToken;
        private DropboxSettingsManager _settingsManager;

        public DropboxManager()
        {
            _settingsManager = new DropboxSettingsManager();
        }

        /// <summary>
        /// Checks if the Configuration-file has a valid Dropbox-setting.
        /// </summary>
        /// <returns></returns>
        public Boolean IsDropboxSettingValid()
        {
            var setting = _settingsManager.ReadDropboxSettings();

            if (setting == null || String.IsNullOrWhiteSpace(setting.AccessToken)) return false;
            _accessToken = setting.AccessToken;

            return true;
        }

        /// <summary>
        /// Opens the settings-file.
        /// </summary>
        public void OpenSettingsFile()
        {
            _settingsManager.OpenConfigurationFile();
        }

        /// <summary>
        /// Get all the applications for the Dropbox.
        /// </summary>
        /// <returns>The applications in the Dropbox-account.</returns>
        public async Task<IEnumerable<ApplicationModel>> GetAllApplications()
        {
            using (var dropbox = new DropboxClient(_accessToken))
            {
                var list = await dropbox.Files.ListFolderAsync(String.Empty);

                var applications = new List<ApplicationModel>();
                foreach (var item in list.Entries.Where(x => x.IsFolder))
                {
                    applications.Add(new ApplicationModel(item.Name, item.PathLower));
                }
                return applications;
            }
        }

        /// <summary>
        /// Get all version for a specific application for Dropbox.
        /// </summary>
        /// <param name="application">The application that is selected.</param>
        /// <returns>The versions for the selected application.</returns>
        public async Task<IEnumerable<VersionModel>> GetAllVersions(ApplicationModel application)
        {
            using (var dropbox = new DropboxClient(_accessToken))
            {
                var list = await dropbox.Files.ListFolderAsync(application.Path);

                var versions = new List<VersionModel>();
                foreach (var item in list.Entries.Where(x => x.IsFolder))
                {
                    versions.Add(new VersionModel(item.Name, item.PathLower));
                }
                return versions;
            }
        }

        /// <summary>
        /// Get all installation-files of a specific version for one application.
        /// </summary>
        /// <param name="version">The version to get the installation-files from.</param>
        /// <returns>The installation-files for the selected version.</returns>
        public async Task<IEnumerable<FileModel>> GetAllInstallFiles(VersionModel version)
        {
            using (var dropbox = new DropboxClient(_accessToken))
            {
                var list = await dropbox.Files.ListFolderAsync(version.Path);

                var files = new List<FileModel>();
                foreach (var item in list.Entries.Where(x => x.IsFile))
                {
                    files.Add(new FileModel(item.Name, item.PathLower));
                }
                return files;
            }
        }

        /// <summary>
        /// Download an installation-file.
        /// </summary>
        /// <param name="file">The installation-file to download.</param>
        /// <returns>TRUE = file downloaded | FALSE = error</returns>
        public async Task<bool> DownloadInstallFile(FileModel file)
        {
            try
            {
                using (var dropbox = new DropboxClient(_accessToken))
                {
                    using (var response = await dropbox.Files.DownloadAsync(file.Path))
                    {
                        var bytes = await response.GetContentAsByteArrayAsync();

                        var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.None);
                        System.IO.File.WriteAllBytes(path + "\\" + file.Name, bytes);
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Add a new application to Dropbox.
        /// </summary>
        /// <param name="applicationName"></param>
        /// <returns></returns>
        public async Task AddNewApplication(string applicationName)
        {
            using (var dropbox = new DropboxClient(_accessToken))
            {
                await dropbox.Files.CreateFolderAsync("/" + applicationName);
            }
        }

        /// <summary>
        /// Add a new version to Dropbox.
        /// </summary>
        /// <param name="versionName"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public async Task AddNewVersion(string versionName, string path)
        {
            using (var dropbox = new DropboxClient(_accessToken))
            {
                await dropbox.Files.CreateFolderAsync(path + "/" + versionName);
            }
        }

        /// <summary>
        /// Add a new installation-file to Dropbox.
        /// </summary>
        /// <param name="installationFileName"></param>
        /// <param name="localFilePath"></param>
        /// <returns></returns>
        public async Task AddNewInstallationFile(string installationFileName, string localFilePath)
        {
            using (var dropbox = new DropboxClient(_accessToken))
            {
                string content = System.IO.File.ReadAllText(localFilePath);
                using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    var updated = await dropbox.Files.UploadAsync(installationFileName, WriteMode.Overwrite.Instance, body: memoryStream);
                }
            }
        }
    }
}
