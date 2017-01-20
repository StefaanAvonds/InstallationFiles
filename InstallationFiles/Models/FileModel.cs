using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallationFiles.Models
{
    public class FileModel
    {
        public String Name { get; set; }
        public String Path { get; set; }

        public FileModel()
        {
            Name = String.Empty;
            Path = String.Empty;
        }

        public FileModel(string name, string path)
            : this()
        {
            Name = name;
            Path = path;
        }
    }
}
