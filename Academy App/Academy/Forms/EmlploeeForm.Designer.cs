namespace Academy.Forms
{
    partial class EmlploeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimeStartTime = new System.Windows.Forms.DateTimePicker();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Black_panel_top = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.suranameLabel = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.btnPosition = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.textBoxSpeciality = new System.Windows.Forms.TextBox();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameEmploee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneEmloyee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionEmploee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryEmploee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeEmpoee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmploeeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.Black_panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeStartTime
            // 
            this.dateTimeStartTime.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeStartTime.CustomFormat = "";
            this.dateTimeStartTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStartTime.Location = new System.Drawing.Point(535, 395);
            this.dateTimeStartTime.Name = "dateTimeStartTime";
            this.dateTimeStartTime.Size = new System.Drawing.Size(168, 26);
            this.dateTimeStartTime.TabIndex = 7;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.BackColor = System.Drawing.Color.Transparent;
            this.labelStartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelStartTime.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(535, 370);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(94, 20);
            this.labelStartTime.TabIndex = 59;
            this.labelStartTime.Text = "Start Time:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.TaskName,
            this.surnameEmploee,
            this.PhoneEmloyee,
            this.EmailEmployee,
            this.PositionEmploee,
            this.SpecialityEmp,
            this.SalaryEmploee,
            this.StartTimeEmpoee,
            this.EmploeeStatus});
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.Black;
            this.dataGrid.Location = new System.Drawing.Point(14, 42);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersWidth = 15;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGreen;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(863, 261);
            this.dataGrid.TabIndex = 56;
            this.dataGrid.TabStop = false;
            this.dataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_RowHeaderMouseDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(797, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(709, 396);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(709, 357);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(709, 318);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 32);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(13, 345);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 318);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 58;
            this.nameLabel.Text = "Name:";
            // 
            // Black_panel_top
            // 
            this.Black_panel_top.BackColor = System.Drawing.Color.Black;
            this.Black_panel_top.Controls.Add(this.formName);
            this.Black_panel_top.Controls.Add(this.Exit);
            this.Black_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Black_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Black_panel_top.Name = "Black_panel_top";
            this.Black_panel_top.Size = new System.Drawing.Size(890, 30);
            this.Black_panel_top.TabIndex = 57;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Prestige Elite Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.formName.Location = new System.Drawing.Point(12, 7);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(80, 17);
            this.formName.TabIndex = 1;
            this.formName.Text = "Employee";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::Academy.Properties.Resources.Exit_min;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(858, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // suranameLabel
            // 
            this.suranameLabel.AutoSize = true;
            this.suranameLabel.BackColor = System.Drawing.Color.Transparent;
            this.suranameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.suranameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suranameLabel.Location = new System.Drawing.Point(187, 318);
            this.suranameLabel.Name = "suranameLabel";
            this.suranameLabel.Size = new System.Drawing.Size(82, 20);
            this.suranameLabel.TabIndex = 58;
            this.suranameLabel.Text = "Surname:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(187, 345);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(168, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPhone.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(361, 318);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(63, 20);
            this.labelPhone.TabIndex = 58;
            this.labelPhone.Text = "Phone:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPosition.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(13, 370);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(77, 20);
            this.labelPosition.TabIndex = 58;
            this.labelPosition.Text = "Position:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(361, 345);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(168, 22);
            this.textBoxPhone.TabIndex = 2;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(13, 395);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(131, 27);
            this.comboBoxPosition.TabIndex = 4;
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.Color.Transparent;
            this.btnPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosition.FlatAppearance.BorderSize = 0;
            this.btnPosition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosition.ForeColor = System.Drawing.Color.Black;
            this.btnPosition.Location = new System.Drawing.Point(147, 395);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(34, 27);
            this.btnPosition.TabIndex = 5;
            this.btnPosition.Text = "...";
            this.btnPosition.UseVisualStyleBackColor = false;
            this.btnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(535, 318);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 20);
            this.labelEmail.TabIndex = 58;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(535, 345);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(168, 22);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSalary.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(361, 370);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(62, 20);
            this.labelSalary.TabIndex = 58;
            this.labelSalary.Text = "Salary:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSalary.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(361, 397);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(168, 22);
            this.textBoxSalary.TabIndex = 6;
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeciality.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSpeciality.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeciality.Location = new System.Drawing.Point(183, 370);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(89, 20);
            this.labelSpeciality.TabIndex = 58;
            this.labelSpeciality.Text = "Speciality:";
            // 
            // textBoxSpeciality
            // 
            this.textBoxSpeciality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSpeciality.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpeciality.Location = new System.Drawing.Point(183, 397);
            this.textBoxSpeciality.Name = "textBoxSpeciality";
            this.textBoxSpeciality.Size = new System.Drawing.Size(168, 22);
            this.textBoxSpeciality.TabIndex = 8;
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "ID";
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            this.TaskID.Visible = false;
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskName.FillWeight = 50F;
            this.TaskName.HeaderText = "Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // surnameEmploee
            // 
            this.surnameEmploee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameEmploee.FillWeight = 60F;
            this.surnameEmploee.HeaderText = "Surname";
            this.surnameEmploee.Name = "surnameEmploee";
            this.surnameEmploee.ReadOnly = true;
            this.surnameEmploee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PhoneEmloyee
            // 
            this.PhoneEmloyee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneEmloyee.FillWeight = 70F;
            this.PhoneEmloyee.HeaderText = "Phone";
            this.PhoneEmloyee.Name = "PhoneEmloyee";
            this.PhoneEmloyee.ReadOnly = true;
            this.PhoneEmloyee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // EmailEmployee
            // 
            this.EmailEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailEmployee.FillWeight = 70F;
            this.EmailEmployee.HeaderText = "Email";
            this.EmailEmployee.Name = "EmailEmployee";
            this.EmailEmployee.ReadOnly = true;
            this.EmailEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PositionEmploee
            // 
            this.PositionEmploee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PositionEmploee.FillWeight = 60F;
            this.PositionEmploee.HeaderText = "Position";
            this.PositionEmploee.Name = "PositionEmploee";
            this.PositionEmploee.ReadOnly = true;
            this.PositionEmploee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SpecialityEmp
            // 
            this.SpecialityEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpecialityEmp.FillWeight = 60F;
            this.SpecialityEmp.HeaderText = "Speciality";
            this.SpecialityEmp.Name = "SpecialityEmp";
            this.SpecialityEmp.ReadOnly = true;
            this.SpecialityEmp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SalaryEmploee
            // 
            this.SalaryEmploee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalaryEmploee.FillWeight = 35F;
            this.SalaryEmploee.HeaderText = "Salary";
            this.SalaryEmploee.Name = "SalaryEmploee";
            this.SalaryEmploee.ReadOnly = true;
            this.SalaryEmploee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StartTimeEmpoee
            // 
            this.StartTimeEmpoee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartTimeEmpoee.FillWeight = 70F;
            this.StartTimeEmpoee.HeaderText = "Start Time";
            this.StartTimeEmpoee.Name = "StartTimeEmpoee";
            this.StartTimeEmpoee.ReadOnly = true;
            this.StartTimeEmpoee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // EmploeeStatus
            // 
            this.EmploeeStatus.HeaderText = "Status";
            this.EmploeeStatus.Name = "EmploeeStatus";
            this.EmploeeStatus.ReadOnly = true;
            this.EmploeeStatus.Visible = false;
            // 
            // EmlploeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Academy.Properties.Resources.Employee_Back;
            this.ClientSize = new System.Drawing.Size(890, 435);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.dateTimeStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBoxSpeciality);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelSpeciality);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.suranameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Black_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmlploeeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmlploeeForm";
            this.Activated += new System.EventHandler(this.EmlploeeForm_Activated);
            this.Load += new System.EventHandler(this.EmlploeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.Black_panel_top.ResumeLayout(false);
            this.Black_panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStartTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel Black_panel_top;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label suranameLabel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.TextBox textBoxSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameEmploee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneEmloyee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionEmploee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryEmploee;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeEmpoee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmploeeStatus;
    }
}