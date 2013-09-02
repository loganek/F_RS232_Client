namespace F_RS232Client.Plugins.Core.Controls
{
    partial class BaseWriterControl
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
            this.components = new System.ComponentModel.Container();
            this.sentDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.startStopCSButton = new System.Windows.Forms.Button();
            this.octDMRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.hexDMRadioButton = new System.Windows.Forms.RadioButton();
            this.intervalCSTextBox = new System.Windows.Forms.TextBox();
            this.circularSendingGroupBox = new System.Windows.Forms.GroupBox();
            this.decDMRadioButton = new System.Windows.Forms.RadioButton();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.asciiDMRadioButton = new System.Windows.Forms.RadioButton();
            this.displayModeGroupBox = new System.Windows.Forms.GroupBox();
            this.dataToSendTextBox = new System.Windows.Forms.TextBox();
            this.clearAfterSendingCheckBox = new System.Windows.Forms.CheckBox();
            this.circularSendingTimer = new System.Windows.Forms.Timer(this.components);
            this.circularSendingGroupBox.SuspendLayout();
            this.displayModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sentDataRichTextBox
            // 
            this.sentDataRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sentDataRichTextBox.Location = new System.Drawing.Point(3, 2);
            this.sentDataRichTextBox.Name = "sentDataRichTextBox";
            this.sentDataRichTextBox.ReadOnly = true;
            this.sentDataRichTextBox.Size = new System.Drawing.Size(513, 185);
            this.sentDataRichTextBox.TabIndex = 6;
            this.sentDataRichTextBox.Text = "";
            // 
            // startStopCSButton
            // 
            this.startStopCSButton.Location = new System.Drawing.Point(6, 45);
            this.startStopCSButton.Name = "startStopCSButton";
            this.startStopCSButton.Size = new System.Drawing.Size(110, 23);
            this.startStopCSButton.TabIndex = 2;
            this.startStopCSButton.Text = "Start";
            this.startStopCSButton.UseVisualStyleBackColor = true;
            this.startStopCSButton.Click += new System.EventHandler(this.startStopCSButton_Click);
            // 
            // octDMRadioButton
            // 
            this.octDMRadioButton.AutoSize = true;
            this.octDMRadioButton.Location = new System.Drawing.Point(64, 42);
            this.octDMRadioButton.Name = "octDMRadioButton";
            this.octDMRadioButton.Size = new System.Drawing.Size(47, 17);
            this.octDMRadioButton.TabIndex = 3;
            this.octDMRadioButton.Text = "OCT";
            this.octDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ms";
            // 
            // hexDMRadioButton
            // 
            this.hexDMRadioButton.AutoSize = true;
            this.hexDMRadioButton.Checked = true;
            this.hexDMRadioButton.Location = new System.Drawing.Point(64, 19);
            this.hexDMRadioButton.Name = "hexDMRadioButton";
            this.hexDMRadioButton.Size = new System.Drawing.Size(47, 17);
            this.hexDMRadioButton.TabIndex = 2;
            this.hexDMRadioButton.TabStop = true;
            this.hexDMRadioButton.Text = "HEX";
            this.hexDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // intervalCSTextBox
            // 
            this.intervalCSTextBox.Location = new System.Drawing.Point(6, 19);
            this.intervalCSTextBox.Name = "intervalCSTextBox";
            this.intervalCSTextBox.Size = new System.Drawing.Size(84, 20);
            this.intervalCSTextBox.TabIndex = 0;
            this.intervalCSTextBox.Text = "1000";
            this.intervalCSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // circularSendingGroupBox
            // 
            this.circularSendingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularSendingGroupBox.Controls.Add(this.startStopCSButton);
            this.circularSendingGroupBox.Controls.Add(this.label1);
            this.circularSendingGroupBox.Controls.Add(this.intervalCSTextBox);
            this.circularSendingGroupBox.Location = new System.Drawing.Point(522, 108);
            this.circularSendingGroupBox.Name = "circularSendingGroupBox";
            this.circularSendingGroupBox.Size = new System.Drawing.Size(122, 74);
            this.circularSendingGroupBox.TabIndex = 10;
            this.circularSendingGroupBox.TabStop = false;
            this.circularSendingGroupBox.Text = "Circular Sending";
            // 
            // decDMRadioButton
            // 
            this.decDMRadioButton.AutoSize = true;
            this.decDMRadioButton.Location = new System.Drawing.Point(6, 42);
            this.decDMRadioButton.Name = "decDMRadioButton";
            this.decDMRadioButton.Size = new System.Drawing.Size(47, 17);
            this.decDMRadioButton.TabIndex = 1;
            this.decDMRadioButton.Text = "DEC";
            this.decDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(522, 191);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(122, 23);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearConsoleButton.Location = new System.Drawing.Point(522, 77);
            this.clearConsoleButton.Name = "clearConsoleButton";
            this.clearConsoleButton.Size = new System.Drawing.Size(122, 25);
            this.clearConsoleButton.TabIndex = 9;
            this.clearConsoleButton.Text = "Clear Console";
            this.clearConsoleButton.UseVisualStyleBackColor = true;
            // 
            // asciiDMRadioButton
            // 
            this.asciiDMRadioButton.AutoSize = true;
            this.asciiDMRadioButton.Location = new System.Drawing.Point(6, 19);
            this.asciiDMRadioButton.Name = "asciiDMRadioButton";
            this.asciiDMRadioButton.Size = new System.Drawing.Size(52, 17);
            this.asciiDMRadioButton.TabIndex = 0;
            this.asciiDMRadioButton.Text = "ASCII";
            this.asciiDMRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayModeGroupBox
            // 
            this.displayModeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayModeGroupBox.Controls.Add(this.octDMRadioButton);
            this.displayModeGroupBox.Controls.Add(this.hexDMRadioButton);
            this.displayModeGroupBox.Controls.Add(this.decDMRadioButton);
            this.displayModeGroupBox.Controls.Add(this.asciiDMRadioButton);
            this.displayModeGroupBox.Location = new System.Drawing.Point(522, 2);
            this.displayModeGroupBox.Name = "displayModeGroupBox";
            this.displayModeGroupBox.Size = new System.Drawing.Size(122, 69);
            this.displayModeGroupBox.TabIndex = 8;
            this.displayModeGroupBox.TabStop = false;
            this.displayModeGroupBox.Text = "Display Mode";
            // 
            // dataToSendTextBox
            // 
            this.dataToSendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataToSendTextBox.Location = new System.Drawing.Point(3, 193);
            this.dataToSendTextBox.Name = "dataToSendTextBox";
            this.dataToSendTextBox.Size = new System.Drawing.Size(421, 20);
            this.dataToSendTextBox.TabIndex = 7;
            this.dataToSendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataToSendTextBox_KeyPress);
            // 
            // clearAfterSendingCheckBox
            // 
            this.clearAfterSendingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAfterSendingCheckBox.AutoSize = true;
            this.clearAfterSendingCheckBox.Location = new System.Drawing.Point(430, 188);
            this.clearAfterSendingCheckBox.Name = "clearAfterSendingCheckBox";
            this.clearAfterSendingCheckBox.Size = new System.Drawing.Size(87, 30);
            this.clearAfterSendingCheckBox.TabIndex = 12;
            this.clearAfterSendingCheckBox.Text = "Clear textbox\r\nafter sending";
            this.clearAfterSendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // circularSendingTimer
            // 
            this.circularSendingTimer.Tick += new System.EventHandler(this.circularSendingTimer_Tick);
            // 
            // BaseWriterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearAfterSendingCheckBox);
            this.Controls.Add(this.sentDataRichTextBox);
            this.Controls.Add(this.circularSendingGroupBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.clearConsoleButton);
            this.Controls.Add(this.displayModeGroupBox);
            this.Controls.Add(this.dataToSendTextBox);
            this.Name = "BaseWriterControl";
            this.Size = new System.Drawing.Size(647, 221);
            this.circularSendingGroupBox.ResumeLayout(false);
            this.circularSendingGroupBox.PerformLayout();
            this.displayModeGroupBox.ResumeLayout(false);
            this.displayModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox sentDataRichTextBox;
        private System.Windows.Forms.Button startStopCSButton;
        private System.Windows.Forms.RadioButton octDMRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton hexDMRadioButton;
        private System.Windows.Forms.TextBox intervalCSTextBox;
        private System.Windows.Forms.GroupBox circularSendingGroupBox;
        private System.Windows.Forms.RadioButton decDMRadioButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearConsoleButton;
        private System.Windows.Forms.RadioButton asciiDMRadioButton;
        private System.Windows.Forms.GroupBox displayModeGroupBox;
        private System.Windows.Forms.TextBox dataToSendTextBox;
        private System.Windows.Forms.CheckBox clearAfterSendingCheckBox;
        private System.Windows.Forms.Timer circularSendingTimer;
    }
}
