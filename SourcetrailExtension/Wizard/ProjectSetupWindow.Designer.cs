﻿namespace CoatiSoftware.SourcetrailExtension.Wizard
{
	partial class ProjectSetupWindow
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSetupWindow));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxConfiguration = new System.Windows.Forms.ComboBox();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.labelSelectProject = new System.Windows.Forms.Label();
            this.folderBrowserTargetDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxTargetDirectory = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFileNameExtension = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.comboBoxCStandard = new System.Windows.Forms.ComboBox();
            this.labelAdditionalClangOptions = new System.Windows.Forms.Label();
            this.textBoxAdditionalClangOptions = new System.Windows.Forms.TextBox();
            this.buttonClangOptionsHelp = new System.Windows.Forms.Button();
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp = new System.Windows.Forms.Button();
            this.buttonSelectReferenced = new System.Windows.Forms.Button();
            this.buttonSelectReferencing = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxNonSystemIncludesUseAngleBrackets = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelCStandard = new System.Windows.Forms.Label();
            this.treeViewProjects = new System.Windows.Forms.TreeView();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.helpProvider1.SetHelpString(this.buttonCancel, "Abort creation of the Compilation Database");
            this.buttonCancel.Location = new System.Drawing.Point(15, 486);
            this.buttonCancel.Name = "buttonCancel";
            this.helpProvider1.SetShowHelp(this.buttonCancel, true);
            this.buttonCancel.Size = new System.Drawing.Size(92, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.buttonCancel, "Abort creation of the Compilation Database");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreate
            // 
            this.helpProvider1.SetHelpString(this.buttonCreate, "Start creation of the Compilation Database");
            this.buttonCreate.Location = new System.Drawing.Point(235, 486);
            this.buttonCreate.Name = "buttonCreate";
            this.helpProvider1.SetShowHelp(this.buttonCreate, true);
            this.buttonCreate.Size = new System.Drawing.Size(92, 23);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Create";
            this.toolTip1.SetToolTip(this.buttonCreate, "Start creation of the Compilation Database");
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxConfiguration
            // 
            this.comboBoxConfiguration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfiguration.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comboBoxConfiguration, "Build configuration for Compilation Database");
            this.helpProvider1.SetHelpString(this.comboBoxConfiguration, "The selected build configuration determines the compile flags for the Compilation" +
        " Database");
            this.comboBoxConfiguration.Location = new System.Drawing.Point(109, 292);
            this.comboBoxConfiguration.Name = "comboBoxConfiguration";
            this.helpProvider1.SetShowHelp(this.comboBoxConfiguration, true);
            this.comboBoxConfiguration.Size = new System.Drawing.Size(218, 21);
            this.comboBoxConfiguration.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxConfiguration, "The selected build configuration determines the compile flags for the Compilation" +
        " Database");
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.comboBoxPlatform, "The target platform determines some compiler flags included in the Compilation Da" +
        "tabase");
            this.comboBoxPlatform.Location = new System.Drawing.Point(109, 319);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.helpProvider1.SetShowHelp(this.comboBoxPlatform, true);
            this.comboBoxPlatform.Size = new System.Drawing.Size(218, 21);
            this.comboBoxPlatform.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxPlatform, "The target platform determines some compiler flags included in the Compilation Da" +
        "tabase");
            // 
            // labelConfiguration
            // 
            this.labelConfiguration.AutoSize = true;
            this.labelConfiguration.Location = new System.Drawing.Point(12, 295);
            this.labelConfiguration.Name = "labelConfiguration";
            this.labelConfiguration.Size = new System.Drawing.Size(69, 13);
            this.labelConfiguration.TabIndex = 6;
            this.labelConfiguration.Text = "Configuration";
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Location = new System.Drawing.Point(12, 322);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(45, 13);
            this.labelPlatform.TabIndex = 7;
            this.labelPlatform.Text = "Platform";
            // 
            // buttonSelectAll
            // 
            this.helpProvider1.SetHelpString(this.buttonSelectAll, "Select all projects if not all are ticked. Deselect all otherwise");
            this.buttonSelectAll.Location = new System.Drawing.Point(239, 251);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.helpProvider1.SetShowHelp(this.buttonSelectAll, true);
            this.buttonSelectAll.Size = new System.Drawing.Size(88, 23);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "De/Select All";
            this.toolTip1.SetToolTip(this.buttonSelectAll, "Select all projects if not all are ticked. Deselect all otherwise");
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // labelSelectProject
            // 
            this.labelSelectProject.AutoSize = true;
            this.labelSelectProject.Location = new System.Drawing.Point(12, 9);
            this.labelSelectProject.Name = "labelSelectProject";
            this.labelSelectProject.Size = new System.Drawing.Size(78, 13);
            this.labelSelectProject.TabIndex = 9;
            this.labelSelectProject.Text = "Select Projects";
            // 
            // textBoxTargetDirectory
            // 
            this.helpProvider1.SetHelpString(this.textBoxTargetDirectory, "Target directory where the Compilation Database will be stored");
            this.textBoxTargetDirectory.Location = new System.Drawing.Point(109, 348);
            this.textBoxTargetDirectory.Name = "textBoxTargetDirectory";
            this.helpProvider1.SetShowHelp(this.textBoxTargetDirectory, true);
            this.textBoxTargetDirectory.Size = new System.Drawing.Size(183, 20);
            this.textBoxTargetDirectory.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxTargetDirectory, "Target directory where the Compilation Database will be stored");
            // 
            // buttonSelect
            // 
            this.helpProvider1.SetHelpString(this.buttonSelect, "Pick a target directory via folder browser");
            this.buttonSelect.Location = new System.Drawing.Point(298, 346);
            this.buttonSelect.Name = "buttonSelect";
            this.helpProvider1.SetShowHelp(this.buttonSelect, true);
            this.buttonSelect.Size = new System.Drawing.Size(29, 23);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "...";
            this.toolTip1.SetToolTip(this.buttonSelect, "Pick a target directory via folder browser");
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(109, 375);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(183, 20);
            this.textBoxFileName.TabIndex = 6;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            this.textBoxFileName.Leave += new System.EventHandler(this.textBoxFileName_Leave);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 378);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(49, 13);
            this.labelFileName.TabIndex = 13;
            this.labelFileName.Text = "Filename";
            // 
            // labelFileNameExtension
            // 
            this.labelFileNameExtension.AutoSize = true;
            this.labelFileNameExtension.Location = new System.Drawing.Point(298, 378);
            this.labelFileNameExtension.Name = "labelFileNameExtension";
            this.labelFileNameExtension.Size = new System.Drawing.Size(29, 13);
            this.labelFileNameExtension.TabIndex = 14;
            this.labelFileNameExtension.Text = ".json";
            // 
            // comboBoxCStandard
            // 
            this.comboBoxCStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCStandard.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.comboBoxCStandard, "In case your solution contains C files, please specify which C standard is to be " +
        "used for building.");
            this.comboBoxCStandard.Location = new System.Drawing.Point(109, 401);
            this.comboBoxCStandard.Name = "comboBoxCStandard";
            this.helpProvider1.SetShowHelp(this.comboBoxCStandard, true);
            this.comboBoxCStandard.Size = new System.Drawing.Size(218, 21);
            this.comboBoxCStandard.TabIndex = 7;
            this.toolTip1.SetToolTip(this.comboBoxCStandard, "In case your solution contains C files, please specify which C standard is to be " +
        "used for building.");
            // 
            // labelAdditionalClangOptions
            // 
            this.labelAdditionalClangOptions.AutoSize = true;
            this.helpProvider1.SetHelpString(this.labelAdditionalClangOptions, "Options that will be added to each compile command");
            this.labelAdditionalClangOptions.Location = new System.Drawing.Point(12, 433);
            this.labelAdditionalClangOptions.Name = "labelAdditionalClangOptions";
            this.helpProvider1.SetShowHelp(this.labelAdditionalClangOptions, true);
            this.labelAdditionalClangOptions.Size = new System.Drawing.Size(73, 13);
            this.labelAdditionalClangOptions.TabIndex = 18;
            this.labelAdditionalClangOptions.Text = "Clang Options";
            this.toolTip1.SetToolTip(this.labelAdditionalClangOptions, "Options that will be added to each compile command");
            // 
            // textBoxAdditionalClangOptions
            // 
            this.helpProvider1.SetHelpString(this.textBoxAdditionalClangOptions, "Treat project additional include directories as system include directories");
            this.textBoxAdditionalClangOptions.Location = new System.Drawing.Point(109, 430);
            this.textBoxAdditionalClangOptions.Name = "textBoxAdditionalClangOptions";
            this.helpProvider1.SetShowHelp(this.textBoxAdditionalClangOptions, true);
            this.textBoxAdditionalClangOptions.Size = new System.Drawing.Size(183, 20);
            this.textBoxAdditionalClangOptions.TabIndex = 19;
            this.toolTip1.SetToolTip(this.textBoxAdditionalClangOptions, "Options that will be added to each compile command");
            this.textBoxAdditionalClangOptions.WordWrap = false;
            // 
            // buttonClangOptionsHelp
            // 
            this.helpProvider1.SetHelpString(this.buttonClangOptionsHelp, "");
            this.buttonClangOptionsHelp.Location = new System.Drawing.Point(298, 428);
            this.buttonClangOptionsHelp.Name = "buttonClangOptionsHelp";
            this.helpProvider1.SetShowHelp(this.buttonClangOptionsHelp, false);
            this.buttonClangOptionsHelp.Size = new System.Drawing.Size(29, 23);
            this.buttonClangOptionsHelp.TabIndex = 20;
            this.buttonClangOptionsHelp.Text = "?";
            this.buttonClangOptionsHelp.UseVisualStyleBackColor = true;
            this.buttonClangOptionsHelp.Click += new System.EventHandler(this.buttonClangOptionsHelp_Click);
            // 
            // buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp
            // 
            this.helpProvider1.SetHelpString(this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp, "");
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp.Location = new System.Drawing.Point(298, 457);
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp.Name = "buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp";
            this.helpProvider1.SetShowHelp(this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp, false);
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp.Size = new System.Drawing.Size(29, 23);
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp.TabIndex = 22;
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp.Text = "?";
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp.UseVisualStyleBackColor = true;
            this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp.Click += new System.EventHandler(this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp_Click);
            // 
            // buttonSelectReferenced
            // 
            this.helpProvider1.SetHelpString(this.buttonSelectReferenced, "Recursively select all projects that are referenced by the selected entries");
            this.buttonSelectReferenced.Location = new System.Drawing.Point(15, 251);
            this.buttonSelectReferenced.Name = "buttonSelectReferenced";
            this.helpProvider1.SetShowHelp(this.buttonSelectReferenced, true);
            this.buttonSelectReferenced.Size = new System.Drawing.Size(106, 23);
            this.buttonSelectReferenced.TabIndex = 24;
            this.buttonSelectReferenced.Text = "Select Referenced";
            this.toolTip1.SetToolTip(this.buttonSelectReferenced, "Recursively select all projects that are referenced by the selected entries");
            this.buttonSelectReferenced.UseVisualStyleBackColor = true;
            this.buttonSelectReferenced.Click += new System.EventHandler(this.buttonSelectReferenced_Click);
            // 
            // buttonSelectReferencing
            // 
            this.helpProvider1.SetHelpString(this.buttonSelectReferencing, "Recursively select all projects that are referencing the selected entries");
            this.buttonSelectReferencing.Location = new System.Drawing.Point(127, 251);
            this.buttonSelectReferencing.Name = "buttonSelectReferencing";
            this.helpProvider1.SetShowHelp(this.buttonSelectReferencing, true);
            this.buttonSelectReferencing.Size = new System.Drawing.Size(106, 23);
            this.buttonSelectReferencing.TabIndex = 25;
            this.buttonSelectReferencing.Text = "Select Referencing";
            this.toolTip1.SetToolTip(this.buttonSelectReferencing, "Recursively select all projects that are referencing the selected entries");
            this.buttonSelectReferencing.UseVisualStyleBackColor = true;
            this.buttonSelectReferencing.Click += new System.EventHandler(this.buttonSelectReferencing_Click);
            // 
            // checkBoxNonSystemIncludesUseAngleBrackets
            // 
            this.checkBoxNonSystemIncludesUseAngleBrackets.AutoSize = true;
            this.checkBoxNonSystemIncludesUseAngleBrackets.Location = new System.Drawing.Point(15, 461);
            this.checkBoxNonSystemIncludesUseAngleBrackets.Name = "checkBoxNonSystemIncludesUseAngleBrackets";
            this.checkBoxNonSystemIncludesUseAngleBrackets.Size = new System.Drawing.Size(238, 17);
            this.checkBoxNonSystemIncludesUseAngleBrackets.TabIndex = 21;
            this.checkBoxNonSystemIncludesUseAngleBrackets.Text = "Non-system includes may use angle brackets";
            this.toolTip1.SetToolTip(this.checkBoxNonSystemIncludesUseAngleBrackets, "Treat project additional include directories as system include directories");
            this.checkBoxNonSystemIncludesUseAngleBrackets.UseVisualStyleBackColor = true;
            // 
            // labelCStandard
            // 
            this.labelCStandard.AutoSize = true;
            this.labelCStandard.Location = new System.Drawing.Point(12, 404);
            this.labelCStandard.Name = "labelCStandard";
            this.labelCStandard.Size = new System.Drawing.Size(60, 13);
            this.labelCStandard.TabIndex = 16;
            this.labelCStandard.Text = "C Standard";
            // 
            // treeViewProjects
            // 
            this.treeViewProjects.CheckBoxes = true;
            this.treeViewProjects.Location = new System.Drawing.Point(15, 26);
            this.treeViewProjects.Name = "treeViewProjects";
            this.treeViewProjects.Size = new System.Drawing.Size(312, 216);
            this.treeViewProjects.TabIndex = 17;
            this.treeViewProjects.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProjects_NodeCheckChanged);
            this.treeViewProjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProjectCheckList_MouseUp);
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(12, 351);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(49, 13);
            this.labelDirectory.TabIndex = 23;
            this.labelDirectory.Text = "Directory";
            // 
            // ProjectSetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(339, 521);
            this.Controls.Add(this.buttonSelectReferencing);
            this.Controls.Add(this.buttonSelectReferenced);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp);
            this.Controls.Add(this.checkBoxNonSystemIncludesUseAngleBrackets);
            this.Controls.Add(this.buttonClangOptionsHelp);
            this.Controls.Add(this.textBoxAdditionalClangOptions);
            this.Controls.Add(this.labelAdditionalClangOptions);
            this.Controls.Add(this.treeViewProjects);
            this.Controls.Add(this.labelCStandard);
            this.Controls.Add(this.comboBoxCStandard);
            this.Controls.Add(this.labelFileNameExtension);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxTargetDirectory);
            this.Controls.Add(this.labelSelectProject);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.labelConfiguration);
            this.Controls.Add(this.comboBoxPlatform);
            this.Controls.Add(this.comboBoxConfiguration);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.helpProvider1.SetHelpString(this, "Create a Compilation Database from the current C/C++ solution.");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectSetupWindow";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Create Compilation Database";
            this.toolTip1.SetToolTip(this, "Create a Compilation Database from the current C/C++ solution.");
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion Windows Form Designer generated code

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.ComboBox comboBoxConfiguration;
		private System.Windows.Forms.ComboBox comboBoxPlatform;
		private System.Windows.Forms.Label labelConfiguration;
		private System.Windows.Forms.Label labelPlatform;
		private System.Windows.Forms.Button buttonSelectAll;
		private System.Windows.Forms.Label labelSelectProject;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserTargetDirectory;
		private System.Windows.Forms.TextBox textBoxTargetDirectory;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Label labelFileName;
		private System.Windows.Forms.Label labelFileNameExtension;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ComboBox comboBoxCStandard;
		private System.Windows.Forms.Label labelCStandard;
		private System.Windows.Forms.TreeView treeViewProjects;
		private System.Windows.Forms.Label labelAdditionalClangOptions;
		private System.Windows.Forms.TextBox textBoxAdditionalClangOptions;
		private System.Windows.Forms.Button buttonClangOptionsHelp;
		private System.Windows.Forms.CheckBox checkBoxNonSystemIncludesUseAngleBrackets;
		private System.Windows.Forms.Button buttoncheckBoxNonSystemIncludesUseAngleBracketsHelp;
		private System.Windows.Forms.Label labelDirectory;
		private System.Windows.Forms.Button buttonSelectReferenced;
		private System.Windows.Forms.Button buttonSelectReferencing;
	}
}