﻿namespace NBi.UI.Genbi.View.Generator
{
    partial class GenbiView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCsvAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSuiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipRemove = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRename = new System.Windows.Forms.ToolTip(this.components);
            this.variablesControl = new NBi.UI.Genbi.View.Generator.VariablesControl();
            this.templateControl = new NBi.UI.Genbi.View.Generator.TemplateControl();
            this.settingsControl = new NBi.UI.Genbi.View.Generator.SettingsControl();
            this.testListControl = new NBi.UI.Genbi.View.Generator.TestListControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 533);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.variablesControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.templateControl);
            this.splitContainer2.Size = new System.Drawing.Size(458, 533);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.settingsControl);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.testListControl);
            this.splitContainer3.Size = new System.Drawing.Size(576, 533);
            this.splitContainer3.SplitterDistance = 101;
            this.splitContainer3.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceFileToolStripMenuItem,
            this.templateToolStripMenuItem,
            this.testSuiteToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip.TabIndex = 17;
            this.menuStrip.Text = "menuStrip1";
            // 
            // sourceFileToolStripMenuItem
            // 
            this.sourceFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCsvToolStripMenuItem,
            this.saveCsvAsToolStripMenuItem});
            this.sourceFileToolStripMenuItem.Name = "sourceFileToolStripMenuItem";
            this.sourceFileToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sourceFileToolStripMenuItem.Text = "Source file";
            // 
            // openCsvToolStripMenuItem
            // 
            this.openCsvToolStripMenuItem.Name = "openCsvToolStripMenuItem";
            this.openCsvToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openCsvToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openCsvToolStripMenuItem.Text = "Open Csv ...";
            this.openCsvToolStripMenuItem.Click += new System.EventHandler(this.OpenCsv_Click);
            // 
            // saveCsvAsToolStripMenuItem
            // 
            this.saveCsvAsToolStripMenuItem.Name = "saveCsvAsToolStripMenuItem";
            this.saveCsvAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveCsvAsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveCsvAsToolStripMenuItem.Text = "Save Csv As ...";
            this.saveCsvAsToolStripMenuItem.Visible = false;
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTemplateToolStripMenuItem,
            this.saveTemplateAsToolStripMenuItem});
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.templateToolStripMenuItem.Text = "Template";
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.openTemplateToolStripMenuItem.Text = "Open Template ...";
            this.openTemplateToolStripMenuItem.Click += new System.EventHandler(this.OpenTemplate_Click);
            // 
            // saveTemplateAsToolStripMenuItem
            // 
            this.saveTemplateAsToolStripMenuItem.Name = "saveTemplateAsToolStripMenuItem";
            this.saveTemplateAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveTemplateAsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.saveTemplateAsToolStripMenuItem.Text = "Save Template As ...";
            this.saveTemplateAsToolStripMenuItem.Click += new System.EventHandler(this.SaveTemplate_Click);
            // 
            // testSuiteToolStripMenuItem
            // 
            this.testSuiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.testSuiteToolStripMenuItem.Name = "testSuiteToolStripMenuItem";
            this.testSuiteToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.testSuiteToolStripMenuItem.Text = "Test Suite";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.generateToolStripMenuItem.Text = "&Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.Generate_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.Undo_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.Clear_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveAsToolStripMenuItem.Text = "Save As ...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveTestSuiteAs_Click);
            // 
            // toolTipRemove
            // 
            this.toolTipRemove.ToolTipTitle = "Remove";
            // 
            // toolTipRename
            // 
            this.toolTipRename.ToolTipTitle = "Rename";
            // 
            // variablesControl
            // 
            this.variablesControl.CsvContent = null;
            this.variablesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variablesControl.Location = new System.Drawing.Point(0, 0);
            this.variablesControl.Name = "variablesControl";
            this.variablesControl.Size = new System.Drawing.Size(458, 291);
            this.variablesControl.TabIndex = 20;
            this.variablesControl.TabStop = false;
            this.variablesControl.Variables = null;
            // 
            // templateControl
            // 
            this.templateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateControl.Location = new System.Drawing.Point(0, 0);
            this.templateControl.Name = "templateControl";
            this.templateControl.Size = new System.Drawing.Size(458, 238);
            this.templateControl.TabIndex = 21;
            this.templateControl.TabStop = false;
            this.templateControl.Template = "";
            this.templateControl.UseGrouping = false;
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Names = null;
            this.settingsControl.Size = new System.Drawing.Size(576, 101);
            this.settingsControl.TabIndex = 20;
            this.settingsControl.TabStop = false;
            this.settingsControl.Value = "";
            // 
            // testListControl
            // 
            this.testListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testListControl.Location = new System.Drawing.Point(0, 0);
            this.testListControl.Name = "testListControl";
            this.testListControl.Size = new System.Drawing.Size(576, 428);
            this.testListControl.TabIndex = 22;
            this.testListControl.TabStop = false;
            this.testListControl.Tests = null;
            this.testListControl.TestSelectedIndex = -1;
            // 
            // GenbiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 560);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GenbiView";
            this.Text = "Genbi";
            this.Load += new System.EventHandler(this.CsvImporterView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sourceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCsvAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSuiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipRemove;
        private System.Windows.Forms.ToolTip toolTipRename;
        private VariablesControl variablesControl;
        private TemplateControl templateControl;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private SettingsControl settingsControl;
        private TestListControl testListControl;
    }
}