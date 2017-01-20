using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallationFiles.Models
{
    public class ApplicationModel
    {
        public String Name { get; set; }
        public String Path { get; set; }

        public ApplicationModel()
        {
            Name = String.Empty;
            Path = String.Empty;
        }
        
        public ApplicationModel(string name, string path)
            : this()
        {
            Name = name;
            Path = path;
        }
    }
}
