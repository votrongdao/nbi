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
            this.bindingCsv = new System.Windows.Forms.BindingSource(this.components);
            this.bindingColumnNames = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remove = new System.Windows.Forms.Button();
            this.openCsv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeaderChoice = new System.Windows.Forms.ComboBox();
            this.rename = new System.Windows.Forms.Button();
            this.csvContent = new System.Windows.Forms.DataGridView();
            this.saveTemplate = new System.Windows.Forms.Button();
            this.useGrouping = new System.Windows.Forms.CheckBox();
            this.openTemplate = new System.Windows.Forms.Button();
            this.template = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsValue = new System.Windows.Forms.TextBox();
            this.settingsName = new System.Windows.Forms.ComboBox();
            this.bindingSettings = new System.Windows.Forms.BindingSource(this.components);
            this.clear = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.saveAs = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.testsList = new System.Windows.Forms.ListBox();
            this.testsListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTest = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingTests = new System.Windows.Forms.BindingSource(this.components);
            this.progressBarTest = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingColumnNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvContent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSettings)).BeginInit();
            this.testsListMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTests)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressBarTest);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.clear);
            this.splitContainer1.Panel2.Controls.Add(this.undo);
            this.splitContainer1.Panel2.Controls.Add(this.saveAs);
            this.splitContainer1.Panel2.Controls.Add(this.generate);
            this.splitContainer1.Panel2.Controls.Add(this.testsList);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 483);
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
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.csvContent);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.saveTemplate);
            this.splitContainer2.Panel2.Controls.Add(this.useGrouping);
            this.splitContainer2.Panel2.Controls.Add(this.openTemplate);
            this.splitContainer2.Panel2.Controls.Add(this.template);
            this.splitContainer2.Size = new System.Drawing.Size(458, 483);
            this.splitContainer2.SplitterDistance = 264;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.openCsv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.columnHeaderChoice);
            this.panel1.Controls.Add(this.rename);
            this.panel1.Location = new System.Drawing.Point(3, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 57);
            this.panel1.TabIndex = 16;
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Location = new System.Drawing.Point(365, 34);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(77, 23);
            this.remove.TabIndex = 18;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // openCsv
            // 
            this.openCsv.Location = new System.Drawing.Point(3, 3);
            this.openCsv.Name = "openCsv";
            this.openCsv.Size = new System.Drawing.Size(105, 23);
            this.openCsv.TabIndex = 17;
            this.openCsv.Text = "Open Csv ...";
            this.openCsv.UseVisualStyleBackColor = true;
            this.openCsv.Click += new System.EventHandler(this.OpenCsv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Column\'s name:";
            // 
            // columnHeaderChoice
            // 
            this.columnHeaderChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnHeaderChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnHeaderChoice.FormattingEnabled = true;
            this.columnHeaderChoice.Location = new System.Drawing.Point(87, 35);
            this.columnHeaderChoice.Name = "columnHeaderChoice";
            this.columnHeaderChoice.Size = new System.Drawing.Size(189, 21);
            this.columnHeaderChoice.TabIndex = 16;
            // 
            // rename
            // 
            this.rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rename.Location = new System.Drawing.Point(282, 34);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(77, 23);
            this.rename.TabIndex = 14;
            this.rename.Text = "Rename";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // csvContent
            // 
            this.csvContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.csvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvContent.Location = new System.Drawing.Point(0, 74);
            this.csvContent.Name = "csvContent";
            this.csvContent.Size = new System.Drawing.Size(455, 192);
            this.csvContent.TabIndex = 14;
            // 
            // saveTemplate
            // 
            this.saveTemplate.Location = new System.Drawing.Point(123, 8);
            this.saveTemplate.Name = "saveTemplate";
            this.saveTemplate.Size = new System.Drawing.Size(105, 23);
            this.saveTemplate.TabIndex = 20;
            this.saveTemplate.Text = "Save Template ...";
            this.saveTemplate.UseVisualStyleBackColor = true;
            this.saveTemplate.Click += new System.EventHandler(this.SaveTemplateClick);
            // 
            // useGrouping
            // 
            this.useGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useGrouping.AutoSize = true;
            this.useGrouping.Location = new System.Drawing.Point(356, 11);
            this.useGrouping.Name = "useGrouping";
            this.useGrouping.Size = new System.Drawing.Size(89, 17);
            this.useGrouping.TabIndex = 19;
            this.useGrouping.Text = "Use grouping";
            this.useGrouping.UseVisualStyleBackColor = true;
            // 
            // openTemplate
            // 
            this.openTemplate.Location = new System.Drawing.Point(12, 8);
            this.openTemplate.Name = "openTemplate";
            this.openTemplate.Size = new System.Drawing.Size(105, 23);
            this.openTemplate.TabIndex = 18;
            this.openTemplate.Text = "Open Template ...";
            this.openTemplate.UseVisualStyleBackColor = true;
            this.openTemplate.Click += new System.EventHandler(this.OpenTemplateClick);
            // 
            // template
            // 
            this.template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.template.Location = new System.Drawing.Point(0, 37);
            this.template.Multiline = true;
            this.template.Name = "template";
            this.template.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.template.Size = new System.Drawing.Size(455, 178);
            this.template.TabIndex = 12;
            this.template.WordWrap = false;
            this.template.TextChanged += new System.EventHandler(this.Template_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.settingsValue);
            this.groupBox1.Controls.Add(this.settingsName);
            this.groupBox1.Location = new System.Drawing.Point(4, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 93);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // settingsValue
            // 
            this.settingsValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsValue.Location = new System.Drawing.Point(7, 48);
            this.settingsValue.Multiline = true;
            this.settingsValue.Name = "settingsValue";
            this.settingsValue.Size = new System.Drawing.Size(547, 39);
            this.settingsValue.TabIndex = 1;
            this.settingsValue.TextChanged += new System.EventHandler(this.SettingsValue_TextChanged);
            // 
            // settingsName
            // 
            this.settingsName.DataSource = this.bindingSettings;
            this.settingsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsName.FormattingEnabled = true;
            this.settingsName.Location = new System.Drawing.Point(7, 20);
            this.settingsName.Name = "settingsName";
            this.settingsName.Size = new System.Drawing.Size(235, 21);
            this.settingsName.TabIndex = 0;
            this.settingsName.SelectedIndexChanged += new System.EventHandler(this.SettingsName_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(169, 13);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(77, 23);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(86, 13);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(77, 23);
            this.undo.TabIndex = 17;
            this.undo.Text = "&Undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // saveAs
            // 
            this.saveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAs.Location = new System.Drawing.Point(487, 13);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(77, 23);
            this.saveAs.TabIndex = 16;
            this.saveAs.Text = "Save as ...";
            this.saveAs.UseVisualStyleBackColor = true;
            this.saveAs.Click += new System.EventHandler(this.SaveAsClick);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(3, 13);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(77, 23);
            this.generate.TabIndex = 15;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // testsList
            // 
            this.testsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testsList.ContextMenuStrip = this.testsListMenu;
            this.testsList.FormattingEnabled = true;
            this.testsList.Location = new System.Drawing.Point(11, 141);
            this.testsList.Name = "testsList";
            this.testsList.Size = new System.Drawing.Size(553, 316);
            this.testsList.TabIndex = 0;
            this.testsList.SelectedIndexChanged += new System.EventHandler(this.TestsList_SelectedIndexChanged);
            this.testsList.DoubleClick += new System.EventHandler(this.TestsList_DoubleClick);
            this.testsList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TestsList_MouseDown);
            // 
            // testsListMenu
            // 
            this.testsListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTest});
            this.testsListMenu.Name = "deleteTest";
            this.testsListMenu.Size = new System.Drawing.Size(130, 26);
            this.testsListMenu.Text = "Delete test";
            this.testsListMenu.Click += new System.EventHandler(this.DeleteTest_Click);
            // 
            // deleteTest
            // 
            this.deleteTest.Name = "deleteTest";
            this.deleteTest.Size = new System.Drawing.Size(129, 22);
            this.deleteTest.Text = "Delete test";
            // 
            // progressBarTest
            // 
            this.progressBarTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTest.Location = new System.Drawing.Point(11, 457);
            this.progressBarTest.Name = "progressBarTest";
            this.progressBarTest.Size = new System.Drawing.Size(553, 23);
            this.progressBarTest.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTest.TabIndex = 20;
            // 
            // CsvGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 483);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CsvGeneratorView";
            this.Text = "Genbi";
            this.Load += new System.EventHandler(this.CsvImporterView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingCsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingColumnNames)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvContent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSettings)).EndInit();
            this.testsListMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingCsv;
        private System.Windows.Forms.BindingSource bindingColumnNames;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox template;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView csvContent;
        private System.Windows.Forms.ListBox testsList;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox columnHeaderChoice;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.Button openCsv;
        private System.Windows.Forms.Button openTemplate;
        private System.Windows.Forms.BindingSource bindingTests;
        private System.Windows.Forms.CheckBox useGrouping;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.ContextMenuStrip testsListMenu;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button saveTemplate;
        private System.Windows.Forms.ToolStripMenuItem deleteTest;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox settingsName;
        private System.Windows.Forms.TextBox settingsValue;
        private System.Windows.Forms.BindingSource bindingSettings;
        private System.Windows.Forms.ProgressBar progressBarTest;
    }
}