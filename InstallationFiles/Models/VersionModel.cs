using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallationFiles.Models
{
    public class VersionModel
    {
        public String Name { get; set; }
        public String Path { get; set; }

        public VersionModel()
        {
            Name = String.Empty;
            Path = String.Empty;
        }

        public VersionModel(string name, string path)
            : this()
        {
            Name = name;
            Path = path;
        }
    }
}
