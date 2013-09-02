namespace F_RS232Client.Plugins.Core.Controls
{
    partial class BaseViewerControl
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
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(150, 150);
            this.mainRichTextBox.TabIndex = 0;
            this.mainRichTextBox.Text = "";
            // 
            // BaseViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainRichTextBox);
            this.Name = "BaseViewerControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainRichTextBox;
    }
}
