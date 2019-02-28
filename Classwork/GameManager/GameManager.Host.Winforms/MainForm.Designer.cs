﻿namespace GameManager.Host.Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._miFile = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this._miGames = new System.Windows.Forms.ToolStripMenuItem();
            this._miGamesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miGamesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miGamesDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._listGames = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFile,
            this._miGames,
            this._miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _miFile
            // 
            this._miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this._miFile.Name = "_miFile";
            this._miFile.Size = new System.Drawing.Size(37, 20);
            this._miFile.Text = "&File";
            this._miFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(92, 22);
            this._miFileExit.Text = "E&xit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // _miGames
            // 
            this._miGames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miGamesAdd,
            this._miGamesEdit,
            this.toolStripSeparator1,
            this._miGamesDelete});
            this._miGames.Name = "_miGames";
            this._miGames.Size = new System.Drawing.Size(55, 20);
            this._miGames.Text = "&Games";
            // 
            // _miGamesAdd
            // 
            this._miGamesAdd.Name = "_miGamesAdd";
            this._miGamesAdd.Size = new System.Drawing.Size(180, 22);
            this._miGamesAdd.Text = "&Add";
            this._miGamesAdd.Click += new System.EventHandler(this.OnGameAdd);
            // 
            // _miGamesEdit
            // 
            this._miGamesEdit.Name = "_miGamesEdit";
            this._miGamesEdit.Size = new System.Drawing.Size(180, 22);
            this._miGamesEdit.Text = "&Edit";
            this._miGamesEdit.Click += new System.EventHandler(this.OnGameEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // _miGamesDelete
            // 
            this._miGamesDelete.Name = "_miGamesDelete";
            this._miGamesDelete.Size = new System.Drawing.Size(180, 22);
            this._miGamesDelete.Text = "&Delete";
            this._miGamesDelete.Click += new System.EventHandler(this.OnGameDelete);
            // 
            // _miHelp
            // 
            this._miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this._miHelp.Name = "_miHelp";
            this._miHelp.Size = new System.Drawing.Size(44, 20);
            this._miHelp.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.Size = new System.Drawing.Size(107, 22);
            this._miHelpAbout.Text = "&About";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _listGames
            // 
            this._listGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._listGames.FormattingEnabled = true;
            this._listGames.Location = new System.Drawing.Point(12, 27);
            this._listGames.Name = "_listGames";
            this._listGames.Size = new System.Drawing.Size(549, 251);
            this._listGames.TabIndex = 1;
            this._listGames.SelectedIndexChanged += new System.EventHandler(this.OnGameSelected);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._listGames);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Game Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _miFile;
        private System.Windows.Forms.ToolStripMenuItem _miGames;
        private System.Windows.Forms.ToolStripMenuItem _miHelp;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem _miGamesAdd;
        private System.Windows.Forms.ToolStripMenuItem _miGamesEdit;
        private System.Windows.Forms.ToolStripMenuItem _miGamesDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ListBox _listGames;
    }
}

