using InstallationFiles.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InstallationFiles.Managers
{
    public class DropboxSettingsManager
    {
        private const string FileName = "InstallationFilesConfiguration.xml";

        private string _filePath;

        private XDocument _xmlDocument;

        public DropboxSettingsManager()
        {
            _filePath = GetConfigurationFilePath();

            if (!File.Exists(_filePath))
            {
                _xmlDocument = new XDocument();
                CreateDefaultConfigurationFile();
            }
            else
            {
                _xmlDocument = XDocument.Load(_filePath);
            }
        }

        /// <summary>
        /// Get the full path to the configuration file.
        /// </summary>
        /// <returns></returns>
        private string GetConfigurationFilePath()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string configurationFileDirectory = Path.Combine(localAppData, "InstallationFiles");

            if (!Directory.Exists(configurationFileDirectory)) Directory.CreateDirectory(configurationFileDirectory);

            return Path.Combine(configurationFileDirectory, FileName);
        }

        /// <summary>
        /// Create the default XML-file with the default values for each configuration element.
        /// </summary>
        private void CreateDefaultConfigurationFile()
        {
            XElement xml = new XElement("Settings",
                CreateSettingElement(new DropboxSettingsModel()));

            _xmlDocument.Add(xml);
            _xmlDocument.Save(_filePath);
        }

        /// <summary>
        /// Create the XML-element that contains the needed values for the configuration.
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        private XElement CreateSettingElement(DropboxSettingsModel settings)
        {
            return new XElement("Setting",
                new XElement(nameof(DropboxSettingsModel.AccessToken), settings.AccessToken));
        }

        /// <summary>
        /// Read the Dropbox-settings.
        /// </summary>
        /// <returns></returns>
        public DropboxSettingsModel ReadDropboxSettings()
        {
            var elements = from xml in _xmlDocument.Descendants("Setting")
                           select new DropboxSettingsModel
                           {
                               AccessToken = xml.Element(nameof(DropboxSettingsModel.AccessToken)).Value
                           };

            if (!elements.Any()) return new DropboxSettingsModel();

            return elements.FirstOrDefault();
        }

        /// <summary>
        /// Opens the local configuration file.
        /// </summary>
        public void OpenConfigurationFile()
        {
            Process.Start(_filePath);
        }
    }
}
