using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallationFiles.Models
{
    public class DropboxSettingsModel
    {
        public String AccessToken { get; set; }

        public DropboxSettingsModel()
        {
            AccessToken = String.Empty;
        }
    }
}
