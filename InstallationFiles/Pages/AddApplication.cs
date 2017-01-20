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
    public partial class AddApplication : Form
    {
        private string _applicationName;

        /// <summary>
        /// The given application name.
        /// </summary>
        public String ApplicationName => _applicationName;

        public AddApplication()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtApplicationName.Text))
            {
                MessageBox.Show("Enter an application name!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _applicationName = txtApplicationName.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _applicationName = String.Empty;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
