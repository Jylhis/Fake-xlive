namespace Fomm {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.bBSAUnpack = new System.Windows.Forms.Button();
            this.cBSACreator = new System.Windows.Forms.Button();
            this.bTESsnip = new System.Windows.Forms.Button();
            this.bShaderEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bLaunch = new System.Windows.Forms.Button();
            this.lvEspList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cmsPlugins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInTESsnipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLoadOrderToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLoadOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLoadOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbPluginInfo = new System.Windows.Forms.TextBox();
            this.bPackageManager = new System.Windows.Forms.Button();
            this.bEnableAI = new System.Windows.Forms.Button();
            this.bSaveGames = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsPlugins.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBSAUnpack
            // 
            this.bBSAUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBSAUnpack.Location = new System.Drawing.Point(367, 166);
            this.bBSAUnpack.Name = "bBSAUnpack";
            this.bBSAUnpack.Size = new System.Drawing.Size(120, 23);
            this.bBSAUnpack.TabIndex = 0;
            this.bBSAUnpack.Text = "BSA unpacker";
            this.bBSAUnpack.UseVisualStyleBackColor = true;
            this.bBSAUnpack.Click += new System.EventHandler(this.bBSAUnpack_Click);
            // 
            // cBSACreator
            // 
            this.cBSACreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBSACreator.Location = new System.Drawing.Point(367, 195);
            this.cBSACreator.Name = "cBSACreator";
            this.cBSACreator.Size = new System.Drawing.Size(120, 23);
            this.cBSACreator.TabIndex = 1;
            this.cBSACreator.Text = "BSA creator";
            this.cBSACreator.UseVisualStyleBackColor = true;
            this.cBSACreator.Click += new System.EventHandler(this.cBSACreator_Click);
            // 
            // bTESsnip
            // 
            this.bTESsnip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTESsnip.Location = new System.Drawing.Point(367, 224);
            this.bTESsnip.Name = "bTESsnip";
            this.bTESsnip.Size = new System.Drawing.Size(120, 23);
            this.bTESsnip.TabIndex = 2;
            this.bTESsnip.Text = "Plugin editor";
            this.bTESsnip.UseVisualStyleBackColor = true;
            this.bTESsnip.Click += new System.EventHandler(this.bTESsnip_Click);
            // 
            // bShaderEdit
            // 
            this.bShaderEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bShaderEdit.Location = new System.Drawing.Point(367, 253);
            this.bShaderEdit.Name = "bShaderEdit";
            this.bShaderEdit.Size = new System.Drawing.Size(120, 23);
            this.bShaderEdit.TabIndex = 3;
            this.bShaderEdit.Text = "Shader editor";
            this.bShaderEdit.UseVisualStyleBackColor = true;
            this.bShaderEdit.Click += new System.EventHandler(this.bShaderEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(367, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 90);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bLaunch
            // 
            this.bLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLaunch.Location = new System.Drawing.Point(367, 108);
            this.bLaunch.Name = "bLaunch";
            this.bLaunch.Size = new System.Drawing.Size(120, 23);
            this.bLaunch.TabIndex = 5;
            this.bLaunch.Text = "Launch Fallout";
            this.bLaunch.UseVisualStyleBackColor = true;
            this.bLaunch.Click += new System.EventHandler(this.bLaunch_Click);
            // 
            // lvEspList
            // 
            this.lvEspList.AllowDrop = true;
            this.lvEspList.CheckBoxes = true;
            this.lvEspList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvEspList.ContextMenuStrip = this.cmsPlugins;
            this.lvEspList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEspList.Location = new System.Drawing.Point(0, 0);
            this.lvEspList.Name = "lvEspList";
            this.lvEspList.Size = new System.Drawing.Size(349, 253);
            this.lvEspList.TabIndex = 0;
            this.lvEspList.UseCompatibleStateImageBehavior = false;
            this.lvEspList.View = System.Windows.Forms.View.Details;
            this.lvEspList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvEspList_ItemChecked);
            this.lvEspList.SelectedIndexChanged += new System.EventHandler(this.lvEspList_SelectedIndexChanged);
            this.lvEspList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvEspList_DragDrop);
            this.lvEspList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvEspList_DragEnter);
            this.lvEspList.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.lvEspList_GiveFeedback);
            this.lvEspList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvEspList_KeyDown);
            this.lvEspList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvEspList_ItemDrag);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 219;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mod index";
            this.columnHeader2.Width = 87;
            // 
            // cmsPlugins
            // 
            this.cmsPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInTESsnipToolStripMenuItem,
            this.sendToTopToolStripMenuItem,
            this.sendToBottomToolStripMenuItem,
            this.copyLoadOrderToClipboardToolStripMenuItem,
            this.exportLoadOrderToolStripMenuItem,
            this.importLoadOrderToolStripMenuItem,
            this.uncheckAllToolStripMenuItem,
            this.checkAllToolStripMenuItem});
            this.cmsPlugins.Name = "cmsPlugins";
            this.cmsPlugins.Size = new System.Drawing.Size(211, 180);
            // 
            // openInTESsnipToolStripMenuItem
            // 
            this.openInTESsnipToolStripMenuItem.Name = "openInTESsnipToolStripMenuItem";
            this.openInTESsnipToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.openInTESsnipToolStripMenuItem.Text = "Open in TESsnip";
            this.openInTESsnipToolStripMenuItem.Click += new System.EventHandler(this.openInTESsnipToolStripMenuItem_Click);
            // 
            // sendToTopToolStripMenuItem
            // 
            this.sendToTopToolStripMenuItem.Name = "sendToTopToolStripMenuItem";
            this.sendToTopToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sendToTopToolStripMenuItem.Text = "Load first";
            this.sendToTopToolStripMenuItem.Click += new System.EventHandler(this.sendToTopToolStripMenuItem_Click);
            // 
            // sendToBottomToolStripMenuItem
            // 
            this.sendToBottomToolStripMenuItem.Name = "sendToBottomToolStripMenuItem";
            this.sendToBottomToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sendToBottomToolStripMenuItem.Text = "Load last";
            this.sendToBottomToolStripMenuItem.Click += new System.EventHandler(this.sendToBottomToolStripMenuItem_Click);
            // 
            // copyLoadOrderToClipboardToolStripMenuItem
            // 
            this.copyLoadOrderToClipboardToolStripMenuItem.Name = "copyLoadOrderToClipboardToolStripMenuItem";
            this.copyLoadOrderToClipboardToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.copyLoadOrderToClipboardToolStripMenuItem.Text = "Copy load order to clipboard";
            this.copyLoadOrderToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyLoadOrderToClipboardToolStripMenuItem_Click);
            // 
            // exportLoadOrderToolStripMenuItem
            // 
            this.exportLoadOrderToolStripMenuItem.Name = "exportLoadOrderToolStripMenuItem";
            this.exportLoadOrderToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exportLoadOrderToolStripMenuItem.Text = "Export load order";
            this.exportLoadOrderToolStripMenuItem.Click += new System.EventHandler(this.exportLoadOrderToolStripMenuItem_Click);
            // 
            // importLoadOrderToolStripMenuItem
            // 
            this.importLoadOrderToolStripMenuItem.Name = "importLoadOrderToolStripMenuItem";
            this.importLoadOrderToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.importLoadOrderToolStripMenuItem.Text = "Import load order";
            this.importLoadOrderToolStripMenuItem.Click += new System.EventHandler(this.importLoadOrderToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.uncheckAllToolStripMenuItem.Text = "Uncheck all";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.checkAllToolStripMenuItem.Text = "Check all";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvEspList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbPluginInfo);
            this.splitContainer1.Size = new System.Drawing.Size(349, 352);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 6;
            // 
            // tbPluginInfo
            // 
            this.tbPluginInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbPluginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPluginInfo.Location = new System.Drawing.Point(0, 0);
            this.tbPluginInfo.Multiline = true;
            this.tbPluginInfo.Name = "tbPluginInfo";
            this.tbPluginInfo.ReadOnly = true;
            this.tbPluginInfo.Size = new System.Drawing.Size(349, 95);
            this.tbPluginInfo.TabIndex = 0;
            this.tbPluginInfo.Text = "Drag/Drop to modify load order\r\nAlternatively, hold alt and use the arrow keys\r\nM" +
    "ods towards the bottom override those above them";
            // 
            // bPackageManager
            // 
            this.bPackageManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPackageManager.Location = new System.Drawing.Point(367, 282);
            this.bPackageManager.Name = "bPackageManager";
            this.bPackageManager.Size = new System.Drawing.Size(120, 23);
            this.bPackageManager.TabIndex = 9;
            this.bPackageManager.Text = "Package manager";
            this.bPackageManager.UseVisualStyleBackColor = true;
            this.bPackageManager.Click += new System.EventHandler(this.bPackageManager_Click);
            // 
            // bEnableAI
            // 
            this.bEnableAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEnableAI.Location = new System.Drawing.Point(367, 311);
            this.bEnableAI.Name = "bEnableAI";
            this.bEnableAI.Size = new System.Drawing.Size(120, 23);
            this.bEnableAI.TabIndex = 10;
            this.bEnableAI.Text = "Toggle invalidation";
            this.bEnableAI.UseVisualStyleBackColor = true;
            this.bEnableAI.Click += new System.EventHandler(this.bEnableAI_Click);
            // 
            // bSaveGames
            // 
            this.bSaveGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveGames.Location = new System.Drawing.Point(367, 340);
            this.bSaveGames.Name = "bSaveGames";
            this.bSaveGames.Size = new System.Drawing.Size(120, 23);
            this.bSaveGames.TabIndex = 11;
            this.bSaveGames.Text = "Save game list";
            this.bSaveGames.UseVisualStyleBackColor = true;
            this.bSaveGames.Click += new System.EventHandler(this.bSaveGames_Click);
            // 
            // bHelp
            // 
            this.bHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bHelp.Location = new System.Drawing.Point(367, 137);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(120, 23);
            this.bHelp.TabIndex = 12;
            this.bHelp.Text = "Help";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 375);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bSaveGames);
            this.Controls.Add(this.bEnableAI);
            this.Controls.Add(this.bPackageManager);
            this.Controls.Add(this.bLaunch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bBSAUnpack);
            this.Controls.Add(this.bShaderEdit);
            this.Controls.Add(this.bTESsnip);
            this.Controls.Add(this.cBSACreator);
            this.Name = "MainForm";
            this.Text = "Fallout Mod Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsPlugins.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBSAUnpack;
        private System.Windows.Forms.Button cBSACreator;
        private System.Windows.Forms.Button bTESsnip;
        private System.Windows.Forms.Button bShaderEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bLaunch;
        private System.Windows.Forms.ListView lvEspList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbPluginInfo;
        private System.Windows.Forms.Button bPackageManager;
        private System.Windows.Forms.Button bEnableAI;
        private System.Windows.Forms.Button bSaveGames;
        private System.Windows.Forms.ContextMenuStrip cmsPlugins;
        private System.Windows.Forms.ToolStripMenuItem openInTESsnipToolStripMenuItem;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem sendToTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyLoadOrderToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLoadOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importLoadOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
    }
}

