﻿namespace HiddenObjectsXMLBuilder
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.textBoxSrcPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDstPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.buttonClearAll = new System.Windows.Forms.Button();
			this.buttonSelectAll = new System.Windows.Forms.Button();
			this.listViewScenes = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonBrowseSourcePath = new System.Windows.Forms.Button();
			this.buttonBrowseDstPath = new System.Windows.Forms.Button();
			this.textBoxTextsXmlLocation = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonTextsXmlBrowse = new System.Windows.Forms.Button();
			this.checkBoxRebuildTexts = new System.Windows.Forms.CheckBox();
			this.checkBoxRebuildTP = new System.Windows.Forms.CheckBox();
			this.checkBoxBuildAlphaSelection = new System.Windows.Forms.CheckBox();
			this.checkBoxActiveZonesVisible = new System.Windows.Forms.CheckBox();
			this.checkBoxRebuildItems = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxRebuildResources = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxRebuildHints = new System.Windows.Forms.CheckBox();
			this.checkBoxRebuildScene = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBoxFadeAnimations = new System.Windows.Forms.CheckBox();
			this.checkBoxHummingBirds = new System.Windows.Forms.CheckBox();
			this.checkBoxSomeFuncs = new System.Windows.Forms.CheckBox();
			this.checkBoxEE = new System.Windows.Forms.CheckBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStart.ImageKey = "(none)";
			this.buttonStart.Location = new System.Drawing.Point(380, 601);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(115, 45);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Колбась!!!";
			this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// textBoxSrcPath
			// 
			this.textBoxSrcPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSrcPath.Location = new System.Drawing.Point(173, 6);
			this.textBoxSrcPath.Name = "textBoxSrcPath";
			this.textBoxSrcPath.Size = new System.Drawing.Size(286, 20);
			this.textBoxSrcPath.TabIndex = 4;
			this.textBoxSrcPath.TextChanged += new System.EventHandler(this.textBoxSrcPath_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Путь к исходным картинкам:";
			// 
			// textBoxDstPath
			// 
			this.textBoxDstPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDstPath.Location = new System.Drawing.Point(173, 41);
			this.textBoxDstPath.Name = "textBoxDstPath";
			this.textBoxDstPath.Size = new System.Drawing.Size(286, 20);
			this.textBoxDstPath.TabIndex = 5;
			this.textBoxDstPath.TextChanged += new System.EventHandler(this.textBoxDstPath_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Где лежат сцены в игре:";
			// 
			// textBoxLog
			// 
			this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLog.Location = new System.Drawing.Point(3, 3);
			this.textBoxLog.MaxLength = 3276799;
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.Size = new System.Drawing.Size(481, 65);
			this.textBoxLog.TabIndex = 7;
			this.textBoxLog.Text = "Log";
			this.textBoxLog.WordWrap = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(8, 104);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.buttonClearAll);
			this.splitContainer1.Panel1.Controls.Add(this.buttonSelectAll);
			this.splitContainer1.Panel1.Controls.Add(this.listViewScenes);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBoxLog);
			this.splitContainer1.Size = new System.Drawing.Size(487, 279);
			this.splitContainer1.SplitterDistance = 204;
			this.splitContainer1.TabIndex = 0;
			// 
			// buttonClearAll
			// 
			this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClearAll.Location = new System.Drawing.Point(88, 177);
			this.buttonClearAll.Name = "buttonClearAll";
			this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
			this.buttonClearAll.TabIndex = 2;
			this.buttonClearAll.Text = "Снять все";
			this.buttonClearAll.UseVisualStyleBackColor = true;
			this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
			// 
			// buttonSelectAll
			// 
			this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSelectAll.Location = new System.Drawing.Point(7, 177);
			this.buttonSelectAll.Name = "buttonSelectAll";
			this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
			this.buttonSelectAll.TabIndex = 1;
			this.buttonSelectAll.Text = "Все";
			this.buttonSelectAll.UseVisualStyleBackColor = true;
			this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
			// 
			// listViewScenes
			// 
			this.listViewScenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewScenes.CheckBoxes = true;
			this.listViewScenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listViewScenes.GridLines = true;
			this.listViewScenes.Location = new System.Drawing.Point(3, 3);
			this.listViewScenes.Name = "listViewScenes";
			this.listViewScenes.Size = new System.Drawing.Size(481, 168);
			this.listViewScenes.TabIndex = 0;
			this.listViewScenes.UseCompatibleStateImageBehavior = false;
			this.listViewScenes.View = System.Windows.Forms.View.Details;
			this.listViewScenes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewScenes_ItemChecked);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Scene";
			this.columnHeader1.Width = 1000;
			// 
			// buttonBrowseSourcePath
			// 
			this.buttonBrowseSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseSourcePath.Location = new System.Drawing.Point(465, 4);
			this.buttonBrowseSourcePath.Name = "buttonBrowseSourcePath";
			this.buttonBrowseSourcePath.Size = new System.Drawing.Size(30, 23);
			this.buttonBrowseSourcePath.TabIndex = 10;
			this.buttonBrowseSourcePath.Text = "...";
			this.buttonBrowseSourcePath.UseVisualStyleBackColor = true;
			this.buttonBrowseSourcePath.Click += new System.EventHandler(this.buttonBrowseSourcePath_Click);
			// 
			// buttonBrowseDstPath
			// 
			this.buttonBrowseDstPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseDstPath.Location = new System.Drawing.Point(465, 39);
			this.buttonBrowseDstPath.Name = "buttonBrowseDstPath";
			this.buttonBrowseDstPath.Size = new System.Drawing.Size(30, 23);
			this.buttonBrowseDstPath.TabIndex = 11;
			this.buttonBrowseDstPath.Text = "...";
			this.buttonBrowseDstPath.UseVisualStyleBackColor = true;
			this.buttonBrowseDstPath.Click += new System.EventHandler(this.buttonBrowseDstPath_Click);
			// 
			// textBoxTextsXmlLocation
			// 
			this.textBoxTextsXmlLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTextsXmlLocation.Location = new System.Drawing.Point(173, 78);
			this.textBoxTextsXmlLocation.Name = "textBoxTextsXmlLocation";
			this.textBoxTextsXmlLocation.Size = new System.Drawing.Size(286, 20);
			this.textBoxTextsXmlLocation.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Где лежит Texts.xml:";
			// 
			// buttonTextsXmlBrowse
			// 
			this.buttonTextsXmlBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTextsXmlBrowse.Location = new System.Drawing.Point(465, 76);
			this.buttonTextsXmlBrowse.Name = "buttonTextsXmlBrowse";
			this.buttonTextsXmlBrowse.Size = new System.Drawing.Size(30, 23);
			this.buttonTextsXmlBrowse.TabIndex = 14;
			this.buttonTextsXmlBrowse.Text = "...";
			this.buttonTextsXmlBrowse.UseVisualStyleBackColor = true;
			this.buttonTextsXmlBrowse.Click += new System.EventHandler(this.buttonTextsXmlBrowse_Click);
			// 
			// checkBoxRebuildTexts
			// 
			this.checkBoxRebuildTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxRebuildTexts.AutoSize = true;
			this.checkBoxRebuildTexts.Checked = true;
			this.checkBoxRebuildTexts.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxRebuildTexts.Location = new System.Drawing.Point(18, 614);
			this.checkBoxRebuildTexts.Name = "checkBoxRebuildTexts";
			this.checkBoxRebuildTexts.Size = new System.Drawing.Size(130, 17);
			this.checkBoxRebuildTexts.TabIndex = 3;
			this.checkBoxRebuildTexts.Text = "пересобрать тексты";
			this.checkBoxRebuildTexts.UseVisualStyleBackColor = true;
			// 
			// checkBoxRebuildTP
			// 
			this.checkBoxRebuildTP.AutoSize = true;
			this.checkBoxRebuildTP.Checked = true;
			this.checkBoxRebuildTP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxRebuildTP.Location = new System.Drawing.Point(10, 40);
			this.checkBoxRebuildTP.Name = "checkBoxRebuildTP";
			this.checkBoxRebuildTP.Size = new System.Drawing.Size(158, 17);
			this.checkBoxRebuildTP.TabIndex = 1;
			this.checkBoxRebuildTP.Text = "пересобрать Texture Pack";
			this.checkBoxRebuildTP.UseVisualStyleBackColor = true;
			this.checkBoxRebuildTP.CheckedChanged += new System.EventHandler(this.checkBoxRebuildTP_CheckedChanged);
			// 
			// checkBoxBuildAlphaSelection
			// 
			this.checkBoxBuildAlphaSelection.AutoSize = true;
			this.checkBoxBuildAlphaSelection.Location = new System.Drawing.Point(22, 81);
			this.checkBoxBuildAlphaSelection.Name = "checkBoxBuildAlphaSelection";
			this.checkBoxBuildAlphaSelection.Size = new System.Drawing.Size(188, 17);
			this.checkBoxBuildAlphaSelection.TabIndex = 3;
			this.checkBoxBuildAlphaSelection.Text = "сгенерить ещё и Alpha Selection";
			this.checkBoxBuildAlphaSelection.UseVisualStyleBackColor = true;
			// 
			// checkBoxActiveZonesVisible
			// 
			this.checkBoxActiveZonesVisible.AutoSize = true;
			this.checkBoxActiveZonesVisible.Location = new System.Drawing.Point(22, 63);
			this.checkBoxActiveZonesVisible.Name = "checkBoxActiveZonesVisible";
			this.checkBoxActiveZonesVisible.Size = new System.Drawing.Size(240, 17);
			this.checkBoxActiveZonesVisible.TabIndex = 2;
			this.checkBoxActiveZonesVisible.Text = "сохранить области Active Zone видимыми";
			this.checkBoxActiveZonesVisible.UseVisualStyleBackColor = true;
			// 
			// checkBoxRebuildItems
			// 
			this.checkBoxRebuildItems.AutoSize = true;
			this.checkBoxRebuildItems.Location = new System.Drawing.Point(22, 42);
			this.checkBoxRebuildItems.Name = "checkBoxRebuildItems";
			this.checkBoxRebuildItems.Size = new System.Drawing.Size(136, 17);
			this.checkBoxRebuildItems.TabIndex = 1;
			this.checkBoxRebuildItems.Text = "пересобрать items.xml";
			this.checkBoxRebuildItems.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.checkBoxRebuildResources);
			this.groupBox1.Controls.Add(this.checkBoxRebuildTP);
			this.groupBox1.Controls.Add(this.checkBoxBuildAlphaSelection);
			this.groupBox1.Controls.Add(this.checkBoxActiveZonesVisible);
			this.groupBox1.Location = new System.Drawing.Point(8, 386);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(277, 107);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ресурсы";
			// 
			// checkBoxRebuildResources
			// 
			this.checkBoxRebuildResources.AutoSize = true;
			this.checkBoxRebuildResources.Checked = true;
			this.checkBoxRebuildResources.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxRebuildResources.Location = new System.Drawing.Point(10, 17);
			this.checkBoxRebuildResources.Name = "checkBoxRebuildResources";
			this.checkBoxRebuildResources.Size = new System.Drawing.Size(170, 17);
			this.checkBoxRebuildResources.TabIndex = 0;
			this.checkBoxRebuildResources.Text = "пересобрать файл ресурсов";
			this.checkBoxRebuildResources.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.checkBoxRebuildHints);
			this.groupBox2.Controls.Add(this.checkBoxRebuildScene);
			this.groupBox2.Controls.Add(this.checkBoxRebuildItems);
			this.groupBox2.Location = new System.Drawing.Point(8, 499);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(487, 96);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Сцена";
			// 
			// checkBoxRebuildHints
			// 
			this.checkBoxRebuildHints.AutoSize = true;
			this.checkBoxRebuildHints.Location = new System.Drawing.Point(22, 65);
			this.checkBoxRebuildHints.Name = "checkBoxRebuildHints";
			this.checkBoxRebuildHints.Size = new System.Drawing.Size(134, 17);
			this.checkBoxRebuildHints.TabIndex = 2;
			this.checkBoxRebuildHints.Text = "пересобрать hints.xml";
			this.checkBoxRebuildHints.UseVisualStyleBackColor = true;
			// 
			// checkBoxRebuildScene
			// 
			this.checkBoxRebuildScene.AutoSize = true;
			this.checkBoxRebuildScene.Checked = true;
			this.checkBoxRebuildScene.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxRebuildScene.Location = new System.Drawing.Point(10, 19);
			this.checkBoxRebuildScene.Name = "checkBoxRebuildScene";
			this.checkBoxRebuildScene.Size = new System.Drawing.Size(125, 17);
			this.checkBoxRebuildScene.TabIndex = 0;
			this.checkBoxRebuildScene.Text = "Пересобрать сцену";
			this.checkBoxRebuildScene.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.checkBoxFadeAnimations);
			this.groupBox3.Controls.Add(this.checkBoxHummingBirds);
			this.groupBox3.Controls.Add(this.checkBoxSomeFuncs);
			this.groupBox3.Controls.Add(this.checkBoxEE);
			this.groupBox3.Location = new System.Drawing.Point(291, 386);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(203, 106);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Скрипты";
			// 
			// checkBoxFadeAnimations
			// 
			this.checkBoxFadeAnimations.AutoSize = true;
			this.checkBoxFadeAnimations.Location = new System.Drawing.Point(14, 86);
			this.checkBoxFadeAnimations.Name = "checkBoxFadeAnimations";
			this.checkBoxFadeAnimations.Size = new System.Drawing.Size(144, 17);
			this.checkBoxFadeAnimations.TabIndex = 3;
			this.checkBoxFadeAnimations.Text = "ncux_fade_animation.lua";
			this.checkBoxFadeAnimations.UseVisualStyleBackColor = true;
			// 
			// checkBoxHummingBirds
			// 
			this.checkBoxHummingBirds.AutoSize = true;
			this.checkBoxHummingBirds.Location = new System.Drawing.Point(14, 63);
			this.checkBoxHummingBirds.Name = "checkBoxHummingBirds";
			this.checkBoxHummingBirds.Size = new System.Drawing.Size(113, 17);
			this.checkBoxHummingBirds.TabIndex = 2;
			this.checkBoxHummingBirds.Text = "humming_birds.lua";
			this.checkBoxHummingBirds.UseVisualStyleBackColor = true;
			// 
			// checkBoxSomeFuncs
			// 
			this.checkBoxSomeFuncs.AutoSize = true;
			this.checkBoxSomeFuncs.Location = new System.Drawing.Point(14, 40);
			this.checkBoxSomeFuncs.Name = "checkBoxSomeFuncs";
			this.checkBoxSomeFuncs.Size = new System.Drawing.Size(100, 17);
			this.checkBoxSomeFuncs.TabIndex = 1;
			this.checkBoxSomeFuncs.Text = "some_funcs.lua";
			this.checkBoxSomeFuncs.UseVisualStyleBackColor = true;
			// 
			// checkBoxEE
			// 
			this.checkBoxEE.AutoSize = true;
			this.checkBoxEE.Checked = true;
			this.checkBoxEE.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxEE.Location = new System.Drawing.Point(14, 17);
			this.checkBoxEE.Name = "checkBoxEE";
			this.checkBoxEE.Size = new System.Drawing.Size(55, 17);
			this.checkBoxEE.TabIndex = 0;
			this.checkBoxEE.Text = "ee.lua";
			this.checkBoxEE.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 658);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.checkBoxRebuildTexts);
			this.Controls.Add(this.buttonTextsXmlBrowse);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxTextsXmlLocation);
			this.Controls.Add(this.buttonBrowseDstPath);
			this.Controls.Add(this.buttonBrowseSourcePath);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxDstPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxSrcPath);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(1500, 1030);
			this.MinimumSize = new System.Drawing.Size(515, 689);
			this.Name = "MainForm";
			this.Text = "HiddenObjectsXmlBuilder";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxSrcPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDstPath;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView listViewScenes;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button buttonBrowseSourcePath;
		private System.Windows.Forms.Button buttonBrowseDstPath;
		private System.Windows.Forms.TextBox textBoxTextsXmlLocation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonTextsXmlBrowse;
		private System.Windows.Forms.Button buttonClearAll;
		private System.Windows.Forms.Button buttonSelectAll;
		private System.Windows.Forms.CheckBox checkBoxRebuildTexts;
        private System.Windows.Forms.CheckBox checkBoxRebuildTP;
		private System.Windows.Forms.CheckBox checkBoxBuildAlphaSelection;
		private System.Windows.Forms.CheckBox checkBoxActiveZonesVisible;
		private System.Windows.Forms.CheckBox checkBoxRebuildItems;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxRebuildScene;
		private System.Windows.Forms.CheckBox checkBoxRebuildResources;
		private System.Windows.Forms.CheckBox checkBoxRebuildHints;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxSomeFuncs;
        private System.Windows.Forms.CheckBox checkBoxEE;
        private System.Windows.Forms.CheckBox checkBoxHummingBirds;
        private System.Windows.Forms.CheckBox checkBoxFadeAnimations;
    }
}