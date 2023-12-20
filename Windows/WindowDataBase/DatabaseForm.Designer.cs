
namespace PoliceDB.Windows.WindowDataBase
{
    partial class DatabaseForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.nudValueColumns = new System.Windows.Forms.NumericUpDown();
            this.cbNameTables = new System.Windows.Forms.ComboBox();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dgwTable = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueColumns)).BeginInit();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.nudValueColumns);
            this.panelMenu.Controls.Add(this.cbNameTables);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 100);
            this.panelMenu.TabIndex = 1;
            // 
            // nudValueColumns
            // 
            this.nudValueColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudValueColumns.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudValueColumns.Location = new System.Drawing.Point(415, 70);
            this.nudValueColumns.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudValueColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValueColumns.Name = "nudValueColumns";
            this.nudValueColumns.Size = new System.Drawing.Size(161, 22);
            this.nudValueColumns.TabIndex = 1;
            this.nudValueColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudValueColumns.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudValueColumns.ValueChanged += new System.EventHandler(this.nudValueColumns_ValueChanged);
            this.nudValueColumns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudValueColumns_KeyDown);
            // 
            // cbNameTables
            // 
            this.cbNameTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNameTables.FormattingEnabled = true;
            this.cbNameTables.Location = new System.Drawing.Point(582, 70);
            this.cbNameTables.Name = "cbNameTables";
            this.cbNameTables.Size = new System.Drawing.Size(206, 24);
            this.cbNameTables.TabIndex = 0;
            this.cbNameTables.SelectedIndexChanged += new System.EventHandler(this.cbNameTables_SelectedIndexChanged);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dgwTable);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(0, 100);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(800, 350);
            this.panelTable.TabIndex = 2;
            // 
            // dgwTable
            // 
            this.dgwTable.AllowUserToAddRows = false;
            this.dgwTable.AllowUserToDeleteRows = false;
            this.dgwTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwTable.Location = new System.Drawing.Point(0, 0);
            this.dgwTable.Name = "dgwTable";
            this.dgwTable.ReadOnly = true;
            this.dgwTable.RowHeadersWidth = 51;
            this.dgwTable.RowTemplate.Height = 24;
            this.dgwTable.Size = new System.Drawing.Size(800, 350);
            this.dgwTable.TabIndex = 0;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelMenu);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudValueColumns)).EndInit();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.NumericUpDown nudValueColumns;
        private System.Windows.Forms.ComboBox cbNameTables;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dgwTable;
    }
}