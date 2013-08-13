namespace F_RS232Client
{
    partial class MainWindow
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
            this.senderControlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // senderControlPanel
            // 
            this.senderControlPanel.Location = new System.Drawing.Point(84, 39);
            this.senderControlPanel.Name = "senderControlPanel";
            this.senderControlPanel.Size = new System.Drawing.Size(633, 282);
            this.senderControlPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 415);
            this.Controls.Add(this.senderControlPanel);
            this.Name = "MainWindow";
            this.Text = "F_RS232Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel senderControlPanel;
    }
}

