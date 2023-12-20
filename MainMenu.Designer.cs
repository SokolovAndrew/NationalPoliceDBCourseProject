
namespace PoliceDB
{
    partial class MainMenu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnCalling = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.panelLogotipe = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogotipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(286, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(824, 526);
            this.panelDesktop.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.btnDatabase);
            this.panelMenu.Controls.Add(this.btnCalling);
            this.panelMenu.Controls.Add(this.btnEmployees);
            this.panelMenu.Controls.Add(this.btnDepartments);
            this.panelMenu.Controls.Add(this.panelLogotipe);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(286, 526);
            this.panelMenu.TabIndex = 4;
            // 
            // btnDatabase
            // 
            this.btnDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatabase.FlatAppearance.BorderSize = 0;
            this.btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDatabase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDatabase.Image = global::PoliceDB.Properties.Resources.database;
            this.btnDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabase.Location = new System.Drawing.Point(0, 350);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDatabase.Size = new System.Drawing.Size(286, 60);
            this.btnDatabase.TabIndex = 4;
            this.btnDatabase.Text = "   Перегляд БД";
            this.btnDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnCalling
            // 
            this.btnCalling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalling.FlatAppearance.BorderSize = 0;
            this.btnCalling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalling.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalling.Image = global::PoliceDB.Properties.Resources.calling;
            this.btnCalling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalling.Location = new System.Drawing.Point(0, 290);
            this.btnCalling.Name = "btnCalling";
            this.btnCalling.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCalling.Size = new System.Drawing.Size(286, 60);
            this.btnCalling.TabIndex = 3;
            this.btnCalling.Text = "   Виклики";
            this.btnCalling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalling.UseVisualStyleBackColor = true;
            this.btnCalling.Click += new System.EventHandler(this.btnCalling_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmployees.Image = global::PoliceDB.Properties.Resources.policeman;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 230);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(286, 60);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "   Співробітники";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartments.FlatAppearance.BorderSize = 0;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDepartments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDepartments.Image = global::PoliceDB.Properties.Resources.policestation;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(0, 170);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDepartments.Size = new System.Drawing.Size(286, 60);
            this.btnDepartments.TabIndex = 1;
            this.btnDepartments.Text = "   Департаменти";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // panelLogotipe
            // 
            this.panelLogotipe.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLogotipe.Controls.Add(this.pictureLogo);
            this.panelLogotipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogotipe.Location = new System.Drawing.Point(0, 0);
            this.panelLogotipe.Name = "panelLogotipe";
            this.panelLogotipe.Size = new System.Drawing.Size(286, 170);
            this.panelLogotipe.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.ErrorImage")));
            this.pictureLogo.Image = global::PoliceDB.Properties.Resources.logo;
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(286, 170);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 526);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoliceDB";
            this.panelMenu.ResumeLayout(false);
            this.panelLogotipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCalling;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Panel panelLogotipe;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btnDatabase;
    }
}

