using InstallationFiles.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallationFiles
{
    public static class App
    {
        private static DropboxManager _dropboxManager;

        /// <summary>
        /// The manager to contact the Dropbox-folders and -files.
        /// </summary>
        public static DropboxManager DropboxManager
        {
            get
            {
                if (_dropboxManager == null) _dropboxManager = new DropboxManager();
                return _dropboxManager;
            }
        }
    }
}
