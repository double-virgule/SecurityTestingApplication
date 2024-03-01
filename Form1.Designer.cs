namespace SecurityTestingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.DownloadaFileButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.labelWhatElse = new System.Windows.Forms.Label();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxDownloadAFile = new System.Windows.Forms.TextBox();
            this.CreateAFileButton = new System.Windows.Forms.Button();
            this.RunAPSScriptButton = new System.Windows.Forms.Button();
            this.textBoxCreateaFile = new System.Windows.Forms.TextBox();
            this.textRunAPSScript = new System.Windows.Forms.TextBox();
            this.dumpResultsButton = new System.Windows.Forms.Button();
            this.textDumpResults = new System.Windows.Forms.TextBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Title.Location = new System.Drawing.Point(146, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(545, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "Security Testing Tool";
            // 
            // DownloadaFileButton
            // 
            this.DownloadaFileButton.Location = new System.Drawing.Point(55, 308);
            this.DownloadaFileButton.Name = "DownloadaFileButton";
            this.DownloadaFileButton.Size = new System.Drawing.Size(137, 37);
            this.DownloadaFileButton.TabIndex = 1;
            this.DownloadaFileButton.Text = "Download a File";
            this.DownloadaFileButton.UseVisualStyleBackColor = true;
            this.DownloadaFileButton.Click += new System.EventHandler(this.DownloadaFileButton_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.ForeColor = System.Drawing.Color.Lime;
            this.Description.Location = new System.Drawing.Point(173, 83);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(457, 40);
            this.Description.TabIndex = 2;
            this.Description.Text = "Hi! I shouldn\'t be able to run if you\'ve got user executables blocked \r\nand you d" +
    "idn\'t run me from an admin or system context.";
            this.Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWhatElse
            // 
            this.labelWhatElse.AutoSize = true;
            this.labelWhatElse.ForeColor = System.Drawing.Color.Lime;
            this.labelWhatElse.Location = new System.Drawing.Point(325, 140);
            this.labelWhatElse.Name = "labelWhatElse";
            this.labelWhatElse.Size = new System.Drawing.Size(153, 20);
            this.labelWhatElse.TabIndex = 3;
            this.labelWhatElse.Text = "What else can we do?";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(55, 351);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(137, 29);
            this.downloadProgressBar.TabIndex = 4;
            // 
            // textBoxDownloadAFile
            // 
            this.textBoxDownloadAFile.BackColor = System.Drawing.Color.Black;
            this.textBoxDownloadAFile.ForeColor = System.Drawing.Color.Lime;
            this.textBoxDownloadAFile.Location = new System.Drawing.Point(55, 385);
            this.textBoxDownloadAFile.Name = "textBoxDownloadAFile";
            this.textBoxDownloadAFile.Size = new System.Drawing.Size(137, 27);
            this.textBoxDownloadAFile.TabIndex = 5;
            // 
            // CreateAFileButton
            // 
            this.CreateAFileButton.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAFileButton.Location = new System.Drawing.Point(231, 308);
            this.CreateAFileButton.Name = "CreateAFileButton";
            this.CreateAFileButton.Size = new System.Drawing.Size(160, 37);
            this.CreateAFileButton.TabIndex = 6;
            this.CreateAFileButton.Text = "Create File (Batch Script)";
            this.CreateAFileButton.UseVisualStyleBackColor = true;
            this.CreateAFileButton.Click += new System.EventHandler(this.CreateAFileButton_Click);
            // 
            // RunAPSScriptButton
            // 
            this.RunAPSScriptButton.Location = new System.Drawing.Point(434, 307);
            this.RunAPSScriptButton.Name = "RunAPSScriptButton";
            this.RunAPSScriptButton.Size = new System.Drawing.Size(137, 37);
            this.RunAPSScriptButton.TabIndex = 7;
            this.RunAPSScriptButton.Text = "Run a PS Script";
            this.RunAPSScriptButton.UseVisualStyleBackColor = true;
            this.RunAPSScriptButton.Click += new System.EventHandler(this.RunAPSScriptButton_Click);
            // 
            // textBoxCreateaFile
            // 
            this.textBoxCreateaFile.BackColor = System.Drawing.Color.Black;
            this.textBoxCreateaFile.ForeColor = System.Drawing.Color.Lime;
            this.textBoxCreateaFile.Location = new System.Drawing.Point(231, 385);
            this.textBoxCreateaFile.Name = "textBoxCreateaFile";
            this.textBoxCreateaFile.Size = new System.Drawing.Size(159, 27);
            this.textBoxCreateaFile.TabIndex = 8;
            // 
            // textRunAPSScript
            // 
            this.textRunAPSScript.BackColor = System.Drawing.Color.Black;
            this.textRunAPSScript.ForeColor = System.Drawing.Color.Lime;
            this.textRunAPSScript.Location = new System.Drawing.Point(434, 385);
            this.textRunAPSScript.Name = "textRunAPSScript";
            this.textRunAPSScript.Size = new System.Drawing.Size(137, 27);
            this.textRunAPSScript.TabIndex = 9;
            // 
            // dumpResultsButton
            // 
            this.dumpResultsButton.Location = new System.Drawing.Point(599, 307);
            this.dumpResultsButton.Name = "dumpResultsButton";
            this.dumpResultsButton.Size = new System.Drawing.Size(160, 37);
            this.dumpResultsButton.TabIndex = 10;
            this.dumpResultsButton.Text = "Dump Results to Log";
            this.dumpResultsButton.UseVisualStyleBackColor = true;
            this.dumpResultsButton.Click += new System.EventHandler(this.dumpResultsButton_Click);
            // 
            // textDumpResults
            // 
            this.textDumpResults.BackColor = System.Drawing.Color.Black;
            this.textDumpResults.ForeColor = System.Drawing.Color.Lime;
            this.textDumpResults.Location = new System.Drawing.Point(599, 385);
            this.textDumpResults.Name = "textDumpResults";
            this.textDumpResults.Size = new System.Drawing.Size(159, 27);
            this.textDumpResults.TabIndex = 11;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.Color.Black;
            this.listBoxOutput.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxOutput.ForeColor = System.Drawing.Color.Lime;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 17;
            this.listBoxOutput.Location = new System.Drawing.Point(55, 164);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(703, 123);
            this.listBoxOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.textDumpResults);
            this.Controls.Add(this.dumpResultsButton);
            this.Controls.Add(this.textRunAPSScript);
            this.Controls.Add(this.textBoxCreateaFile);
            this.Controls.Add(this.RunAPSScriptButton);
            this.Controls.Add(this.CreateAFileButton);
            this.Controls.Add(this.textBoxDownloadAFile);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.labelWhatElse);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DownloadaFileButton);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "SecurityTool";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Button DownloadaFileButton;
        private Label Description;
        private Label labelWhatElse;
        private ProgressBar downloadProgressBar;
        private TextBox textBoxDownloadAFile;
        private Button CreateAFileButton;
        private Button RunAPSScriptButton;
        private TextBox textBoxCreateaFile;
        private TextBox textRunAPSScript;
        private Button dumpResultsButton;
        private TextBox textDumpResults;
        private RichTextBox richTextBoxOutput;
        private ListBox listBoxOutput;


    }
}