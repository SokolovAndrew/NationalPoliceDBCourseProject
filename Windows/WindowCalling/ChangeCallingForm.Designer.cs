
namespace PoliceDB.Windows.WindowCalling
{
    partial class ChangeCallingForm
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
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.cBStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblCalling = new System.Windows.Forms.Label();
            this.cBCalling = new System.Windows.Forms.ComboBox();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            this.panelDeskTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBStatus, 1, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblStatus, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnInsert, 1, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.lblCalling, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.cBCalling, 1, 0);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 3;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(800, 133);
            this.tableLayoutPanelDeskTop.TabIndex = 1;
            // 
            // cBStatus
            // 
            this.cBStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBStatus.FormattingEnabled = true;
            this.cBStatus.Location = new System.Drawing.Point(243, 33);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.Size = new System.Drawing.Size(554, 24);
            this.cBStatus.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(168, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatus.Size = new System.Drawing.Size(69, 27);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Статус";
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(243, 63);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(554, 67);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Змінити статус виклику";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblCalling
            // 
            this.lblCalling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalling.AutoSize = true;
            this.lblCalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalling.ForeColor = System.Drawing.Color.White;
            this.lblCalling.Location = new System.Drawing.Point(166, 0);
            this.lblCalling.Name = "lblCalling";
            this.lblCalling.Padding = new System.Windows.Forms.Padding(5);
            this.lblCalling.Size = new System.Drawing.Size(71, 27);
            this.lblCalling.TabIndex = 16;
            this.lblCalling.Text = "Виклик";
            // 
            // cBCalling
            // 
            this.cBCalling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBCalling.FormattingEnabled = true;
            this.cBCalling.Location = new System.Drawing.Point(243, 3);
            this.cBCalling.Name = "cBCalling";
            this.cBCalling.Size = new System.Drawing.Size(554, 24);
            this.cBCalling.TabIndex = 17;
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(800, 133);
            this.panelDeskTop.TabIndex = 5;
            // 
            // ChangeCallingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 133);
            this.Controls.Add(this.panelDeskTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 180);
            this.Name = "ChangeCallingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зміна статусу";
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            this.panelDeskTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.ComboBox cBStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblCalling;
        private System.Windows.Forms.ComboBox cBCalling;
        private System.Windows.Forms.Panel panelDeskTop;
    }
}