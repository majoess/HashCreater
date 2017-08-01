namespace HashCreater
{
    partial class hashGeneratorForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hashGeneratorForm));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.modPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.versionLabel = new MetroFramework.Controls.MetroLabel();
            this.browseFolderMods = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFolderButton = new MetroFramework.Controls.MetroButton();
            this.generateHashes = new MetroFramework.Controls.MetroButton();
            this.filesFound = new MetroFramework.Controls.MetroLabel();
            this.versionTextBot = new MetroFramework.Controls.MetroTextBox();
            this.ausgabe = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // modPath
            // 
            // 
            // 
            // 
            this.modPath.CustomButton.Image = null;
            this.modPath.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.modPath.CustomButton.Name = "";
            this.modPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.modPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.modPath.CustomButton.TabIndex = 1;
            this.modPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.modPath.CustomButton.UseSelectable = true;
            this.modPath.CustomButton.Visible = false;
            this.modPath.Lines = new string[0];
            this.modPath.Location = new System.Drawing.Point(112, 63);
            this.modPath.MaxLength = 32767;
            this.modPath.Name = "modPath";
            this.modPath.PasswordChar = '\0';
            this.modPath.ReadOnly = true;
            this.modPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.modPath.SelectedText = "";
            this.modPath.SelectionLength = 0;
            this.modPath.SelectionStart = 0;
            this.modPath.ShortcutsEnabled = true;
            this.modPath.Size = new System.Drawing.Size(145, 23);
            this.modPath.TabIndex = 1;
            this.modPath.UseSelectable = true;
            this.modPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.modPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.modPath.Click += new System.EventHandler(this.modPath_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Modfolder";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(11, 111);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(51, 19);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version";
            // 
            // browseFolderMods
            // 
            this.browseFolderMods.ShowNewFolderButton = false;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(263, 63);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(75, 23);
            this.selectFolderButton.TabIndex = 6;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseSelectable = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // generateHashes
            // 
            this.generateHashes.Location = new System.Drawing.Point(112, 259);
            this.generateHashes.Name = "generateHashes";
            this.generateHashes.Size = new System.Drawing.Size(75, 23);
            this.generateHashes.TabIndex = 7;
            this.generateHashes.Text = "Generate";
            this.generateHashes.UseSelectable = true;
            this.generateHashes.Click += new System.EventHandler(this.generateHashes_Click);
            // 
            // filesFound
            // 
            this.filesFound.AutoSize = true;
            this.filesFound.Enabled = false;
            this.filesFound.Location = new System.Drawing.Point(112, 221);
            this.filesFound.Name = "filesFound";
            this.filesFound.Size = new System.Drawing.Size(0, 0);
            this.filesFound.TabIndex = 8;
            // 
            // versionTextBot
            // 
            // 
            // 
            // 
            this.versionTextBot.CustomButton.Image = null;
            this.versionTextBot.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.versionTextBot.CustomButton.Name = "";
            this.versionTextBot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.versionTextBot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.versionTextBot.CustomButton.TabIndex = 1;
            this.versionTextBot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.versionTextBot.CustomButton.UseSelectable = true;
            this.versionTextBot.CustomButton.Visible = false;
            this.versionTextBot.Lines = new string[] {
        "Enter version"};
            this.versionTextBot.Location = new System.Drawing.Point(112, 111);
            this.versionTextBot.MaxLength = 32767;
            this.versionTextBot.Name = "versionTextBot";
            this.versionTextBot.PasswordChar = '\0';
            this.versionTextBot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.versionTextBot.SelectedText = "";
            this.versionTextBot.SelectionLength = 0;
            this.versionTextBot.SelectionStart = 0;
            this.versionTextBot.ShortcutsEnabled = true;
            this.versionTextBot.Size = new System.Drawing.Size(121, 23);
            this.versionTextBot.TabIndex = 9;
            this.versionTextBot.Text = "Enter version";
            this.versionTextBot.UseSelectable = true;
            this.versionTextBot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.versionTextBot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.versionTextBot.Click += new System.EventHandler(this.versionTextBot_Click);
            // 
            // ausgabe
            // 
            // 
            // 
            // 
            this.ausgabe.CustomButton.Image = null;
            this.ausgabe.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.ausgabe.CustomButton.Name = "";
            this.ausgabe.CustomButton.Size = new System.Drawing.Size(221, 221);
            this.ausgabe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ausgabe.CustomButton.TabIndex = 1;
            this.ausgabe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ausgabe.CustomButton.UseSelectable = true;
            this.ausgabe.CustomButton.Visible = false;
            this.ausgabe.Lines = new string[0];
            this.ausgabe.Location = new System.Drawing.Point(521, 59);
            this.ausgabe.MaxLength = 32767;
            this.ausgabe.Multiline = true;
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.PasswordChar = '\0';
            this.ausgabe.ReadOnly = true;
            this.ausgabe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ausgabe.SelectedText = "";
            this.ausgabe.SelectionLength = 0;
            this.ausgabe.SelectionStart = 0;
            this.ausgabe.ShortcutsEnabled = true;
            this.ausgabe.Size = new System.Drawing.Size(449, 223);
            this.ausgabe.TabIndex = 10;
            this.ausgabe.UseSelectable = true;
            this.ausgabe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ausgabe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ausgabe.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(416, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Debug Console";
            // 
            // hashGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 305);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.versionTextBot);
            this.Controls.Add(this.filesFound);
            this.Controls.Add(this.generateHashes);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.modPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hashGeneratorForm";
            this.Text = " Hash Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroLabel versionLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox modPath;
        private MetroFramework.Controls.MetroButton selectFolderButton;
        private System.Windows.Forms.FolderBrowserDialog browseFolderMods;
        private MetroFramework.Controls.MetroButton generateHashes;
        private MetroFramework.Controls.MetroLabel filesFound;
        private MetroFramework.Controls.MetroTextBox versionTextBot;
        private MetroFramework.Controls.MetroTextBox ausgabe;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

