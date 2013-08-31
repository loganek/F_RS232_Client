namespace F_RS232Client.Plugins.Core.Controls
{
    partial class RS232ConnectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.availablePortsComboBox = new System.Windows.Forms.ComboBox();
            this.rescanPortsButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rxIndicatorGroupBox = new System.Windows.Forms.GroupBox();
            this.txIndicatorGroupBox = new System.Windows.Forms.GroupBox();
            this.rxIndicatorPanel = new System.Windows.Forms.Panel();
            this.txIndicatorPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.rxIndicatorGroupBox.SuspendLayout();
            this.txIndicatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // availablePortsComboBox
            // 
            this.availablePortsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availablePortsComboBox.FormattingEnabled = true;
            this.availablePortsComboBox.Location = new System.Drawing.Point(68, 3);
            this.availablePortsComboBox.Name = "availablePortsComboBox";
            this.availablePortsComboBox.Size = new System.Drawing.Size(77, 21);
            this.availablePortsComboBox.TabIndex = 0;
            // 
            // rescanPortsButton
            // 
            this.rescanPortsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rescanPortsButton.Location = new System.Drawing.Point(151, 3);
            this.rescanPortsButton.Name = "rescanPortsButton";
            this.rescanPortsButton.Size = new System.Drawing.Size(75, 23);
            this.rescanPortsButton.TabIndex = 1;
            this.rescanPortsButton.Text = "Rescan";
            this.rescanPortsButton.UseVisualStyleBackColor = true;
            this.rescanPortsButton.Click += new System.EventHandler(this.rescanPortsButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(7, 191);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(219, 26);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(68, 30);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(158, 21);
            this.baudRateComboBox.TabIndex = 3;
            this.baudRateComboBox.Text = "9600";
            // 
            // parityComboBox
            // 
            this.parityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "none",
            "odd",
            "even",
            "mark",
            "space"});
            this.parityComboBox.Location = new System.Drawing.Point(68, 61);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(158, 21);
            this.parityComboBox.TabIndex = 4;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(68, 88);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(158, 21);
            this.dataBitsComboBox.TabIndex = 5;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "1,5",
            "2"});
            this.stopBitsComboBox.Location = new System.Drawing.Point(68, 115);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(158, 21);
            this.stopBitsComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baud rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stop bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port name:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rxIndicatorGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txIndicatorGroupBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 43);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // rxIndicatorGroupBox
            // 
            this.rxIndicatorGroupBox.Controls.Add(this.rxIndicatorPanel);
            this.rxIndicatorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rxIndicatorGroupBox.Location = new System.Drawing.Point(3, 3);
            this.rxIndicatorGroupBox.Name = "rxIndicatorGroupBox";
            this.rxIndicatorGroupBox.Size = new System.Drawing.Size(103, 37);
            this.rxIndicatorGroupBox.TabIndex = 0;
            this.rxIndicatorGroupBox.TabStop = false;
            this.rxIndicatorGroupBox.Text = "RX Indicator";
            // 
            // txIndicatorGroupBox
            // 
            this.txIndicatorGroupBox.Controls.Add(this.txIndicatorPanel);
            this.txIndicatorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txIndicatorGroupBox.Location = new System.Drawing.Point(112, 3);
            this.txIndicatorGroupBox.Name = "txIndicatorGroupBox";
            this.txIndicatorGroupBox.Size = new System.Drawing.Size(104, 37);
            this.txIndicatorGroupBox.TabIndex = 1;
            this.txIndicatorGroupBox.TabStop = false;
            this.txIndicatorGroupBox.Text = "TX Indicator";
            // 
            // rxIndicatorPanel
            // 
            this.rxIndicatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rxIndicatorPanel.Location = new System.Drawing.Point(3, 16);
            this.rxIndicatorPanel.Name = "rxIndicatorPanel";
            this.rxIndicatorPanel.Size = new System.Drawing.Size(97, 18);
            this.rxIndicatorPanel.TabIndex = 0;
            // 
            // txIndicatorPanel
            // 
            this.txIndicatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txIndicatorPanel.Location = new System.Drawing.Point(3, 16);
            this.txIndicatorPanel.Name = "txIndicatorPanel";
            this.txIndicatorPanel.Size = new System.Drawing.Size(98, 18);
            this.txIndicatorPanel.TabIndex = 0;
            // 
            // RS232ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBitsComboBox);
            this.Controls.Add(this.dataBitsComboBox);
            this.Controls.Add(this.parityComboBox);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rescanPortsButton);
            this.Controls.Add(this.availablePortsComboBox);
            this.Name = "RS232ConnectionControl";
            this.Size = new System.Drawing.Size(229, 223);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.rxIndicatorGroupBox.ResumeLayout(false);
            this.txIndicatorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox availablePortsComboBox;
        private System.Windows.Forms.Button rescanPortsButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox rxIndicatorGroupBox;
        private System.Windows.Forms.GroupBox txIndicatorGroupBox;
        private System.Windows.Forms.Panel rxIndicatorPanel;
        private System.Windows.Forms.Panel txIndicatorPanel;
    }
}
