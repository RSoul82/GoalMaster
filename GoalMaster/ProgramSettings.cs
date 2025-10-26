using System.IO;
using Newtonsoft.Json;

namespace GoalMaster
{
    internal class ProgramSettings
    {
        private string _cmdFilePath;
        private string _fmRootPath;
        private string _languageName;
        private string settingsPath = getConfigFilePath();
        private string oldSettingsFile = "dirs.txt";
        private string _defaultOpenSavePath;
        private static string getConfigFilePath()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase; //Full path of current .exe
            string dirPath = Path.GetDirectoryName(exePath); //Full path of directory of above value, no \\ at end
            string notURI = dirPath.Replace("file:\\", "");
            string fullConfigPath = Path.GetFullPath(Path.Combine(notURI, "settings", "GoalMasterSettings.json"));

            return fullConfigPath;
        }
        public void checkForSettings()
        {
            if (!File.Exists(settingsPath))
            {
                createNewSettinsFile();
            }
            else
                getSettings();
        }
        private void getSettings()
        {
            string settingsText = File.ReadAllText(settingsPath);
            ProgramSettings settings = JsonConvert.DeserializeObject<ProgramSettings>(settingsText);
            _defaultOpenSavePath = settings.DefaultOpenSavePath;
            _cmdFilePath = settings.CmdPath;
            _fmRootPath = settings.FMRoot;
            _languageName = settings.Language;
        }

        /// <summary>
        /// Createa a new format settings file, transfers from old settings file if it exists
        /// </summary>
        private void createNewSettinsFile()
        {
            if (tryGetOldSettings())
            {
                SetSettings(_defaultOpenSavePath, _cmdFilePath, _fmRootPath, _languageName);
                File.Move(oldSettingsFile, oldSettingsFile + ".UselessOldFile");
            }
            else
            {
                string trollText = "SET THIS OR YOU'LL BE A TAFFER FOREVER!";
                SetSettings(trollText, trollText, trollText, "none");
            }
        }

        private bool tryGetOldSettings()
        {
            if (File.Exists(oldSettingsFile))
            {
                string[] fileLines = File.ReadAllLines(oldSettingsFile);
                _cmdFilePath = fileLines[1];
                _fmRootPath = fileLines[4];
                _languageName = fileLines[7];
                return true;
            }
            else return false;
        }

        public void SetSettings(string defaultGMListDir, string cmdFileDir, string fmRoot, string language)
        {
            _defaultOpenSavePath = defaultGMListDir;
            _cmdFilePath = cmdFileDir;
            _fmRootPath = fmRoot;
            _languageName = language;

            string settingsSubDir = Path.GetDirectoryName(settingsPath);

            if (!Directory.Exists(settingsSubDir))
                Directory.CreateDirectory(settingsSubDir);

            string newSettings = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(settingsPath, newSettings);
        }

        public string CmdPath
        {
            get
            {
                return _cmdFilePath;
            }
            set
            {
                _cmdFilePath = value;
            }
        }

        public string FMRoot
        {
            get
            {
                return _fmRootPath;
            }
            set
            {
                _fmRootPath = value;
            }
        }

        public string Language
        {
            get
            {
                return _languageName;
            }
            set
            {
                _languageName = value;
            }
        }

        public string DefaultOpenSavePath
        {
            get
            {
                return _defaultOpenSavePath;
            }
            set
            {
                _defaultOpenSavePath = value;
            }
        }
    }
}
