namespace GlazkiSaveNewApp
{
    partial class AddEditForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label titleLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveChangeBtn = new System.Windows.Forms.Button();
            this.titleComboBox1 = new System.Windows.Forms.ComboBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changeImgBtn = new System.Windows.Forms.Button();
            this.changePictureBx = new System.Windows.Forms.PictureBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.directorNameTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.iNNTextBox1 = new System.Windows.Forms.TextBox();
            this.kPPTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.priorityTextBox1 = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(86, 63);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(77, 21);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адресс:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Location = new System.Drawing.Point(71, 99);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(92, 21);
            directorNameLabel.TabIndex = 3;
            directorNameLabel.Text = "Директор:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(104, 129);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(59, 21);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Почта:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(115, 165);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(48, 21);
            iNNLabel.TabIndex = 7;
            iNNLabel.Text = "ИНН:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Location = new System.Drawing.Point(118, 195);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(45, 21);
            kPPLabel.TabIndex = 9;
            kPPLabel.Text = "КПП:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(75, 228);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(88, 21);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Телефон:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(64, 261);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(99, 21);
            priorityLabel.TabIndex = 13;
            priorityLabel.Text = "Приоритет:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(14, 297);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(149, 21);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Название агента:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(63, 335);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(100, 21);
            titleLabel1.TabIndex = 17;
            titleLabel1.Text = "Тип агента:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveChangeBtn);
            this.groupBox1.Controls.Add(this.titleComboBox1);
            this.groupBox1.Controls.Add(this.changeImgBtn);
            this.groupBox1.Controls.Add(this.changePictureBx);
            this.groupBox1.Controls.Add(this.addressTextBox1);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.directorNameTextBox1);
            this.groupBox1.Controls.Add(titleLabel1);
            this.groupBox1.Controls.Add(titleLabel);
            this.groupBox1.Controls.Add(this.emailTextBox1);
            this.groupBox1.Controls.Add(priorityLabel);
            this.groupBox1.Controls.Add(directorNameLabel);
            this.groupBox1.Controls.Add(this.iNNTextBox1);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.kPPTextBox1);
            this.groupBox1.Controls.Add(kPPLabel);
            this.groupBox1.Controls.Add(iNNLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox1);
            this.groupBox1.Controls.Add(this.titleTextBox1);
            this.groupBox1.Controls.Add(this.priorityTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 720);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // saveChangeBtn
            // 
            this.saveChangeBtn.Location = new System.Drawing.Point(6, 441);
            this.saveChangeBtn.Name = "saveChangeBtn";
            this.saveChangeBtn.Size = new System.Drawing.Size(204, 57);
            this.saveChangeBtn.TabIndex = 20;
            this.saveChangeBtn.Text = "Сохранить";
            this.saveChangeBtn.UseVisualStyleBackColor = true;
            // 
            // titleComboBox1
            // 
            this.titleComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentBindingSource, "AgentTypeID", true));
            this.titleComboBox1.DataSource = this.agentTypeBindingSource;
            this.titleComboBox1.DisplayMember = "Title";
            this.titleComboBox1.FormattingEnabled = true;
            this.titleComboBox1.Location = new System.Drawing.Point(169, 327);
            this.titleComboBox1.Name = "titleComboBox1";
            this.titleComboBox1.Size = new System.Drawing.Size(231, 29);
            this.titleComboBox1.TabIndex = 35;
            this.titleComboBox1.ValueMember = "ID";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(GlazkiSaveNewApp.Models.Agent);
            this.agentBindingSource.CurrentChanged += new System.EventHandler(this.agentBindingSource_CurrentChanged);
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(GlazkiSaveNewApp.Models.AgentType);
            // 
            // changeImgBtn
            // 
            this.changeImgBtn.Location = new System.Drawing.Point(407, 231);
            this.changeImgBtn.Name = "changeImgBtn";
            this.changeImgBtn.Size = new System.Drawing.Size(204, 57);
            this.changeImgBtn.TabIndex = 20;
            this.changeImgBtn.Text = "Изменить";
            this.changeImgBtn.UseVisualStyleBackColor = true;
            // 
            // changePictureBx
            // 
            this.changePictureBx.Image = global::GlazkiSaveNewApp.Properties.Resources.picture;
            this.changePictureBx.Location = new System.Drawing.Point(406, 63);
            this.changePictureBx.Name = "changePictureBx";
            this.changePictureBx.Size = new System.Drawing.Size(205, 153);
            this.changePictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.changePictureBx.TabIndex = 19;
            this.changePictureBx.TabStop = false;
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(169, 63);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(231, 27);
            this.addressTextBox1.TabIndex = 20;
            // 
            // directorNameTextBox1
            // 
            this.directorNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "DirectorName", true));
            this.directorNameTextBox1.Location = new System.Drawing.Point(169, 96);
            this.directorNameTextBox1.Name = "directorNameTextBox1";
            this.directorNameTextBox1.Size = new System.Drawing.Size(231, 27);
            this.directorNameTextBox1.TabIndex = 22;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(169, 129);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(231, 27);
            this.emailTextBox1.TabIndex = 24;
            // 
            // iNNTextBox1
            // 
            this.iNNTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox1.Location = new System.Drawing.Point(169, 162);
            this.iNNTextBox1.Name = "iNNTextBox1";
            this.iNNTextBox1.Size = new System.Drawing.Size(231, 27);
            this.iNNTextBox1.TabIndex = 26;
            // 
            // kPPTextBox1
            // 
            this.kPPTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox1.Location = new System.Drawing.Point(169, 195);
            this.kPPTextBox1.Name = "kPPTextBox1";
            this.kPPTextBox1.Size = new System.Drawing.Size(231, 27);
            this.kPPTextBox1.TabIndex = 28;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(169, 228);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(231, 27);
            this.phoneTextBox1.TabIndex = 30;
            // 
            // titleTextBox1
            // 
            this.titleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox1.Location = new System.Drawing.Point(169, 294);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(231, 27);
            this.titleTextBox1.TabIndex = 34;
            // 
            // priorityTextBox1
            // 
            this.priorityTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox1.Location = new System.Drawing.Point(169, 261);
            this.priorityTextBox1.Name = "priorityTextBox1";
            this.priorityTextBox1.Size = new System.Drawing.Size(231, 27);
            this.priorityTextBox1.TabIndex = 32;
            // 
            // AddEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1188, 732);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddEditForm";
            this.Text = "Форма добавления и редактирования агентов";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePictureBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveChangeBtn;
        private System.Windows.Forms.Button changeImgBtn;
        private System.Windows.Forms.PictureBox changePictureBx;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox directorNameTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox iNNTextBox1;
        private System.Windows.Forms.TextBox kPPTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox priorityTextBox1;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.ComboBox titleComboBox1;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
    }
}