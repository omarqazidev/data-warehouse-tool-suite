namespace Creator_Fabricator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxDBFabConString = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDBCreation = new System.Windows.Forms.TextBox();
            this.textBoxDBFabrication = new System.Windows.Forms.TextBox();
            this.textBoxDWCreation = new System.Windows.Forms.TextBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDWName = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDBConString = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDWConString = new System.Windows.Forms.TextBox();
            this.form1ContextManuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.dROPDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxDBConString = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxDBName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDBDropBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.dROPDatawarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxDWConString = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxDWName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDWDropBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ContextManuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(308, 437);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(136, 23);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Exit";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // textBoxDBFabConString
            // 
            this.textBoxDBFabConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDBFabConString.Location = new System.Drawing.Point(260, 387);
            this.textBoxDBFabConString.Name = "textBoxDBFabConString";
            this.textBoxDBFabConString.Size = new System.Drawing.Size(242, 20);
            this.textBoxDBFabConString.TabIndex = 1;
            this.textBoxDBFabConString.Text = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=school_db_101;Integrated Security" +
    "=True";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(256, 365);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(129, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Connection String";
            // 
            // textBoxDBCreation
            // 
            this.textBoxDBCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDBCreation.Location = new System.Drawing.Point(12, 78);
            this.textBoxDBCreation.Multiline = true;
            this.textBoxDBCreation.Name = "textBoxDBCreation";
            this.textBoxDBCreation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDBCreation.Size = new System.Drawing.Size(242, 249);
            this.textBoxDBCreation.TabIndex = 3;
            this.textBoxDBCreation.Text = resources.GetString("textBoxDBCreation.Text");
            this.textBoxDBCreation.WordWrap = false;
            // 
            // textBoxDBFabrication
            // 
            this.textBoxDBFabrication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDBFabrication.Location = new System.Drawing.Point(260, 78);
            this.textBoxDBFabrication.Multiline = true;
            this.textBoxDBFabrication.Name = "textBoxDBFabrication";
            this.textBoxDBFabrication.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDBFabrication.Size = new System.Drawing.Size(242, 249);
            this.textBoxDBFabrication.TabIndex = 4;
            this.textBoxDBFabrication.Text = resources.GetString("textBoxDBFabrication.Text");
            this.textBoxDBFabrication.WordWrap = false;
            // 
            // textBoxDWCreation
            // 
            this.textBoxDWCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDWCreation.Location = new System.Drawing.Point(508, 78);
            this.textBoxDWCreation.Multiline = true;
            this.textBoxDWCreation.Name = "textBoxDWCreation";
            this.textBoxDWCreation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDWCreation.Size = new System.Drawing.Size(242, 249);
            this.textBoxDWCreation.TabIndex = 5;
            this.textBoxDWCreation.Text = resources.GetString("textBoxDWCreation.Text");
            this.textBoxDWCreation.WordWrap = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(12, 333);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(242, 23);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "Create Database";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(260, 333);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(242, 23);
            this.materialRaisedButton3.TabIndex = 7;
            this.materialRaisedButton3.Text = "Fabricate Database";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(508, 333);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(242, 23);
            this.materialRaisedButton4.TabIndex = 8;
            this.materialRaisedButton4.Text = "Create Data Warehouse";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 365);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(116, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Database Name";
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDBName.Location = new System.Drawing.Point(12, 387);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(242, 20);
            this.textBoxDBName.TabIndex = 9;
            this.textBoxDBName.Text = "school_db_101";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(507, 365);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(163, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Data Warehouse Name";
            // 
            // textBoxDWName
            // 
            this.textBoxDWName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDWName.Location = new System.Drawing.Point(511, 387);
            this.textBoxDWName.Name = "textBoxDWName";
            this.textBoxDWName.Size = new System.Drawing.Size(242, 20);
            this.textBoxDWName.TabIndex = 11;
            this.textBoxDWName.Text = "school_dw_101";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 419);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(129, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Connection String";
            // 
            // textBoxDBConString
            // 
            this.textBoxDBConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDBConString.Location = new System.Drawing.Point(12, 441);
            this.textBoxDBConString.Name = "textBoxDBConString";
            this.textBoxDBConString.Size = new System.Drawing.Size(242, 20);
            this.textBoxDBConString.TabIndex = 13;
            this.textBoxDBConString.Text = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(507, 417);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(129, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Connection String";
            // 
            // textBoxDWConString
            // 
            this.textBoxDWConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxDWConString.Location = new System.Drawing.Point(511, 439);
            this.textBoxDWConString.Name = "textBoxDWConString";
            this.textBoxDWConString.Size = new System.Drawing.Size(242, 20);
            this.textBoxDWConString.TabIndex = 15;
            this.textBoxDWConString.Text = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            // 
            // form1ContextManuStrip
            // 
            this.form1ContextManuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.form1ContextManuStrip.Depth = 0;
            this.form1ContextManuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dROPDatabaseToolStripMenuItem,
            this.dROPDatawarehouseToolStripMenuItem});
            this.form1ContextManuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.form1ContextManuStrip.Name = "form1ContextManuStrip";
            this.form1ContextManuStrip.Size = new System.Drawing.Size(190, 48);
            // 
            // dROPDatabaseToolStripMenuItem
            // 
            this.dROPDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxDBConString,
            this.toolStripTextBoxDBName,
            this.toolStripSeparator1,
            this.toolStripMenuItemDBDropBtn});
            this.dROPDatabaseToolStripMenuItem.Name = "dROPDatabaseToolStripMenuItem";
            this.dROPDatabaseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dROPDatabaseToolStripMenuItem.Text = "DROP Database";
            this.dROPDatabaseToolStripMenuItem.Click += new System.EventHandler(this.DROPDatabaseToolStripMenuItem_Click);
            // 
            // toolStripTextBoxDBConString
            // 
            this.toolStripTextBoxDBConString.Name = "toolStripTextBoxDBConString";
            this.toolStripTextBoxDBConString.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxDBConString.Text = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            // 
            // toolStripTextBoxDBName
            // 
            this.toolStripTextBoxDBName.Name = "toolStripTextBoxDBName";
            this.toolStripTextBoxDBName.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxDBName.Text = "school_db_101";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItemDBDropBtn
            // 
            this.toolStripMenuItemDBDropBtn.Name = "toolStripMenuItemDBDropBtn";
            this.toolStripMenuItemDBDropBtn.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemDBDropBtn.Text = "DROP IT";
            this.toolStripMenuItemDBDropBtn.Click += new System.EventHandler(this.DROPITToolStripMenuItem_Click);
            // 
            // dROPDatawarehouseToolStripMenuItem
            // 
            this.dROPDatawarehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxDWConString,
            this.toolStripTextBoxDWName,
            this.toolStripSeparator2,
            this.toolStripMenuItemDWDropBtn});
            this.dROPDatawarehouseToolStripMenuItem.Name = "dROPDatawarehouseToolStripMenuItem";
            this.dROPDatawarehouseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dROPDatawarehouseToolStripMenuItem.Text = "DROP Datawarehouse";
            // 
            // toolStripTextBoxDWConString
            // 
            this.toolStripTextBoxDWConString.Name = "toolStripTextBoxDWConString";
            this.toolStripTextBoxDWConString.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxDWConString.Text = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            // 
            // toolStripTextBoxDWName
            // 
            this.toolStripTextBoxDWName.Name = "toolStripTextBoxDWName";
            this.toolStripTextBoxDWName.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxDWName.Text = "school_dw_101";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItemDWDropBtn
            // 
            this.toolStripMenuItemDWDropBtn.Name = "toolStripMenuItemDWDropBtn";
            this.toolStripMenuItemDWDropBtn.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemDWDropBtn.Text = "DROP IT";
            this.toolStripMenuItemDWDropBtn.Click += new System.EventHandler(this.ToolStripMenuItemDWDropBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 475);
            this.ContextMenuStrip = this.form1ContextManuStrip;
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.textBoxDWConString);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.textBoxDBConString);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxDWName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxDBName);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.textBoxDWCreation);
            this.Controls.Add(this.textBoxDBFabrication);
            this.Controls.Add(this.textBoxDBCreation);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxDBFabConString);
            this.Controls.Add(this.materialRaisedButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Create - Fabricate - Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form1ContextManuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.TextBox textBoxDBFabConString;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBoxDBCreation;
        private System.Windows.Forms.TextBox textBoxDBFabrication;
        private System.Windows.Forms.TextBox textBoxDWCreation;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox textBoxDBName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox textBoxDWName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox textBoxDBConString;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox textBoxDWConString;
        private MaterialSkin.Controls.MaterialContextMenuStrip form1ContextManuStrip;
        private System.Windows.Forms.ToolStripMenuItem dROPDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDBConString;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDBDropBtn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDBName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dROPDatawarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDWConString;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDWName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDWDropBtn;
    }
}

