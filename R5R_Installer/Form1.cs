using Microsoft.WindowsAPICodePack.Dialogs;
using NuGet.Packaging;
using SuRGeoNix;
using SuRGeoNix.BitSwarmLib;
using SuRGeoNix.BitSwarmLib.BEP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace R5R_Installer
{
    public partial class Form1 : Form
    {

        static Torrent torrent;
        static BitSwarm bitSwarm;
        static Options opts;
        string Ddirectory;
        FileStream directoryTxT = null;
        FolderBrowserDialog dialog = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.discord.gg/r5reloaded";
            discordLink.Links.Add(link);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Ddirectory = dialog.SelectedPath;
                textBox1.Text = Ddirectory;
            }
        }
        bool hasStarted = false, hasOpenedTorrent = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (dialog.SelectedPath == "")
            {
                MessageBox.Show("You have not set a directory yet!");
                return;
            }
            opts = new Options();

            opts.FolderComplete = Ddirectory;
            opts.FolderIncomplete = Ddirectory + "/R5R-Downloading-Temp/";
            opts.MaxTotalConnections = 120;
            opts.MaxNewConnections = 300;
            opts.PeersFromTracker = -1;
            opts.BlockRequests = 500;
            opts.ConnectionTimeout = 4000;
            opts.HandshakeTimeout = 4000;
            opts.PieceTimeout = 5500;
            opts.Verbosity = 0;
            opts.LogDHT = false;
            opts.LogStats = false;
            opts.LogTracker = false;
            opts.LogPeer = false;

            bitSwarm = new BitSwarm(opts);
            bitSwarm.StatsUpdated += BitSwarm_StatsUpdated;
            bitSwarm.MetadataReceived += BitSwarm_MetadataReceived;
            bitSwarm.StatusChanged += BitSwarm_StatusChanged;

            if (!hasStarted)
            {
                if (!hasOpenedTorrent)
                {
                    bitSwarm.Open("magnet:?xt=urn:btih:KCQJQT6DV2V4XWCOKCRM4EJELRLHQKI5&dn=R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM&tr=udp%3A%2F%2Fwambo.club%3A1337%2Fannounce");
                    hasOpenedTorrent = true;
                }
                bitSwarm.Start();
                button2.Text = "Pause";
                hasStarted = true;

            }
            else
            {
                bitSwarm.Pause();
                button2.Text = "Resume/Start";
                hasStarted = false;
            }
            directoryTxT = new FileStream("Directory.txt", FileMode.OpenOrCreate);
            using(StreamWriter writer = new StreamWriter(directoryTxT, Encoding.UTF8))
            {
                writer.WriteLine(Ddirectory);
            }
        }
        private void BitSwarm_MetadataReceived(object source, BitSwarm.MetadataReceivedArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => BitSwarm_MetadataReceived(source, e)));
                return;
            }
            else
            {
                torrent = e.Torrent;
                output.Text += bitSwarm.DumpTorrent().Replace("\n", "\r\n");
            }
        }
        private void BitSwarm_StatusChanged(object source, BitSwarm.StatusChangedArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => BitSwarm_StatusChanged(this, e)));
                return;
            }

            button1.Text = "Start";

            if (e.Status == 0)
            {
                string fileName = "";
                if (torrent.file.name != null) fileName = torrent.file.name;
                if (torrent != null) { torrent.Dispose(); torrent = null; }

                MessageBox.Show("Downloaded successfully!\r\n" + "Starting detours and scripts install.");

                StartR5RDetoursAndScripts();
                MessageBox.Show("Starting Detours and Scripts installation!");

            }
            else
            {

                if (e.Status == 2)
                {
                    output.Text += "\r\n\r\n" + "An error occurred :(\r\n\t" + e.ErrorMsg;
                    MessageBox.Show("An error occured :( \r\n" + e.ErrorMsg);
                }
            }

            if (torrent != null) torrent.Dispose();
        }
        private void BitSwarm_StatsUpdated(object source, BitSwarm.StatsUpdatedArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => BitSwarm_StatsUpdated(source, e)));
                return;
            }
            else
            {
                downRate.Text = String.Format("{0:n0}", ( e.Stats.DownRate / 1024 )) + " KB/s";
                downRateAvg.Text = String.Format("{0:n0}", ( e.Stats.AvgRate / 1024 )) + " KB/s";
                eta.Text = TimeSpan.FromSeconds((e.Stats.ETA + e.Stats.AvgETA) / 2).ToString(@"hh\:mm\:ss");
                dpeers.Text = e.Stats.PeersTotal.ToString();

                if (torrent != null && torrent.data.totalSize != 0)
                    progress.Value = e.Stats.Progress;
            }

        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void StartR5RDetoursAndScripts()
        {
            if(Directory.Exists(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/"))
            {

                    string rstring = RandomString(10);
                    WebClient scriptsDownloader = new WebClient();
                    string dString = scriptsDownloader.DownloadString("https://api.r5rmodmanager.com/v1.php?data=detours");
                    MessageBox.Show("Detours");
                    scriptsDownloader.DownloadFile(new Uri(dString), Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/detours-" + rstring + ".zip");


                        var dExtract = ZipFile.Open(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/detours-" + rstring + ".zip", ZipArchiveMode.Read);
                        ZipArchiveExtensions.ExtractToDirectory(dExtract, Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/", true);
                        dExtract.Dispose();
                        File.Delete(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/detours-" + rstring + ".zip");


                    if (!Directory.Exists(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform"))
                    {
                        Directory.CreateDirectory(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform");
                    }
                    scriptsDownloader.DownloadFile(new Uri("https://github.com/Mauler125/scripts_r5/archive/refs/heads/S3_N1094.zip"), Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/newscripts.zip");


                    if (Directory.Exists(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts"))
                    {
                        Directory.Delete(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts", true);
                    }

                    var scriptszip = ZipFile.Open(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/newscripts.zip", ZipArchiveMode.Read);
                    ZipArchiveExtensions.ExtractToDirectory(scriptszip, Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/", true);
                    scriptszip.Dispose();
                    Thread.Sleep(1000);
                    File.Delete(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/newscripts.zip");

                    Directory.Move(Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts_r5-S3_N1094", Ddirectory + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts");
                    
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            directoryTxT = new FileStream("Directory.txt", FileMode.Open, FileAccess.ReadWrite);
            DirectoryInfo direcInf = null;
            using (StreamReader str = new StreamReader(directoryTxT))
            {
                direcInf = new DirectoryInfo(str.ReadLine());
            }
            DirectoryInfo[] files = direcInf.GetDirectories();
            foreach (DirectoryInfo subd in files)
            {
                subd.Delete(true);
            }
            MessageBox.Show("Removed everything in the set Download folder!");
        }

        private void URDetours_Click(object sender, EventArgs e)
        {
            try
            {
                directoryTxT = new FileStream("Directory.txt", FileMode.Open, FileAccess.ReadWrite);
                DirectoryInfo direcInf = null;
                using (StreamReader str = new StreamReader(directoryTxT))
                {
                    direcInf = new DirectoryInfo(str.ReadLine());
                }
                WebClient scriptsDownloader = new WebClient();
                string rstring = RandomString(10);
                string dString = scriptsDownloader.DownloadString("https://api.r5rmodmanager.com/v1.php?data=detours");
                scriptsDownloader.DownloadFile(new Uri(dString), direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/detours-" + rstring + ".zip");

                var dExtract = ZipFile.Open(direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/detours-" + rstring + ".zip", ZipArchiveMode.Read);
                ZipArchiveExtensions.ExtractToDirectory(dExtract, direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/", true);
                dExtract.Dispose();
                File.Delete(direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/detours-" + rstring + ".zip");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"You have to set your directory by doing the following::-1.Go to app's folder:-2.Create a new TEXT File called Directory.txt:-3.go to the installed game's folder, step back ONCE, copy the folder path from the top of the file explorer:-(for ex.D:\ApexR5\R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM -> move back once -> 'D:\ApexR5\' <- copy that):-4.paste that path into the Directory.txt file.".Replace(":-", System.Environment.NewLine));
            }
        }

        private void URScripts_Click(object sender, EventArgs e)
        {
            try
            {
                directoryTxT = new FileStream("Directory.txt", FileMode.Open, FileAccess.ReadWrite);
                DirectoryInfo direcInf = null;
                using (StreamReader str = new StreamReader(directoryTxT))
                {
                    direcInf = new DirectoryInfo(str.ReadLine());
                }
                WebClient scriptsDownloader = new WebClient();
                scriptsDownloader.DownloadFile(new Uri("https://github.com/Mauler125/scripts_r5/archive/refs/heads/S3_N1094.zip"), direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/newscripts.zip");


                if (Directory.Exists(direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts"))
                {
                    Directory.Delete(direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts", true);
                }

                var scriptszip = ZipFile.Open(direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/newscripts.zip", ZipArchiveMode.Read);
                ZipArchiveExtensions.ExtractToDirectory(scriptszip, direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/", true);
                scriptszip.Dispose();
                Thread.Sleep(1000);
                File.Delete(direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/newscripts.zip");

                Directory.Move(direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts_r5-S3_N1094", direcInf + "/R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM/platform/scripts");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"You have to set your directory by doing the following::-1.Go to app's folder:-2.Create a new TEXT File called Directory.txt:-3.go to the installed game's folder, step back ONCE, copy the folder path from the top of the file explorer:-(for ex.D:\ApexR5\R5pc_r5launch_N1094_CL456479_2019_10_30_05_20_PM -> move back once -> 'D:\ApexR5\' <- copy that):-4.paste that path into the Directory.txt file.".Replace(":-", System.Environment.NewLine));
            }
        }

        private void discordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
    public static class ZipArchiveExtensions
    {
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite)
        {
            if (!overwrite)
            {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }
            foreach (ZipArchiveEntry file in archive.Entries)
            {
                string completeFileName = Path.Combine(destinationDirectoryName, file.FullName);
                string directory = Path.GetDirectoryName(completeFileName);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                if (file.Name != "")
                    file.ExtractToFile(completeFileName, true);
            }
        }
    }
}
