namespace Academy
{
    partial class AboutAcademy
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.academyNameLabel = new System.Windows.Forms.Label();
            this.Black_panel_top = new System.Windows.Forms.Panel();
            this.setInfoLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textPhone = new System.Windows.Forms.RichTextBox();
            this.textEmail = new System.Windows.Forms.RichTextBox();
            this.textAdress = new System.Windows.Forms.RichTextBox();
            this.Black_panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.welcomeLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(107, 54);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(162, 45);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.BackColor = System.Drawing.Color.Transparent;
            this.toLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(163, 105);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(50, 45);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "to";
            // 
            // academyNameLabel
            // 
            this.academyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.academyNameLabel.AutoSize = true;
            this.academyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.academyNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.academyNameLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academyNameLabel.Location = new System.Drawing.Point(15, 150);
            this.academyNameLabel.Name = "academyNameLabel";
            this.academyNameLabel.Size = new System.Drawing.Size(346, 45);
            this.academyNameLabel.TabIndex = 2;
            this.academyNameLabel.Text = "There Academy Name";
            this.academyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Black_panel_top
            // 
            this.Black_panel_top.BackColor = System.Drawing.Color.Black;
            this.Black_panel_top.Controls.Add(this.setInfoLabel);
            this.Black_panel_top.Controls.Add(this.Exit);
            this.Black_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Black_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Black_panel_top.Name = "Black_panel_top";
            this.Black_panel_top.Size = new System.Drawing.Size(370, 30);
            this.Black_panel_top.TabIndex = 3;
            // 
            // setInfoLabel
            // 
            this.setInfoLabel.AutoSize = true;
            this.setInfoLabel.Font = new System.Drawing.Font("Prestige Elite Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setInfoLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setInfoLabel.Location = new System.Drawing.Point(12, 7);
            this.setInfoLabel.Name = "setInfoLabel";
            this.setInfoLabel.Size = new System.Drawing.Size(116, 17);
            this.setInfoLabel.TabIndex = 1;
            this.setInfoLabel.Text = "Welcome Page";
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
            this.Exit.Location = new System.Drawing.Point(338, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(19, 259);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(63, 20);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(19, 292);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 20);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.BackColor = System.Drawing.Color.Transparent;
            this.adressLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adressLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLabel.Location = new System.Drawing.Point(19, 325);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(66, 20);
            this.adressLabel.TabIndex = 8;
            this.adressLabel.Text = "Adress:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Academy.Properties.Resources.Configuration;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(327, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textPhone
            // 
            this.textPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.textPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(92, 258);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textPhone.Size = new System.Drawing.Size(177, 23);
            this.textPhone.TabIndex = 10;
            this.textPhone.TabStop = false;
            this.textPhone.Text = "";
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.textEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(92, 291);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textEmail.Size = new System.Drawing.Size(177, 23);
            this.textEmail.TabIndex = 11;
            this.textEmail.TabStop = false;
            this.textEmail.Text = "";
            // 
            // textAdress
            // 
            this.textAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAdress.Cursor = System.Windows.Forms.Cursors.Default;
            this.textAdress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdress.Location = new System.Drawing.Point(92, 325);
            this.textAdress.Name = "textAdress";
            this.textAdress.ReadOnly = true;
            this.textAdress.Size = new System.Drawing.Size(177, 83);
            this.textAdress.TabIndex = 12;
            this.textAdress.TabStop = false;
            this.textAdress.Text = "";
            // 
            // AboutAcademy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Academy.Properties.Resources.Back_Academy_Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.Black_panel_top);
            this.Controls.Add(this.academyNameLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.welcomeLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutAcademy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Page";
            this.Activated += new System.EventHandler(this.AboutAcademy_Load);
            this.Load += new System.EventHandler(this.AboutAcademy_Load);
            this.Black_panel_top.ResumeLayout(false);
            this.Black_panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label academyNameLabel;
        private System.Windows.Forms.Panel Black_panel_top;
        private System.Windows.Forms.Label setInfoLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textPhone;
        private System.Windows.Forms.RichTextBox textEmail;
        private System.Windows.Forms.RichTextBox textAdress;
    }
}