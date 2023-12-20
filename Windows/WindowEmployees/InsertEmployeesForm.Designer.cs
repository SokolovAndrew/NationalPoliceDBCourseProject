
namespace PoliceDB.Windows.WindowEmployees
{
    partial class InsertEmployeesForm
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
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.cBDepartment = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cBProfession = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.cBGender = new System.Windows.Forms.ComboBox();
            this.cBWeapon = new System.Windows.Forms.ComboBox();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(800, 213);
            this.panelDeskTop.TabIndex = 3;
            this.panelDeskTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDeskTop_Paint);
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBDepartment, 1, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblGender, 0, 4);
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBProfession, 1, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblDepartment, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblProfession, 0, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnInsert, 1, 5);
            this.tableLayoutPanelDeskTop.Controls.Add(this.tBName, 1, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBGender, 1, 4);
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBWeapon, 1, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblWeapon, 0, 3);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 6;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(800, 213);
            this.tableLayoutPanelDeskTop.TabIndex = 1;
            this.tableLayoutPanelDeskTop.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelDeskTop_Paint);
            // 
            // cBDepartment
            // 
            this.cBDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBDepartment.FormattingEnabled = true;
            this.cBDepartment.Location = new System.Drawing.Point(243, 3);
            this.cBDepartment.Name = "cBDepartment";
            this.cBDepartment.Size = new System.Drawing.Size(554, 24);
            this.cBDepartment.TabIndex = 15;
            this.cBDepartment.SelectedIndexChanged += new System.EventHandler(this.cBDepartment_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(190, 118);
            this.lblGender.Name = "lblGender";
            this.lblGender.Padding = new System.Windows.Forms.Padding(5);
            this.lblGender.Size = new System.Drawing.Size(47, 27);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Пол";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // cBProfession
            // 
            this.cBProfession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBProfession.FormattingEnabled = true;
            this.cBProfession.Location = new System.Drawing.Point(243, 61);
            this.cBProfession.Name = "cBProfession";
            this.cBProfession.Size = new System.Drawing.Size(554, 24);
            this.cBProfession.TabIndex = 6;
            this.cBProfession.SelectedIndexChanged += new System.EventHandler(this.cBProfession_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(118, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Padding = new System.Windows.Forms.Padding(5);
            this.lblDepartment.Size = new System.Drawing.Size(119, 27);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Департамент";
            this.lblDepartment.Click += new System.EventHandler(this.lblDepartment_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(189, 30);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(5);
            this.lblName.Size = new System.Drawing.Size(48, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ФІО";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblProfession
            // 
            this.lblProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfession.AutoSize = true;
            this.lblProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfession.ForeColor = System.Drawing.Color.White;
            this.lblProfession.Location = new System.Drawing.Point(148, 58);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Padding = new System.Windows.Forms.Padding(5);
            this.lblProfession.Size = new System.Drawing.Size(89, 27);
            this.lblProfession.TabIndex = 0;
            this.lblProfession.Text = "Професія";
            this.lblProfession.Click += new System.EventHandler(this.lblProfession_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(243, 151);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(554, 59);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Додати співробітника";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tBName
            // 
            this.tBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBName.Location = new System.Drawing.Point(243, 33);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(554, 22);
            this.tBName.TabIndex = 8;
            this.tBName.TextChanged += new System.EventHandler(this.tBName_TextChanged);
            // 
            // cBGender
            // 
            this.cBGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBGender.FormattingEnabled = true;
            this.cBGender.Location = new System.Drawing.Point(243, 121);
            this.cBGender.Name = "cBGender";
            this.cBGender.Size = new System.Drawing.Size(554, 24);
            this.cBGender.TabIndex = 10;
            this.cBGender.SelectedIndexChanged += new System.EventHandler(this.cBGender_SelectedIndexChanged);
            // 
            // cBWeapon
            // 
            this.cBWeapon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBWeapon.FormattingEnabled = true;
            this.cBWeapon.Location = new System.Drawing.Point(243, 91);
            this.cBWeapon.Name = "cBWeapon";
            this.cBWeapon.Size = new System.Drawing.Size(554, 24);
            this.cBWeapon.TabIndex = 12;
            this.cBWeapon.SelectedIndexChanged += new System.EventHandler(this.cBWeapon_SelectedIndexChanged);
            // 
            // lblWeapon
            // 
            this.lblWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeapon.ForeColor = System.Drawing.Color.White;
            this.lblWeapon.Location = new System.Drawing.Point(98, 88);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Padding = new System.Windows.Forms.Padding(5);
            this.lblWeapon.Size = new System.Drawing.Size(139, 27);
            this.lblWeapon.TabIndex = 13;
            this.lblWeapon.Text = "Табельна зброя";
            this.lblWeapon.Click += new System.EventHandler(this.lblWeapon_Click);
            // 
            // InsertEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.panelDeskTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 260);
            this.Name = "InsertEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вставка нового сотрудника";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.ComboBox cBDepartment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cBProfession;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.ComboBox cBGender;
        private System.Windows.Forms.ComboBox cBWeapon;
        private System.Windows.Forms.Label lblWeapon;
    }
}