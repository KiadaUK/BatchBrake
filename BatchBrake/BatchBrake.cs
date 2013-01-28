using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchBrake.Models;

namespace BatchBrake
{
    public partial class BatchBrake : Form
    {
        public TextBox RootFolder { get; set; }
        public Label CurrentFileBeingConverted { get; set; }

        public Settings Settings { get; set; }

        public BatchBrake()
        {
            InitializeComponent();
            Settings = new Settings();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettingsForm();
        }

        private void BatchBrake_Load(object sender, EventArgs e)
        {
            RootFolder = rootTxt;
            CurrentFileBeingConverted = currentFileLbl;
        }

        public void UpdateSettings(Settings settings)
        {
            Settings = settings;
            
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            
            backgroundWorker1.RunWorkerAsync();

        }

        private void OpenSettingsForm()
        {
            var settings = new SettingsForm(this);
            settings.ShowDialog();
        }

        private void browseRootBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings.RootFolderPath = folderBrowserDlg.SelectedPath;
                RootFolder.Text = Settings.RootFolderPath;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var convertor = new Converter(this, Settings, new OutputHandler());
            convertor.StartConversion();
        }
    }
}

/*
 * 1) Open up the BatchBrake form
 * 2) Check if first run, if so open settings - if not load previous settings
 * 3) Wait for Root Folder to be selected and the 'Convert' button to be pressed
 * 4) Load the settings into the Converter and process the videos
 * 
 * Show warning if ffmpeg4 is not installed, will be quicker with it.
 * 
 * 
 * When the convert button is pressed:
 * 
 * 1) Create new Converter
 * 2) Pass in the current Settings object, BatckBrake object and a new OutputHandler
 * 3) Pass in the Root folder
 * 4) Process all of the Settings:
 * 
 * Need to construct the final CLI command, with all selected arguments (StringBuilder?)
 * 
 * 5) Create new thread for process to run on, with delegates for Progress Bar and Output Label.
 * 
 * Need to work out how to do the length comparison. Will probably be some .NET library for retrieving the length of a video file.
 * Delete file after conversion if option is set.
 * 
 * 
 * 1) BatchBrake opens SettingsForm, passing itself into the constructor
 * 2) SettingsForm creates a new Settings object and configures the settings
 * 3) When Apply is clicked, the Settings object is passed back to BatchBrake
*/