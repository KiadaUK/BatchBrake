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
    public partial class SettingsForm : Form
    {
        public BatchBrake Batch { get; set; }
        public Settings Settings { get; set; }


        public SettingsForm(BatchBrake batchBrake)
        {
            InitializeComponent();
            Settings = new Settings();
            Batch = batchBrake;
            if (!Settings.ShouldHideWindow)
            {
                verboseChk.Enabled = false;
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
           
            SetAllSettings();
            
            var parser = new SettingsParser();
            // Save settings

            
            Batch.UpdateSettings(Settings);
            Hide();
        }

        private void SetAllSettings()
        {
            Settings.Arguments = argumentsTxt.Text;
            Settings.ShouldCompareVideoLengths = compareChk.Checked;
            Settings.ShouldDeleteAfterConversion = deleteChk.Checked;
            Settings.ShouldHideWindow = showChk.Checked;
            Settings.ShouldUseVerboseMode = verboseChk.Checked;
            AddFormatsToList();
        }

        private void cliExecBtn_Click(object sender, EventArgs e)
        {
            var fileDialog = this.cliExecBrwsr;
            fileDialog.Filter = "Executable Files (.exe)|*.exe";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Settings.CliExecutablePath = fileDialog.InitialDirectory + fileDialog.FileName;
                cliExecTxt.Text = Settings.CliExecutablePath;
                Settings.CliPathSetAutomatically = false;
            }
        }

        private void AddFormatsToList()
        {
            var count = vidFormatGrp.Controls.Count;
            Settings.SupportedExtensions = "";
            foreach (Control control in vidFormatGrp.Controls)
            {
                CheckBox chkBox = control as CheckBox;

                if (chkBox.Checked)
                {
                    Console.WriteLine(chkBox.Text);

                    if (count == 1)
                    {
                        Settings.SupportedExtensions += "*." + chkBox.Text;
                    }
                    else
                    {
                        Settings.SupportedExtensions += "*." + chkBox.Text + ",";
                    }

                    // *.jpg,*.gif,*.png,*.bmp,*.jpe,*.jpeg,*.wmf
                }
                count--;
                Console.WriteLine(Settings.SupportedExtensions);

            }
        }

        private void convertMkvRadio_CheckedChanged(object sender, EventArgs e)
        {
            Settings.FormatToConvertTo = "mkv";
            ToggleCheckBoxEnabledOnConvertToFormatChange(Settings.FormatToConvertTo);
        }

        private void convertMp4Radio_CheckedChanged(object sender, EventArgs e)
        {
            Settings.FormatToConvertTo = "mp4";
            ToggleCheckBoxEnabledOnConvertToFormatChange(Settings.FormatToConvertTo);
        }

        private void ToggleCheckBoxEnabledOnConvertToFormatChange(string chkBoxName)
        {

            if (chkBoxName == "mp4")
            {
                mp4Chk.Enabled = false;
                mp4Chk.Checked = false;
                mkvChk.Enabled = true;
                mkvChk.Checked = true;
            }

            if (chkBoxName == "mkv")
            {
                mkvChk.Enabled = false;
                mkvChk.Checked = false;
                mp4Chk.Enabled = true;
                mp4Chk.Checked = true;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Settings.CliPathSetAutomatically)
            {
                cliExecTxt.Text = Settings.CliExecutablePath;
            }
        }

        private void showChk_CheckedChanged(object sender, EventArgs e)
        {
            if (showChk.Checked)
            {
                verboseChk.Enabled = true;
            }

            else
            {
                {
                    verboseChk.Enabled = false;
                }
            }
        }
    }
}
