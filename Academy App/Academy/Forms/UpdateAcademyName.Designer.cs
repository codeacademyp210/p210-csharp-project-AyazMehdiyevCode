namespace Academy.Forms
{
    partial class UpdateAcademyName
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
            this.Black_panel_top = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.İnfoAdressLabel = new System.Windows.Forms.Label();
            this.infoEmailLabel = new System.Windows.Forms.Label();
            this.infoPhoneLabel = new System.Windows.Forms.Label();
            this.infoNameLabel = new System.Windows.Forms.Label();
            this.textBoxAcademyİnfo = new System.Windows.Forms.TextBox();
            this.textBoxAcademyPhone = new System.Windows.Forms.TextBox();
            this.textBoxAcademyAdress = new System.Windows.Forms.TextBox();
            this.textBoxAcademyEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateAcademy = new System.Windows.Forms.Button();
            this.Black_panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Black_panel_top
            // 
            this.Black_panel_top.BackColor = System.Drawing.Color.Black;
            this.Black_panel_top.Controls.Add(this.formName);
            this.Black_panel_top.Controls.Add(this.Exit);
            this.Black_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Black_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Black_panel_top.Name = "Black_panel_top";
            this.Black_panel_top.Size = new System.Drawing.Size(266, 30);
            this.Black_panel_top.TabIndex = 1;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Prestige Elite Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.formName.Location = new System.Drawing.Point(16, 7);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(116, 17);
            this.formName.TabIndex = 1;
            this.formName.Text = "Academy Info";
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
            this.Exit.Location = new System.Drawing.Point(234, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // İnfoAdressLabel
            // 
            this.İnfoAdressLabel.AutoSize = true;
            this.İnfoAdressLabel.BackColor = System.Drawing.Color.Transparent;
            this.İnfoAdressLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.İnfoAdressLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.İnfoAdressLabel.Location = new System.Drawing.Point(15, 234);
            this.İnfoAdressLabel.Name = "İnfoAdressLabel";
            this.İnfoAdressLabel.Size = new System.Drawing.Size(144, 20);
            this.İnfoAdressLabel.TabIndex = 11;
            this.İnfoAdressLabel.Text = "Academy Adress:";
            // 
            // infoEmailLabel
            // 
            this.infoEmailLabel.AutoSize = true;
            this.infoEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoEmailLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoEmailLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoEmailLabel.Location = new System.Drawing.Point(15, 174);
            this.infoEmailLabel.Name = "infoEmailLabel";
            this.infoEmailLabel.Size = new System.Drawing.Size(137, 20);
            this.infoEmailLabel.TabIndex = 10;
            this.infoEmailLabel.Text = "Academy Email:";
            // 
            // infoPhoneLabel
            // 
            this.infoPhoneLabel.AutoSize = true;
            this.infoPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoPhoneLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoPhoneLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPhoneLabel.Location = new System.Drawing.Point(15, 114);
            this.infoPhoneLabel.Name = "infoPhoneLabel";
            this.infoPhoneLabel.Size = new System.Drawing.Size(141, 20);
            this.infoPhoneLabel.TabIndex = 9;
            this.infoPhoneLabel.Text = "Academy Phone:";
            // 
            // infoNameLabel
            // 
            this.infoNameLabel.AutoSize = true;
            this.infoNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoNameLabel.Location = new System.Drawing.Point(15, 54);
            this.infoNameLabel.Name = "infoNameLabel";
            this.infoNameLabel.Size = new System.Drawing.Size(137, 20);
            this.infoNameLabel.TabIndex = 12;
            this.infoNameLabel.Text = "Academy Name:";
            // 
            // textBoxAcademyİnfo
            // 
            this.textBoxAcademyİnfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAcademyİnfo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcademyİnfo.Location = new System.Drawing.Point(15, 83);
            this.textBoxAcademyİnfo.Name = "textBoxAcademyİnfo";
            this.textBoxAcademyİnfo.Size = new System.Drawing.Size(229, 22);
            this.textBoxAcademyİnfo.TabIndex = 0;
            // 
            // textBoxAcademyPhone
            // 
            this.textBoxAcademyPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAcademyPhone.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcademyPhone.Location = new System.Drawing.Point(15, 143);
            this.textBoxAcademyPhone.Name = "textBoxAcademyPhone";
            this.textBoxAcademyPhone.Size = new System.Drawing.Size(229, 22);
            this.textBoxAcademyPhone.TabIndex = 1;
            // 
            // textBoxAcademyAdress
            // 
            this.textBoxAcademyAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAcademyAdress.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcademyAdress.Location = new System.Drawing.Point(15, 263);
            this.textBoxAcademyAdress.Name = "textBoxAcademyAdress";
            this.textBoxAcademyAdress.Size = new System.Drawing.Size(229, 22);
            this.textBoxAcademyAdress.TabIndex = 3;
            // 
            // textBoxAcademyEmail
            // 
            this.textBoxAcademyEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAcademyEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcademyEmail.Location = new System.Drawing.Point(15, 203);
            this.textBoxAcademyEmail.Name = "textBoxAcademyEmail";
            this.textBoxAcademyEmail.Size = new System.Drawing.Size(229, 22);
            this.textBoxAcademyEmail.TabIndex = 2;
            // 
            // btnUpdateAcademy
            // 
            this.btnUpdateAcademy.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateAcademy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateAcademy.FlatAppearance.BorderSize = 0;
            this.btnUpdateAcademy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAcademy.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAcademy.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateAcademy.Location = new System.Drawing.Point(0, 319);
            this.btnUpdateAcademy.Name = "btnUpdateAcademy";
            this.btnUpdateAcademy.Size = new System.Drawing.Size(266, 36);
            this.btnUpdateAcademy.TabIndex = 4;
            this.btnUpdateAcademy.Text = "Update";
            this.btnUpdateAcademy.UseVisualStyleBackColor = false;
            this.btnUpdateAcademy.Click += new System.EventHandler(this.BtnUpdateAcademy_Click);
            // 
            // UpdateAcademyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Academy.Properties.Resources.Back_Academy_Info_2;
            this.ClientSize = new System.Drawing.Size(266, 355);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdateAcademy);
            this.Controls.Add(this.textBoxAcademyEmail);
            this.Controls.Add(this.textBoxAcademyAdress);
            this.Controls.Add(this.textBoxAcademyPhone);
            this.Controls.Add(this.textBoxAcademyİnfo);
            this.Controls.Add(this.infoNameLabel);
            this.Controls.Add(this.İnfoAdressLabel);
            this.Controls.Add(this.infoEmailLabel);
            this.Controls.Add(this.infoPhoneLabel);
            this.Controls.Add(this.Black_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateAcademyName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAcademiInfo";
            this.Load += new System.EventHandler(this.UpdateAcademyName_Load);
            this.Black_panel_top.ResumeLayout(false);
            this.Black_panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Black_panel_top;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label İnfoAdressLabel;
        private System.Windows.Forms.Label infoEmailLabel;
        private System.Windows.Forms.Label infoPhoneLabel;
        private System.Windows.Forms.Label infoNameLabel;
        private System.Windows.Forms.TextBox textBoxAcademyİnfo;
        private System.Windows.Forms.TextBox textBoxAcademyPhone;
        private System.Windows.Forms.TextBox textBoxAcademyAdress;
        private System.Windows.Forms.TextBox textBoxAcademyEmail;
        private System.Windows.Forms.Button btnUpdateAcademy;
    }
}