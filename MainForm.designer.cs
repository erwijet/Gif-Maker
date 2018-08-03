//
//Created by Tyler on 6/9/2018.
//
namespace Gif_Maker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_newProj;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_save;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_saveas;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tmsbtn_exit;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_next;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_previous;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_delimg;
		private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_editprojectpath;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_rename;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_options;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label l_imageIndex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem tsmbtn_changePath;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtn_newProj = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmbtn_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtn_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsbtn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtn_next = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtn_previous = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtn_delimg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmbtn_changePath = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtn_editprojectpath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtn_rename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmbtn_options = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.l_imageIndex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_build = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(440, 320);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(46, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(550, 320);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(46, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmbtn_newProj,
            this.openProjectToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmbtn_save,
            this.tsmbtn_saveas,
            this.toolStripSeparator2,
            this.tmsbtn_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmbtn_newProj
            // 
            this.tsmbtn_newProj.Name = "tsmbtn_newProj";
            this.tsmbtn_newProj.Size = new System.Drawing.Size(143, 22);
            this.tsmbtn_newProj.Text = "New Project";
            this.tsmbtn_newProj.Click += new System.EventHandler(this.Tsmbtn_newProjClick);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // tsmbtn_save
            // 
            this.tsmbtn_save.Enabled = false;
            this.tsmbtn_save.Name = "tsmbtn_save";
            this.tsmbtn_save.Size = new System.Drawing.Size(143, 22);
            this.tsmbtn_save.Text = "Save";
            this.tsmbtn_save.Click += new System.EventHandler(this.tsmbtn_save_Click);
            // 
            // tsmbtn_saveas
            // 
            this.tsmbtn_saveas.Enabled = false;
            this.tsmbtn_saveas.Name = "tsmbtn_saveas";
            this.tsmbtn_saveas.Size = new System.Drawing.Size(143, 22);
            this.tsmbtn_saveas.Text = "Save As";
            this.tsmbtn_saveas.Click += new System.EventHandler(this.tsmbtn_saveas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // tmsbtn_exit
            // 
            this.tmsbtn_exit.Name = "tmsbtn_exit";
            this.tmsbtn_exit.Size = new System.Drawing.Size(143, 22);
            this.tmsbtn_exit.Text = "Exit";
            this.tmsbtn_exit.Click += new System.EventHandler(this.Tmsbtn_exitClick);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmbtn_next,
            this.tsmbtn_previous,
            this.tsmbtn_delimg,
            this.toolStripSeparator4,
            this.tsmbtn_changePath});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // tsmbtn_next
            // 
            this.tsmbtn_next.Enabled = false;
            this.tsmbtn_next.Name = "tsmbtn_next";
            this.tsmbtn_next.Size = new System.Drawing.Size(155, 22);
            this.tsmbtn_next.Text = "Next Image";
            this.tsmbtn_next.Click += new System.EventHandler(this.tsmbtn_next_Click);
            // 
            // tsmbtn_previous
            // 
            this.tsmbtn_previous.Enabled = false;
            this.tsmbtn_previous.Name = "tsmbtn_previous";
            this.tsmbtn_previous.Size = new System.Drawing.Size(155, 22);
            this.tsmbtn_previous.Text = "Previous Image";
            this.tsmbtn_previous.Click += new System.EventHandler(this.tsmbtn_previous_Click);
            // 
            // tsmbtn_delimg
            // 
            this.tsmbtn_delimg.Enabled = false;
            this.tsmbtn_delimg.Name = "tsmbtn_delimg";
            this.tsmbtn_delimg.Size = new System.Drawing.Size(155, 22);
            this.tsmbtn_delimg.Text = "Delete Image";
            this.tsmbtn_delimg.Click += new System.EventHandler(this.tsmbtn_delimg_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(152, 6);
            // 
            // tsmbtn_changePath
            // 
            this.tsmbtn_changePath.Enabled = false;
            this.tsmbtn_changePath.Name = "tsmbtn_changePath";
            this.tsmbtn_changePath.Size = new System.Drawing.Size(155, 22);
            this.tsmbtn_changePath.Text = "Change Path";
            this.tsmbtn_changePath.Click += new System.EventHandler(this.tsmbtn_changePath_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmbtn_editprojectpath,
            this.tsmbtn_rename,
            this.toolStripSeparator3,
            this.tsmbtn_options});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // tsmbtn_editprojectpath
            // 
            this.tsmbtn_editprojectpath.Enabled = false;
            this.tsmbtn_editprojectpath.Name = "tsmbtn_editprojectpath";
            this.tsmbtn_editprojectpath.Size = new System.Drawing.Size(161, 22);
            this.tsmbtn_editprojectpath.Text = "Edit Project Path";
            this.tsmbtn_editprojectpath.Click += new System.EventHandler(this.Tmsbtn_editpathsClick);
            // 
            // tsmbtn_rename
            // 
            this.tsmbtn_rename.Enabled = false;
            this.tsmbtn_rename.Name = "tsmbtn_rename";
            this.tsmbtn_rename.Size = new System.Drawing.Size(161, 22);
            this.tsmbtn_rename.Text = "Rename";
            this.tsmbtn_rename.Click += new System.EventHandler(this.tsmbtn_rename_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // tsmbtn_options
            // 
            this.tsmbtn_options.Enabled = false;
            this.tsmbtn_options.Name = "tsmbtn_options";
            this.tsmbtn_options.Size = new System.Drawing.Size(161, 22);
            this.tsmbtn_options.Text = "Options";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(429, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Image #.";
            // 
            // l_imageIndex
            // 
            this.l_imageIndex.Location = new System.Drawing.Point(500, 58);
            this.l_imageIndex.Name = "l_imageIndex";
            this.l_imageIndex.Size = new System.Drawing.Size(117, 18);
            this.l_imageIndex.TabIndex = 7;
            this.l_imageIndex.Text = "0/0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "N/A";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(500, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "N/A";
            this.label4.Click += new System.EventHandler(this.Label4Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(429, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(500, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "N/A";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(429, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Format:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(500, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "N/A";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(429, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Size (bytes):";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton,
            this.toolStripSeparator5,
            this.btn_build});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_build
            // 
            this.btn_build.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_build.Image = global::Gif_Maker.Properties.Resources.launch_rocket_iphonex_ios11_ui_359c13c6090294f1_512x512;
            this.btn_build.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_build.Name = "btn_build";
            this.btn_build.Size = new System.Drawing.Size(23, 22);
            this.btn_build.Text = "Build";
            this.btn_build.Click += new System.EventHandler(this.btn_build_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(521, 320);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(23, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = " ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_deleteClick);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(492, 320);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(23, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = " ";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 378);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_imageIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gif Maker";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_build;
    }
}
