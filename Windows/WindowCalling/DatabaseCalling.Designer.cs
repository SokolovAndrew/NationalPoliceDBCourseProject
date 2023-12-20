
namespace PoliceDB.Windows.WindowCalling
{
    partial class DatabaseCalling
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.nudValueColumns = new System.Windows.Forms.NumericUpDown();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dgwTable = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueColumns)).BeginInit();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.tBSearch);
            this.panelMenu.Controls.Add(this.panelButton);
            this.panelMenu.Controls.Add(this.nudValueColumns);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 134);
            this.panelMenu.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(717, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearch.Location = new System.Drawing.Point(549, 12);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(239, 22);
            this.tBSearch.TabIndex = 4;
            this.tBSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBSearch_KeyDown);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnChange);
            this.panelButton.Controls.Add(this.btnInsert);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(278, 134);
            this.panelButton.TabIndex = 3;
            // 
            // nudValueColumns
            // 
            this.nudValueColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudValueColumns.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudValueColumns.Location = new System.Drawing.Point(627, 106);
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
            this.nudValueColumns.TabIndex = 2;
            this.nudValueColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudValueColumns.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudValueColumns.ValueChanged += new System.EventHandler(this.nudValueColumns_ValueChanged);
            this.nudValueColumns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudValueColumns_KeyDown);
            // 
            // btnChange
            // 
            this.btnChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Image = global::PoliceDB.Properties.Resources.update;
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.Location = new System.Drawing.Point(0, 60);
            this.btnChange.Name = "btnChange";
            this.btnChange.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnChange.Size = new System.Drawing.Size(278, 60);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "   Редагування";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Image = global::PoliceDB.Properties.Resources.add;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(278, 60);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "   Додавання";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dgwTable);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(0, 134);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(800, 316);
            this.panelTable.TabIndex = 5;
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
            this.dgwTable.Size = new System.Drawing.Size(800, 316);
            this.dgwTable.TabIndex = 0;
            // 
            // DatabaseCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelMenu);
            this.Name = "DatabaseCalling";
            this.Text = "DatabaseCalling";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudValueColumns)).EndInit();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.NumericUpDown nudValueColumns;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dgwTable;
    }
}