namespace Geeky.VanityRemover
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// StartCleaning up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.path = new System.Windows.Forms.TextBox();
            this.pathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dropZoneText = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // path
            // 
            resources.ApplyResources(this.path, "path");
            this.path.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.path.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.errorProvider.SetError(this.path, resources.GetString("path.Error"));
            this.errorProvider.SetIconAlignment(this.path, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("path.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.path, ((int)(resources.GetObject("path.IconPadding"))));
            this.path.Name = "path";
            this.path.TextChanged += new System.EventHandler(this.PathChanged);
            // 
            // pathDialog
            // 
            resources.ApplyResources(this.pathDialog, "pathDialog");
            this.pathDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.pathDialog.ShowNewFolderButton = false;
            // 
            // dropZoneText
            // 
            resources.ApplyResources(this.dropZoneText, "dropZoneText");
            this.errorProvider.SetError(this.dropZoneText, resources.GetString("dropZoneText.Error"));
            this.dropZoneText.ForeColor = System.Drawing.Color.Gray;
            this.errorProvider.SetIconAlignment(this.dropZoneText, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dropZoneText.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.dropZoneText, ((int)(resources.GetObject("dropZoneText.IconPadding"))));
            this.dropZoneText.Name = "dropZoneText";
            // 
            // start
            // 
            resources.ApplyResources(this.start, "start");
            this.start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider.SetError(this.start, resources.GetString("start.Error"));
            this.start.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.errorProvider.SetIconAlignment(this.start, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("start.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.start, ((int)(resources.GetObject("start.IconPadding"))));
            this.start.Image = global::Geeky.VanityRemover.Properties.Resources.go;
            this.start.Name = "start";
            this.start.Tag = "";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.StartClicked);
            // 
            // browse
            // 
            resources.ApplyResources(this.browse, "browse");
            this.errorProvider.SetError(this.browse, resources.GetString("browse.Error"));
            this.browse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.errorProvider.SetIconAlignment(this.browse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("browse.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.browse, ((int)(resources.GetObject("browse.IconPadding"))));
            this.browse.Image = global::Geeky.VanityRemover.Properties.Resources.browse;
            this.browse.Name = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.BrowseClicked);
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.errorProvider.SetError(this.progressBar, resources.GetString("progressBar.Error"));
            this.errorProvider.SetIconAlignment(this.progressBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("progressBar.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.progressBar, ((int)(resources.GetObject("progressBar.IconPadding"))));
            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Name = "progressBar";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // cancel
            // 
            resources.ApplyResources(this.cancel, "cancel");
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider.SetError(this.cancel, resources.GetString("cancel.Error"));
            this.cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.errorProvider.SetIconAlignment(this.cancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cancel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cancel, ((int)(resources.GetObject("cancel.IconPadding"))));
            this.cancel.Image = global::Geeky.VanityRemover.Properties.Resources.stop;
            this.cancel.Name = "cancel";
            this.cancel.Tag = "";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.CancelClicked);
            // 
            // Main
            // 
            this.AcceptButton = this.start;
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dropZoneText);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIsClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SomethingDropped);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SomethingEntered);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog pathDialog;
        private System.Windows.Forms.Label dropZoneText;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cancel;
    }
}