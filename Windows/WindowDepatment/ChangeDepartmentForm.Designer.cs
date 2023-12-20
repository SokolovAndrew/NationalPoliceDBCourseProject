
namespace PoliceDB.Windows.WindowDepatment
{
    partial class ChangeDepartmentForm
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
            this.cBCity = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.cBDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tBStreet = new System.Windows.Forms.TextBox();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBCity
            // 
            this.cBCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBCity.FormattingEnabled = true;
            this.cBCity.Location = new System.Drawing.Point(243, 89);
            this.cBCity.Name = "cBCity";
            this.cBCity.Size = new System.Drawing.Size(554, 24);
            this.cBCity.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(63, 30);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(5);
            this.lblName.Size = new System.Drawing.Size(174, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Назва департаменту";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStreet.ForeColor = System.Drawing.Color.White;
            this.lblStreet.Location = new System.Drawing.Point(165, 58);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Padding = new System.Windows.Forms.Padding(5);
            this.lblStreet.Size = new System.Drawing.Size(72, 27);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Вулиця";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(178, 86);
            this.lblCity.Name = "lblCity";
            this.lblCity.Padding = new System.Windows.Forms.Padding(5);
            this.lblCity.Size = new System.Drawing.Size(59, 27);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Місто";
            // 
            // tBName
            // 
            this.tBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBName.Location = new System.Drawing.Point(243, 33);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(554, 22);
            this.tBName.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(243, 119);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(554, 62);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Змінити департамент";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(800, 184);
            this.panelDeskTop.TabIndex = 2;
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBDepartment, 1, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblDepartment, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBCity, 1, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblStreet, 0, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblCity, 0, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.tBName, 1, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnInsert, 1, 4);
            this.tableLayoutPanelDeskTop.Controls.Add(this.tBStreet, 1, 2);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 5;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(800, 184);
            this.tableLayoutPanelDeskTop.TabIndex = 0;
            // 
            // cBDepartment
            // 
            this.cBDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBDepartment.FormattingEnabled = true;
            this.cBDepartment.Location = new System.Drawing.Point(243, 3);
            this.cBDepartment.Name = "cBDepartment";
            this.cBDepartment.Size = new System.Drawing.Size(554, 24);
            this.cBDepartment.TabIndex = 10;
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
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Департамент";
            // 
            // tBStreet
            // 
            this.tBStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBStreet.Location = new System.Drawing.Point(243, 61);
            this.tBStreet.Name = "tBStreet";
            this.tBStreet.Size = new System.Drawing.Size(554, 22);
            this.tBStreet.TabIndex = 8;
            // 
            // ChangeDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 184);
            this.Controls.Add(this.panelDeskTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 231);
            this.Name = "ChangeDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зміна департаменту";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.TextBox tBStreet;
        private System.Windows.Forms.ComboBox cBDepartment;
        private System.Windows.Forms.Label lblDepartment;
    }
}