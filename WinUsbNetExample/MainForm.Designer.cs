namespace WinUsbNetExample
{
    partial class MainForm
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
            this.loadUsbBtn = new System.Windows.Forms.Button();
            this.usbDeviceListGridView = new System.Windows.Forms.DataGridView();
            this.vIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSBDeviceInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deviceCountLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usbDeviceListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSBDeviceInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loadUsbBtn
            // 
            this.loadUsbBtn.Location = new System.Drawing.Point(12, 292);
            this.loadUsbBtn.Name = "loadUsbBtn";
            this.loadUsbBtn.Size = new System.Drawing.Size(75, 23);
            this.loadUsbBtn.TabIndex = 1;
            this.loadUsbBtn.Text = "Load USB";
            this.loadUsbBtn.UseVisualStyleBackColor = true;
            this.loadUsbBtn.Click += new System.EventHandler(this.loadUsbBtn_Click);
            // 
            // usbDeviceListGridView
            // 
            this.usbDeviceListGridView.AutoGenerateColumns = false;
            this.usbDeviceListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usbDeviceListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vIDDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.deviceDescriptionDataGridViewTextBoxColumn,
            this.devicePathDataGridViewTextBoxColumn});
            this.usbDeviceListGridView.DataSource = this.uSBDeviceInfoBindingSource;
            this.usbDeviceListGridView.Location = new System.Drawing.Point(13, 31);
            this.usbDeviceListGridView.Name = "usbDeviceListGridView";
            this.usbDeviceListGridView.Size = new System.Drawing.Size(679, 255);
            this.usbDeviceListGridView.TabIndex = 2;
            // 
            // vIDDataGridViewTextBoxColumn
            // 
            this.vIDDataGridViewTextBoxColumn.DataPropertyName = "VID";
            this.vIDDataGridViewTextBoxColumn.HeaderText = "VID";
            this.vIDDataGridViewTextBoxColumn.Name = "vIDDataGridViewTextBoxColumn";
            this.vIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceDescriptionDataGridViewTextBoxColumn
            // 
            this.deviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DeviceDescription";
            this.deviceDescriptionDataGridViewTextBoxColumn.HeaderText = "DeviceDescription";
            this.deviceDescriptionDataGridViewTextBoxColumn.Name = "deviceDescriptionDataGridViewTextBoxColumn";
            this.deviceDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devicePathDataGridViewTextBoxColumn
            // 
            this.devicePathDataGridViewTextBoxColumn.DataPropertyName = "DevicePath";
            this.devicePathDataGridViewTextBoxColumn.HeaderText = "DevicePath";
            this.devicePathDataGridViewTextBoxColumn.Name = "devicePathDataGridViewTextBoxColumn";
            this.devicePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSBDeviceInfoBindingSource
            // 
            this.uSBDeviceInfoBindingSource.DataSource = typeof(MadWizard.WinUSBNet.USBDeviceInfo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Device:";
            // 
            // deviceCountLbl
            // 
            this.deviceCountLbl.AutoSize = true;
            this.deviceCountLbl.Location = new System.Drawing.Point(516, 297);
            this.deviceCountLbl.Name = "deviceCountLbl";
            this.deviceCountLbl.Size = new System.Drawing.Size(13, 13);
            this.deviceCountLbl.TabIndex = 3;
            this.deviceCountLbl.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 327);
            this.Controls.Add(this.deviceCountLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usbDeviceListGridView);
            this.Controls.Add(this.loadUsbBtn);
            this.Name = "MainForm";
            this.Text = "WinUSB.Sys USB Device List";
            ((System.ComponentModel.ISupportInitialize)(this.usbDeviceListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSBDeviceInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadUsbBtn;
        private System.Windows.Forms.DataGridView usbDeviceListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uSBDeviceInfoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deviceCountLbl;
    }
}

