using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchBrake.Models
{
    public class Settings
    {
        public string SupportedExtensions { get; set; }
        public string FormatToConvertTo { get; set; }
        public bool IsFirstRun { get; set; }
        public bool ShouldDeleteAfterConversion { get; set; }
        public bool ShouldCompareVideoLengths { get; set; }
        public bool CliPathSetAutomatically { get; set; }
        public bool ShouldUseVerboseMode { get; set; }
        public bool ShouldHideWindow { get; set; }
        public string CliExecutablePath { get; set; }
        public string RootFolderPath { get; set; }
        public string Arguments { get; set; }
        public string CurrentWorkingPath { get; set; }
        private string SettingsFileName { get; set; }

        private const string X86Path = @"C:\Program Files (x86)\Handbrake\HandBrakeCLI.exe";
        private const string X64Path = @"C:\Program Files\Handbrake\HandBrakeCLI.exe";

        public Settings()
        {
            // Set up some defaults and initialise
            FormatToConvertTo =  "mkv";         
            CliPathSetAutomatically = false;
            ShouldDeleteAfterConversion = false;
            ShouldCompareVideoLengths = true;
            RootFolderPath = @"C:\Introduction to Android Development";
            CurrentWorkingPath = Directory.GetCurrentDirectory();
            // Check to see if the Cli Executable path can be set automatically on Settings creation
            CheckForAutomaticCliPath();

        }

        public void SetRootFolderPath(string rootFolder)
        {
            RootFolderPath = rootFolder;
        }

        private void CheckForAutomaticCliPath()
        {
            
            if (File.Exists(X86Path))
            {
                CliExecutablePath = X86Path;
                CliPathSetAutomatically = true;
            }

            if (File.Exists(X64Path))
            {
                CliExecutablePath = X64Path;
                CliPathSetAutomatically = true;
            }
        }

        public void AddFormat(Format format)
        {
            //Formats.Add(format);
        }

        private bool CheckIfFirstRun()
        {
            if (IsFirstRun)
            {
                // Create settings
            }

            return IsFirstRun;
        }
    }
}
