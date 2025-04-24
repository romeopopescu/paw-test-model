namespace ST01_3_1107_Popescu_Romeo
{
    partial class Form1
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
            this.addTruck = new System.Windows.Forms.Button();
            this.lvTrucks = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLicensePlateNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegistrationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTruck
            // 
            this.addTruck.Location = new System.Drawing.Point(324, 378);
            this.addTruck.Name = "addTruck";
            this.addTruck.Size = new System.Drawing.Size(75, 23);
            this.addTruck.TabIndex = 0;
            this.addTruck.Text = "Add Truck";
            this.addTruck.UseVisualStyleBackColor = true;
            this.addTruck.Click += new System.EventHandler(this.addTruck_Click);
            // 
            // lvTrucks
            // 
            this.lvTrucks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colLicensePlateNumber,
            this.colRegistrationDate});
            this.lvTrucks.FullRowSelect = true;
            this.lvTrucks.HideSelection = false;
            this.lvTrucks.Location = new System.Drawing.Point(63, 61);
            this.lvTrucks.Name = "lvTrucks";
            this.lvTrucks.Size = new System.Drawing.Size(588, 311);
            this.lvTrucks.TabIndex = 1;
            this.lvTrucks.UseCompatibleStateImageBehavior = false;
            this.lvTrucks.View = System.Windows.Forms.View.Details;
            this.lvTrucks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTrucks_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 126;
            // 
            // colLicensePlateNumber
            // 
            this.colLicensePlateNumber.Text = "LicensePlateNumber";
            this.colLicensePlateNumber.Width = 215;
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.Text = "RegistrationDate";
            this.colRegistrationDate.Width = 242;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(130, 48);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem1,
            this.deserializeToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(181, 70);
            // 
            // serializeToolStripMenuItem1
            // 
            this.serializeToolStripMenuItem1.Name = "serializeToolStripMenuItem1";
            this.serializeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.serializeToolStripMenuItem1.Text = "Serialize";
            this.serializeToolStripMenuItem1.Click += new System.EventHandler(this.serializeToolStripMenuItem1_Click);
            // 
            // deserializeToolStripMenuItem1
            // 
            this.deserializeToolStripMenuItem1.Name = "deserializeToolStripMenuItem1";
            this.deserializeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deserializeToolStripMenuItem1.Text = "Deserialize";
            this.deserializeToolStripMenuItem1.Click += new System.EventHandler(this.deserializeToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip3;
            this.Controls.Add(this.lvTrucks);
            this.Controls.Add(this.addTruck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTruck;
        private System.Windows.Forms.ListView lvTrucks;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colLicensePlateNumber;
        private System.Windows.Forms.ColumnHeader colRegistrationDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem1;
    }
}

