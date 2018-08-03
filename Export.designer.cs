namespace Gif_Maker
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clb_include = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_makedigirec = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_saveto_browse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.l_status = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_height = new System.Windows.Forms.NumericUpDown();
            this.nud_wdith = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wdith)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clb_include);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Include";
            // 
            // clb_include
            // 
            this.clb_include.CheckOnClick = true;
            this.clb_include.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_include.FormattingEnabled = true;
            this.clb_include.HorizontalScrollbar = true;
            this.clb_include.Items.AddRange(new object[] {
            ""});
            this.clb_include.Location = new System.Drawing.Point(3, 16);
            this.clb_include.Name = "clb_include";
            this.clb_include.Size = new System.Drawing.Size(232, 274);
            this.clb_include.TabIndex = 0;
            this.clb_include.SelectedIndexChanged += new System.EventHandler(this.clb_include_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nud_wdith);
            this.groupBox2.Controls.Add(this.nud_height);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_makedigirec);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(256, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save Info";
            // 
            // cb_makedigirec
            // 
            this.cb_makedigirec.AutoSize = true;
            this.cb_makedigirec.Location = new System.Drawing.Point(6, 106);
            this.cb_makedigirec.Name = "cb_makedigirec";
            this.cb_makedigirec.Size = new System.Drawing.Size(131, 17);
            this.cb_makedigirec.TabIndex = 2;
            this.cb_makedigirec.Text = "Preserve digital record";
            this.cb_makedigirec.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_saveto_browse);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 80);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save To";
            // 
            // btn_saveto_browse
            // 
            this.btn_saveto_browse.Location = new System.Drawing.Point(128, 45);
            this.btn_saveto_browse.Name = "btn_saveto_browse";
            this.btn_saveto_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_saveto_browse.TabIndex = 1;
            this.btn_saveto_browse.Text = "Browse...";
            this.btn_saveto_browse.UseVisualStyleBackColor = true;
            this.btn_saveto_browse.Click += new System.EventHandler(this.btn_saveto_browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pb_progress
            // 
            this.pb_progress.Location = new System.Drawing.Point(256, 236);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(221, 23);
            this.pb_progress.TabIndex = 3;
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(256, 262);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(47, 13);
            this.l_status.TabIndex = 4;
            this.l_status.Text = "Ready...";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(402, 282);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "Build";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIF Height: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GIF Width:";
            // 
            // nud_height
            // 
            this.nud_height.Location = new System.Drawing.Point(75, 18);
            this.nud_height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_height.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_height.Name = "nud_height";
            this.nud_height.Size = new System.Drawing.Size(91, 20);
            this.nud_height.TabIndex = 2;
            this.nud_height.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // nud_wdith
            // 
            this.nud_wdith.Location = new System.Drawing.Point(75, 44);
            this.nud_wdith.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_wdith.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_wdith.Name = "nud_wdith";
            this.nud_wdith.Size = new System.Drawing.Size(91, 20);
            this.nud_wdith.TabIndex = 3;
            this.nud_wdith.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pix.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pix.";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 316);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.pb_progress);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Export";
            this.Text = "Build Gif";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wdith)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clb_include;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_makedigirec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_saveto_browse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_wdith;
        private System.Windows.Forms.NumericUpDown nud_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}