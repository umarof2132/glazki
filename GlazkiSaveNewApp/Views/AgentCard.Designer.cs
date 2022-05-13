namespace GlazkiSaveNewApp.Views
{
    partial class AgentCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeNameLbl = new System.Windows.Forms.Label();
            this.percentLbl = new System.Windows.Forms.Label();
            this.qtySalesLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // typeNameLbl
            // 
            this.typeNameLbl.AutoSize = true;
            this.typeNameLbl.Location = new System.Drawing.Point(246, 33);
            this.typeNameLbl.Name = "typeNameLbl";
            this.typeNameLbl.Size = new System.Drawing.Size(279, 22);
            this.typeNameLbl.TabIndex = 0;
            this.typeNameLbl.Text = "Тип | Наименование агента";
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentLbl.Location = new System.Drawing.Point(1012, 22);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(66, 33);
            this.percentLbl.TabIndex = 1;
            this.percentLbl.Text = "10%";
            // 
            // qtySalesLbl
            // 
            this.qtySalesLbl.AutoSize = true;
            this.qtySalesLbl.Location = new System.Drawing.Point(246, 67);
            this.qtySalesLbl.Name = "qtySalesLbl";
            this.qtySalesLbl.Size = new System.Drawing.Size(175, 22);
            this.qtySalesLbl.TabIndex = 2;
            this.qtySalesLbl.Text = "10 продаж за год";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(250, 107);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(162, 22);
            this.phoneLbl.TabIndex = 3;
            this.phoneLbl.Text = "+7 111 111 11 11";
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Location = new System.Drawing.Point(250, 147);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(203, 22);
            this.priorityLbl.TabIndex = 4;
            this.priorityLbl.Text = "Приоритетновсть: 10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlazkiSaveNewApp.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AgentCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.qtySalesLbl);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.typeNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(1137, 195);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label typeNameLbl;
        private System.Windows.Forms.Label percentLbl;
        private System.Windows.Forms.Label qtySalesLbl;
        public System.Windows.Forms.Label priorityLbl;
        public System.Windows.Forms.Label phoneLbl;
    }
}
