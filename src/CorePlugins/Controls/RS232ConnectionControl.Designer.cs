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
            this.SuspendLayout();
            // 
            // availablePortsComboBox
            // 
            this.availablePortsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePortsComboBox.FormattingEnabled = true;
            this.availablePortsComboBox.Location = new System.Drawing.Point(3, 3);
            this.availablePortsComboBox.Name = "availablePortsComboBox";
            this.availablePortsComboBox.Size = new System.Drawing.Size(144, 21);
            this.availablePortsComboBox.TabIndex = 0;
            // 
            // rescanPortsButton
            // 
            this.rescanPortsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rescanPortsButton.Location = new System.Drawing.Point(153, 3);
            this.rescanPortsButton.Name = "rescanPortsButton";
            this.rescanPortsButton.Size = new System.Drawing.Size(75, 23);
            this.rescanPortsButton.TabIndex = 1;
            this.rescanPortsButton.Text = "Rescan";
            this.rescanPortsButton.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(3, 30);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // RS232ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rescanPortsButton);
            this.Controls.Add(this.availablePortsComboBox);
            this.Name = "RS232ConnectionControl";
            this.Size = new System.Drawing.Size(231, 216);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox availablePortsComboBox;
        private System.Windows.Forms.Button rescanPortsButton;
        private System.Windows.Forms.Button connectButton;
    }
}
