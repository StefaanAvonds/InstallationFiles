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
    public partial class AddVersion : Form
    {
        private string _versionName;

        /// <summary>
        /// The given version name.
        /// </summary>
        public String VersionName => _versionName;

        public AddVersion()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtVersionName.Text))
            {
                MessageBox.Show("Enter a version name!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _versionName = txtVersionName.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _versionName = String.Empty;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
