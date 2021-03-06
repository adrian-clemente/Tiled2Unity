﻿namespace Tiled2Unity
{
    partial class Tiled2UnityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiled2UnityForm));
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonViewer = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTiledFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnityPackageToProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.supportTiledMapEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToTiled2UnityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTiled2UnityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelScale = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.textBoxExportFolder = new System.Windows.Forms.TextBox();
            this.checkBoxPreferConvexPolygons = new System.Windows.Forms.CheckBox();
            this.buttonObjectTypesXml = new System.Windows.Forms.Button();
            this.textBoxObjectTypesXml = new System.Windows.Forms.TextBox();
            this.buttonClearObjectTypes = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.ForeColor = System.Drawing.Color.White;
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(953, 346);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.WordWrap = false;
            this.richTextBoxOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxOutput_LinkClicked);
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFolderBrowser.Enabled = false;
            this.buttonFolderBrowser.Location = new System.Drawing.Point(13, 388);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(135, 23);
            this.buttonFolderBrowser.TabIndex = 3;
            this.buttonFolderBrowser.Text = "Export To ...";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new System.Drawing.Point(784, 388);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(180, 107);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Big Ass Export Button";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonViewer
            // 
            this.buttonViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewer.Enabled = false;
            this.buttonViewer.Location = new System.Drawing.Point(658, 471);
            this.buttonViewer.Name = "buttonViewer";
            this.buttonViewer.Size = new System.Drawing.Size(120, 23);
            this.buttonViewer.TabIndex = 4;
            this.buttonViewer.Text = "Preview Map";
            this.buttonViewer.UseVisualStyleBackColor = true;
            this.buttonViewer.Click += new System.EventHandler(this.buttonViewer_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(977, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTiledFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openTiledFileToolStripMenuItem
            // 
            this.openTiledFileToolStripMenuItem.Name = "openTiledFileToolStripMenuItem";
            this.openTiledFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openTiledFileToolStripMenuItem.Text = "&Open Tiled File ...";
            this.openTiledFileToolStripMenuItem.Click += new System.EventHandler(this.openTiledFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearOutputWindowToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearOutputWindowToolStripMenuItem
            // 
            this.clearOutputWindowToolStripMenuItem.Name = "clearOutputWindowToolStripMenuItem";
            this.clearOutputWindowToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clearOutputWindowToolStripMenuItem.Text = "&Clear Output Window";
            this.clearOutputWindowToolStripMenuItem.Click += new System.EventHandler(this.clearOutputWindowToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnityPackageToProjectToolStripMenuItem,
            this.showHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.supportTiledMapEditorToolStripMenuItem,
            this.donateToTiled2UnityToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutTiled2UnityToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // addUnityPackageToProjectToolStripMenuItem
            // 
            this.addUnityPackageToProjectToolStripMenuItem.Name = "addUnityPackageToProjectToolStripMenuItem";
            this.addUnityPackageToProjectToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.addUnityPackageToProjectToolStripMenuItem.Text = "Import &Unity Package to Project";
            this.addUnityPackageToProjectToolStripMenuItem.Click += new System.EventHandler(this.addUnityPackageToProjectToolStripMenuItem_Click);
            // 
            // showHelpToolStripMenuItem
            // 
            this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
            this.showHelpToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.showHelpToolStripMenuItem.Text = "Show Command &Help";
            this.showHelpToolStripMenuItem.Click += new System.EventHandler(this.showHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // supportTiledMapEditorToolStripMenuItem
            // 
            this.supportTiledMapEditorToolStripMenuItem.Name = "supportTiledMapEditorToolStripMenuItem";
            this.supportTiledMapEditorToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.supportTiledMapEditorToolStripMenuItem.Text = "&Support Tiled On Patreon ...";
            this.supportTiledMapEditorToolStripMenuItem.Click += new System.EventHandler(this.supportTiledMapEditorToolStripMenuItem_Click);
            // 
            // donateToTiled2UnityToolStripMenuItem
            // 
            this.donateToTiled2UnityToolStripMenuItem.Name = "donateToTiled2UnityToolStripMenuItem";
            this.donateToTiled2UnityToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.donateToTiled2UnityToolStripMenuItem.Text = "&Donate to Tiled2Unity";
            this.donateToTiled2UnityToolStripMenuItem.Click += new System.EventHandler(this.donateToTiled2UnityToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // aboutTiled2UnityToolStripMenuItem
            // 
            this.aboutTiled2UnityToolStripMenuItem.Name = "aboutTiled2UnityToolStripMenuItem";
            this.aboutTiled2UnityToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.aboutTiled2UnityToolStripMenuItem.Text = "&About Tiled2Unity";
            this.aboutTiled2UnityToolStripMenuItem.Click += new System.EventHandler(this.aboutTiled2UnityToolStripMenuItem_Click);
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(13, 475);
            this.labelScale.Name = "labelScale";
            this.labelScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelScale.Size = new System.Drawing.Size(70, 13);
            this.labelScale.TabIndex = 5;
            this.labelScale.Text = "Vertex Scale:";
            this.labelScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxScale
            // 
            this.textBoxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxScale.Location = new System.Drawing.Point(89, 471);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(108, 20);
            this.textBoxScale.TabIndex = 6;
            this.textBoxScale.Text = "1";
            this.textBoxScale.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxScale_Validating);
            // 
            // textBoxExportFolder
            // 
            this.textBoxExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExportFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tiled2Unity.Properties.Settings.Default, "LastExportDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxExportFolder.Location = new System.Drawing.Point(154, 390);
            this.textBoxExportFolder.Name = "textBoxExportFolder";
            this.textBoxExportFolder.ReadOnly = true;
            this.textBoxExportFolder.Size = new System.Drawing.Size(625, 20);
            this.textBoxExportFolder.TabIndex = 2;
            this.textBoxExportFolder.Text = global::Tiled2Unity.Properties.Settings.Default.LastExportDirectory;
            this.textBoxExportFolder.TextChanged += new System.EventHandler(this.textBoxExportFolder_TextChanged);
            // 
            // checkBoxPreferConvexPolygons
            // 
            this.checkBoxPreferConvexPolygons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPreferConvexPolygons.AutoSize = true;
            this.checkBoxPreferConvexPolygons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxPreferConvexPolygons.Location = new System.Drawing.Point(12, 449);
            this.checkBoxPreferConvexPolygons.Name = "checkBoxPreferConvexPolygons";
            this.checkBoxPreferConvexPolygons.Size = new System.Drawing.Size(326, 17);
            this.checkBoxPreferConvexPolygons.TabIndex = 8;
            this.checkBoxPreferConvexPolygons.Text = "Convex Polygon Colliders (may be overridden with unity:convex)";
            this.checkBoxPreferConvexPolygons.UseVisualStyleBackColor = false;
            this.checkBoxPreferConvexPolygons.CheckedChanged += new System.EventHandler(this.checkBoxPreferConvexPolygons_CheckedChanged);
            // 
            // buttonObjectTypesXml
            // 
            this.buttonObjectTypesXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonObjectTypesXml.Location = new System.Drawing.Point(12, 421);
            this.buttonObjectTypesXml.Name = "buttonObjectTypesXml";
            this.buttonObjectTypesXml.Size = new System.Drawing.Size(135, 23);
            this.buttonObjectTypesXml.TabIndex = 9;
            this.buttonObjectTypesXml.Text = "Object Types XML ...";
            this.buttonObjectTypesXml.UseVisualStyleBackColor = true;
            this.buttonObjectTypesXml.Click += new System.EventHandler(this.buttonObjectTypesXml_Click);
            // 
            // textBoxObjectTypesXml
            // 
            this.textBoxObjectTypesXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObjectTypesXml.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tiled2Unity.Properties.Settings.Default, "LastObjectTypeXmlFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxObjectTypesXml.Location = new System.Drawing.Point(154, 423);
            this.textBoxObjectTypesXml.Name = "textBoxObjectTypesXml";
            this.textBoxObjectTypesXml.ReadOnly = true;
            this.textBoxObjectTypesXml.Size = new System.Drawing.Size(498, 20);
            this.textBoxObjectTypesXml.TabIndex = 10;
            this.textBoxObjectTypesXml.Text = global::Tiled2Unity.Properties.Settings.Default.LastObjectTypeXmlFile;
            this.textBoxObjectTypesXml.TextChanged += new System.EventHandler(this.textBoxObjectTypesXml_TextChanged);
            // 
            // buttonClearObjectTypes
            // 
            this.buttonClearObjectTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearObjectTypes.Location = new System.Drawing.Point(658, 421);
            this.buttonClearObjectTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClearObjectTypes.Name = "buttonClearObjectTypes";
            this.buttonClearObjectTypes.Size = new System.Drawing.Size(120, 23);
            this.buttonClearObjectTypes.TabIndex = 11;
            this.buttonClearObjectTypes.Text = "Clear Object Types";
            this.buttonClearObjectTypes.UseVisualStyleBackColor = true;
            this.buttonClearObjectTypes.Click += new System.EventHandler(this.buttonClearObjectTypes_Click);
            // 
            // Tiled2UnityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(977, 507);
            this.Controls.Add(this.buttonClearObjectTypes);
            this.Controls.Add(this.textBoxObjectTypesXml);
            this.Controls.Add(this.buttonObjectTypesXml);
            this.Controls.Add(this.checkBoxPreferConvexPolygons);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.buttonViewer);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonFolderBrowser);
            this.Controls.Add(this.textBoxExportFolder);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 479);
            this.Name = "Tiled2UnityForm";
            this.Text = "Tiled2Unity";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxExportFolder;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonViewer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTiledFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOutputWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTiled2UnityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnityPackageToProjectToolStripMenuItem;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem supportTiledMapEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem donateToTiled2UnityToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxPreferConvexPolygons;
        private System.Windows.Forms.Button buttonObjectTypesXml;
        private System.Windows.Forms.TextBox textBoxObjectTypesXml;
        private System.Windows.Forms.Button buttonClearObjectTypes;
    }
}

