using System.Diagnostics;
using System.Net;

namespace SecurityTestingApp
{
    public partial class Form1 : Form
    {
        // Create the log
        private List<string> log = new List<string>();

        public Form1()
        {

            InitializeComponent();

        }

        private void DownloadaFileButton_Click(object sender, EventArgs e)
        {

            string downloadPath = @"C:\Windows\Temp\CreateFolder_GetProcess.ps1";

            if (File.Exists(downloadPath))
            {
                File.Delete(downloadPath);
            }


            textBoxDownloadAFile.Text = "Downloading...";
            listBoxOutput.Items.Insert(0, $"Downloading file from GitHub - {DateTime.Now}");
            log.Add($"Downloading file from GitHub - {DateTime.Now}");
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;

                Uri uri = new Uri("https://raw.githubusercontent.com/double-virgule/SecurityTesting/main/CreateFolder_GetProcess.ps1");
                wc.DownloadFileAsync(uri, downloadPath);
            }


        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgressBar.Value = e.ProgressPercentage;
        }

        private void wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null && File.Exists(@"C:\Windows\Temp\CreateFolder_GetProcess.ps1"))
            {
                textBoxDownloadAFile.Text = "Download Successful";
                listBoxOutput.Items.Insert(0, $"Download successful - {DateTime.Now}");
                log.Add($"Download successful - {DateTime.Now}");
            }
            else
            {
                listBoxOutput.Items.Insert(0, $"Download failed - {DateTime.Now}");
                log.Add($"Download failed - {DateTime.Now}");
                textBoxDownloadAFile.Text = "Download Failed";
            }
        }

        private async void CreateAFileButton_Click(object sender, EventArgs e)
        {
            string dirPath = @"C:\Windows\Temp";
            string filePath = Path.Combine(dirPath, "RandomEXEFile.exe");

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            listBoxOutput.Items.Insert(0, $"Creating file using cmd.exe - {DateTime.Now}");
            log.Add($"Creating file using cmd.exe - {DateTime.Now}");

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;

            using (Process p = Process.Start(psi))
            {
                using (StreamWriter sw = p.StandardInput)
                {
                    await sw.WriteLineAsync($@"if not exist ""{dirPath}"" mkdir ""{dirPath}""");
                    await sw.WriteLineAsync($@"echo. > ""{filePath}""");
                }
                string output = await p.StandardOutput.ReadToEndAsync();

                if (File.Exists(@"C:\Windows\Temp\RandomEXEFile.exe"))
                {
                    listBoxOutput.Items.Insert(0, $"File successfully created using cmd.exe - {DateTime.Now}");
                    log.Add($"File successfully created using cmd.exe - {DateTime.Now}");
                    textBoxCreateaFile.Text = "Success";
                }
                else
                {
                    listBoxOutput.Items.Insert(0, $"File creation failed using cmd.exe - {DateTime.Now}");
                    log.Add($"File creation failed using cmd.exe - {DateTime.Now}");
                    textBoxCreateaFile.Text = "Failed";
                }
            }
        }
        private async void RunAPSScriptButton_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Insert(0, $"Running Powershell script - {DateTime.Now}");
            log.Add($"Running Powershell script C:\\Windows\\Temp\\CreateFolder_GetProcess - {DateTime.Now}");

            await Task.Run(() => RunPowershellScript());
        }

        private void RunPowershellScript()
        {
            string scriptPath = @"C:\Windows\Temp\CreateFolder_GetProcess.ps1";

            if (!File.Exists(scriptPath))
            {
                string filePath = @"C:\Windows\Temp\CreateFolder_GetProcess.ps1";
                string[] content = new string[] { @"new-item -path C:\Windows\Temp -ItemType Directory -Name DangerousFolder -erroraction SilentlyContinue", @"get-process | out-file C:\Windows\Temp\DangerousFolder\processlist.txt - append" };
                File.WriteAllLines(filePath, content);
            }
            else
            {

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "powershell.exe";
                psi.Arguments = $"-File \"{scriptPath}\"";
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;

                using (Process p = Process.Start(psi))
                {
                    string output = p.StandardOutput.ReadToEnd();
                    log.Add($"{output} - {DateTime.Now}");

                    this.Invoke(new Action(() =>
                    {
                        listBoxOutput.Items.Insert(0, $"{output} - {DateTime.Now}");
                    }));

                    p.WaitForExit();
                    int exitCode = p.ExitCode;

                    this.Invoke(new Action(() =>
                    {
                        textRunAPSScript.Text += exitCode == 0 ? "Success" : "Failure";
                    }));
                }
            }
        }

        private void dumpResultsButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "SecurityTestingToolLog.txt");

            File.WriteAllLines(filePath, log);
            if (File.Exists(filePath))
            {
                textDumpResults.Text = "Success";
            }
            else
            {
                textDumpResults.Text = "Failure";
            }
            listBoxOutput.Items.Insert(0, $"Log file at {filePath} - {DateTime.Now}");
        }


    }
}