//
//Created by Tyler on 6/10/2018.
//
namespace Gif_Maker
{
	partial class ProjectWizard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Label label1;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectWizard));
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pname = new System.Windows.Forms.TextBox();
            this.tb_psave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_images = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(35, 347);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(23, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project name:";
            // 
            // tb_pname
            // 
            this.tb_pname.Location = new System.Drawing.Point(91, 394);
            this.tb_pname.Name = "tb_pname";
            this.tb_pname.Size = new System.Drawing.Size(229, 20);
            this.tb_pname.TabIndex = 2;
            this.tb_pname.Text = "MyProject";
            // 
            // tb_psave
            // 
            this.tb_psave.Location = new System.Drawing.Point(68, 420);
            this.tb_psave.Name = "tb_psave";
            this.tb_psave.Size = new System.Drawing.Size(252, 20);
            this.tb_psave.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saved at:";
            // 
            // btn_del
            // 
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(6, 347);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(23, 23);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "-";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_create
            // 
            this.btn_create.Enabled = false;
            this.btn_create.Location = new System.Drawing.Point(352, 420);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 10;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_images);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_del);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 376);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // lv_images
            // 
            this.lv_images.Location = new System.Drawing.Point(7, 16);
            this.lv_images.Name = "lv_images";
            this.lv_images.Size = new System.Drawing.Size(402, 325);
            this.lv_images.TabIndex = 10;
            this.lv_images.UseCompatibleStateImageBehavior = false;
            this.lv_images.View = System.Windows.Forms.View.SmallIcon;
            this.lv_images.SelectedIndexChanged += new System.EventHandler(this.lv_images_SelectedIndexChanged);
            // 
            // ProjectWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pname);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_psave);
            this.Controls.Add(this.btn_create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectWizard";
            this.Text = "New Project Creator";
            this.Load += new System.EventHandler(this.ProjectWizard_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TextBox tb_pname;
        private System.Windows.Forms.TextBox tb_psave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_images;
    }
}
