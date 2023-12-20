
namespace PoliceDB.Windows.WindowEmployees
{
    partial class ChangeEmployeesForm
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.cBDepartment = new System.Windows.Forms.ComboBox();
            this.cBProfession = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.cBEmployees = new System.Windows.Forms.ComboBox();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(243, 93);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(554, 59);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Додати співробітника";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(800, 155);
            this.panelDeskTop.TabIndex = 4;
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBDepartment, 1, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBProfession, 1, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblDepartment, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblProfession, 0, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnInsert, 1, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblEmployees, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBEmployees, 1, 0);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 4;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(800, 155);
            this.tableLayoutPanelDeskTop.TabIndex = 1;
            // 
            // cBDepartment
            // 
            this.cBDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBDepartment.FormattingEnabled = true;
            this.cBDepartment.Location = new System.Drawing.Point(243, 33);
            this.cBDepartment.Name = "cBDepartment";
            this.cBDepartment.Size = new System.Drawing.Size(554, 24);
            this.cBDepartment.TabIndex = 15;
            // 
            // cBProfession
            // 
            this.cBProfession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBProfession.FormattingEnabled = true;
            this.cBProfession.Location = new System.Drawing.Point(243, 63);
            this.cBProfession.Name = "cBProfession";
            this.cBProfession.Size = new System.Drawing.Size(554, 24);
            this.cBProfession.TabIndex = 6;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(118, 30);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Padding = new System.Windows.Forms.Padding(5);
            this.lblDepartment.Size = new System.Drawing.Size(119, 27);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Департамент";
            // 
            // lblProfession
            // 
            this.lblProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfession.AutoSize = true;
            this.lblProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfession.ForeColor = System.Drawing.Color.White;
            this.lblProfession.Location = new System.Drawing.Point(148, 60);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Padding = new System.Windows.Forms.Padding(5);
            this.lblProfession.Size = new System.Drawing.Size(89, 27);
            this.lblProfession.TabIndex = 0;
            this.lblProfession.Text = "Професія";
            // 
            // lblEmployees
            // 
            this.lblEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployees.ForeColor = System.Drawing.Color.White;
            this.lblEmployees.Location = new System.Drawing.Point(123, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Padding = new System.Windows.Forms.Padding(5);
            this.lblEmployees.Size = new System.Drawing.Size(114, 27);
            this.lblEmployees.TabIndex = 16;
            this.lblEmployees.Text = "Співробітник";
            // 
            // cBEmployees
            // 
            this.cBEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBEmployees.FormattingEnabled = true;
            this.cBEmployees.Location = new System.Drawing.Point(243, 3);
            this.cBEmployees.Name = "cBEmployees";
            this.cBEmployees.Size = new System.Drawing.Size(554, 24);
            this.cBEmployees.TabIndex = 17;
            // 
            // ChangeEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 155);
            this.Controls.Add(this.panelDeskTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 202);
            this.Name = "ChangeEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зміна досьє сотрудника";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.ComboBox cBDepartment;
        private System.Windows.Forms.ComboBox cBProfession;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ComboBox cBEmployees;
    }
}