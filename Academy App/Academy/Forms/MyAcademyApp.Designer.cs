namespace Academy
{
    partial class MyAcademyApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAcademyApp));
            this.Exit = new System.Windows.Forms.Button();
            this.Black_panel_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.app_name = new System.Windows.Forms.Label();
            this.btnStundent = new System.Windows.Forms.Button();
            this.btnEmloyee = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Black_panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::Academy.Properties.Resources.Exit_min;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(228, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Black_panel_top
            // 
            this.Black_panel_top.BackColor = System.Drawing.Color.Black;
            this.Black_panel_top.Controls.Add(this.pictureBox1);
            this.Black_panel_top.Controls.Add(this.app_name);
            this.Black_panel_top.Controls.Add(this.Exit);
            this.Black_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Black_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Black_panel_top.Name = "Black_panel_top";
            this.Black_panel_top.Size = new System.Drawing.Size(260, 30);
            this.Black_panel_top.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Academy.Properties.Resources.App_Ico_Academy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.Font = new System.Drawing.Font("Prestige Elite Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.app_name.Location = new System.Drawing.Point(38, 7);
            this.app_name.Name = "app_name";
            this.app_name.Size = new System.Drawing.Size(107, 17);
            this.app_name.TabIndex = 1;
            this.app_name.Text = "AcademyName";
            // 
            // btnStundent
            // 
            this.btnStundent.BackColor = System.Drawing.Color.Transparent;
            this.btnStundent.BackgroundImage = global::Academy.Properties.Resources.Add_Student_2;
            this.btnStundent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStundent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStundent.FlatAppearance.BorderSize = 0;
            this.btnStundent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStundent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStundent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStundent.Location = new System.Drawing.Point(4, 7);
            this.btnStundent.Name = "btnStundent";
            this.btnStundent.Size = new System.Drawing.Size(100, 100);
            this.btnStundent.TabIndex = 1;
            this.btnStundent.TabStop = false;
            this.btnStundent.UseVisualStyleBackColor = false;
            this.btnStundent.Click += new System.EventHandler(this.BtnStundent_Click);
            // 
            // btnEmloyee
            // 
            this.btnEmloyee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmloyee.BackgroundImage = global::Academy.Properties.Resources.Add_Employee;
            this.btnEmloyee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmloyee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmloyee.FlatAppearance.BorderSize = 0;
            this.btnEmloyee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmloyee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmloyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmloyee.Location = new System.Drawing.Point(115, 7);
            this.btnEmloyee.Name = "btnEmloyee";
            this.btnEmloyee.Size = new System.Drawing.Size(100, 100);
            this.btnEmloyee.TabIndex = 2;
            this.btnEmloyee.TabStop = false;
            this.btnEmloyee.UseVisualStyleBackColor = false;
            this.btnEmloyee.Click += new System.EventHandler(this.BtnEmloyee_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGroup.BackgroundImage")));
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Location = new System.Drawing.Point(4, 113);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(100, 100);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.TabStop = false;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.Transparent;
            this.btnTask.BackgroundImage = global::Academy.Properties.Resources.Task;
            this.btnTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Location = new System.Drawing.Point(115, 113);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(100, 100);
            this.btnTask.TabIndex = 4;
            this.btnTask.TabStop = false;
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnStundent);
            this.panel1.Controls.Add(this.btnTask);
            this.panel1.Controls.Add(this.btnEmloyee);
            this.panel1.Controls.Add(this.btnGroup);
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 5;
            // 
            // MyAcademyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Academy.Properties.Resources.Back_Academy;
            this.ClientSize = new System.Drawing.Size(260, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Black_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyAcademyApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academy App";
            this.Activated += new System.EventHandler(this.MyAcademyApp_Activated);
            this.Load += new System.EventHandler(this.MyAcademyApp_Load);
            this.Black_panel_top.ResumeLayout(false);
            this.Black_panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel Black_panel_top;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.Button btnStundent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmloyee;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Panel panel1;
    }
}

