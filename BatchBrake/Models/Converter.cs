using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchBrake.Models
{
    public class Converter
    {
        public delegate void InvokeDelegate();

        public bool IsCurrentlyConverting { get; set; }
        public BatchBrake Batch { get; set; }
        public Settings Settings { get; set; }
        public OutputHandler OutputHandler { get; set; }
        public Process CurrentProcess { get; set; }
        public ProcessStartInfo ProcessStartInfo { get; set; }
        public bool CancellationRequested { get; set; }

        private string CurrentFile { get; set; }
        private string CurrentDirectory { get;  set; }
        private Dictionary<string, bool> AlreadyConverted { get; set; } 

        public Converter(BatchBrake batchBrake, Settings settings, OutputHandler outputHandler)
        {
            Batch = batchBrake;
            Settings = settings;
            OutputHandler = outputHandler;
            CurrentDirectory = Settings.RootFolderPath;
            AlreadyConverted = new Dictionary<string, bool>();
        }

        public void StartConversion()
        {
            DirSearch(CurrentDirectory);
        }

        private void DirSearch(string dir)
        {
            try
            {
                foreach (var directory in Directory.GetDirectories(dir))
                {
                    foreach (
                        var file in
                            Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories)
                                     .Where(s => Settings.SupportedExtensions.Contains(Path.GetExtension(s).ToLower())))
                    {

                        Console.WriteLine(file);
                        CurrentFile = file;
                        
                        Batch.CurrentFileBeingConverted.BeginInvoke(new InvokeDelegate(UpdateCurrentFile));
                        
                    }

                    DirSearch(directory);
                }

            }
            catch (Exception)
            {

            }
        }

        private void UpdateCurrentFile()
        {
            Batch.CurrentFileBeingConverted.Text = CurrentFile;
            //DialogResult dialogResult = MessageBox.Show(CurrentFile);
        }

        private void CheckIfPreviouslyScanned()
        {
            
        }

        private void ConversionCompleted()
        {
            AlreadyConverted.Add(CurrentFile, true);
        }
    }
}
