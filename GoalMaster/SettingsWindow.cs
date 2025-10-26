using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoalMaster
{
    public partial class SettingsWindow : Form
    {
        Color initialTextBoxColour;

        private Dictionary<string, string> exportPaths = new Dictionary<string, string>();
        private string keyCMDPath = "keyCMDPath";
        private string keyFMRootPath = "keyFMRoot";
        private string keyLanguage = "keyLanguage";
        private string _defOpenSavePath;
        private string _cmdPath;
        private string _fmRoot;
        private string _language;

        public SettingsWindow(string defOpenSavePath, string cmdFilePath, string fmRootPath, string languageName)
        {
            InitializeComponent();
            _defOpenSavePath = defOpenSavePath;
            _cmdPath = cmdFilePath;
            _fmRoot = fmRootPath;
            _language = languageName;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            lblOpenSaveNotExistWarning.Text = "";
            lblCMDNotExistWarning.Text = "";
            lblFMRootNotExistWarning.Text = "";
            initialTextBoxColour = tbCMDPath.BackColor; //example of colour before Dir existence has been checked.
            tbOpenSavePath.Text = _defOpenSavePath;
            tbCMDPath.Text = _cmdPath;
            tbFMRootPath .Text = _fmRoot;
            tbLanguage .Text = _language;
            folderExistenceCheck(tbOpenSavePath, lblOpenSaveNotExistWarning, "Folder does not exist. Optional field, but you will have more fun if you choose a valid folder.");
            folderExistenceCheck(tbCMDPath, lblCMDNotExistWarning);
            folderExistenceCheck(tbFMRootPath, lblFMRootNotExistWarning);
        }

        public string DefaultOpenSavePath
        {
            get
            {
                return tbOpenSavePath.Text;
            }
        }

        public string CMDPath
        {
            get
            {
                return tbCMDPath.Text;
            }
        }

        public string FMRoot
        {
            get
            {
                return tbFMRootPath.Text;
            }
        }

        public string Language
        {
            get
            {
                return tbLanguage.Text;
            }
        }
        private void btnBrowseSaveLoadLocation_Click(object sender, EventArgs e)
        {
            updateTextBox(tbOpenSavePath);
        }

        private void btnBrowseCMDLocation_Click(object sender, EventArgs e)
        {
            updateTextBox(tbCMDPath);
        }

        private void btnBrowseStrLocation_Click(object sender, EventArgs e)
        {
            updateTextBox(tbFMRootPath);
        }

        private void updateTextBox(TextBox tbToUpdate)
        {
            folderBrowserDialog1.SelectedPath = tbToUpdate.Text;
            DialogResult dR = folderBrowserDialog1.ShowDialog();
            if (dR == DialogResult.OK)
            {
                tbToUpdate.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void tbSaveLoadPath_TextChanged(object sender, EventArgs e)
        {
            folderExistenceCheck(tbOpenSavePath, lblOpenSaveNotExistWarning);
        }
        
        private void tbCMDPath_TextChanged(object sender, EventArgs e)
        {
            folderExistenceCheck(tbCMDPath, lblCMDNotExistWarning);
        }

        private void tbFMRootPath_TextChanged(object sender, EventArgs e)
        {
            folderExistenceCheck(tbFMRootPath, lblFMRootNotExistWarning);
        }

        private void folderExistenceCheck(TextBox tbToUpdate, Label warningLabel, string altText = "")
        {
            if (Directory.Exists(tbToUpdate.Text))
            {
                tbToUpdate.BackColor = initialTextBoxColour;
                warningLabel.Text = "";
            }
            else
            {
                tbToUpdate.BackColor = Color.LightPink;
                if (altText == "")
                    warningLabel.Text = "Folder does not exist. GoalMaster will **try** to create it during the export process. Double check that the above is a valid path.";
                else
                    warningLabel.Text = altText;
            }
            warningLabel.Refresh();
        }
        
        internal static string getTestString()
        {
            return "test string";
        }
    }
}
