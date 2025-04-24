namespace ST01_3_1107_Popescu_Romeo
{
    partial class AddTruckForm
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
            this.truckIdNum = new System.Windows.Forms.NumericUpDown();
            this.truckLicenceTV = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveTruckBtn = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.truckIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // truckIdNum
            // 
            this.truckIdNum.Location = new System.Drawing.Point(270, 137);
            this.truckIdNum.Name = "truckIdNum";
            this.truckIdNum.Size = new System.Drawing.Size(120, 20);
            this.truckIdNum.TabIndex = 0;
            this.truckIdNum.Validating += new System.ComponentModel.CancelEventHandler(this.truckIdNum_Validating);
            // 
            // truckLicenceTV
            // 
            this.truckLicenceTV.Location = new System.Drawing.Point(270, 197);
            this.truckLicenceTV.Name = "truckLicenceTV";
            this.truckLicenceTV.Size = new System.Drawing.Size(100, 20);
            this.truckLicenceTV.TabIndex = 1;
            this.truckLicenceTV.Validating += new System.ComponentModel.CancelEventHandler(this.truckLicenceTV_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Truck id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Licence Plate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registration Date";
            // 
            // saveTruckBtn
            // 
            this.saveTruckBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveTruckBtn.Location = new System.Drawing.Point(273, 311);
            this.saveTruckBtn.Name = "saveTruckBtn";
            this.saveTruckBtn.Size = new System.Drawing.Size(75, 23);
            this.saveTruckBtn.TabIndex = 6;
            this.saveTruckBtn.Text = "Save Truck";
            this.saveTruckBtn.UseVisualStyleBackColor = true;
            this.saveTruckBtn.Click += new System.EventHandler(this.saveTruckBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(472, 311);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddTruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveTruckBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.truckLicenceTV);
            this.Controls.Add(this.truckIdNum);
            this.Name = "AddTruckForm";
            this.Text = "AddTruckForm";
            this.Load += new System.EventHandler(this.AddTruckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truckIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown truckIdNum;
        private System.Windows.Forms.TextBox truckLicenceTV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveTruckBtn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}