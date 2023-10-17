namespace Base64DecoderApp
{
    partial class Base64DecoderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Base64TextBox = new RichTextBox();
            Utf8TextBox = new RichTextBox();
            lbl64 = new Label();
            lblUtf8 = new Label();
            SuspendLayout();
            // 
            // Base64TextBox
            // 
            Base64TextBox.Location = new Point(12, 53);
            Base64TextBox.Name = "Base64TextBox";
            Base64TextBox.Size = new Size(376, 385);
            Base64TextBox.TabIndex = 0;
            Base64TextBox.Text = "";
            // 
            // Utf8TextBox
            // 
            Utf8TextBox.Location = new Point(412, 53);
            Utf8TextBox.Name = "Utf8TextBox";
            Utf8TextBox.Size = new Size(376, 385);
            Utf8TextBox.TabIndex = 1;
            Utf8TextBox.Text = "";
            // 
            // lbl64
            // 
            lbl64.AutoSize = true;
            lbl64.Location = new Point(12, 35);
            lbl64.Name = "lbl64";
            lbl64.Size = new Size(70, 15);
            lbl64.TabIndex = 2;
            lbl64.Text = "Base 64 Text";
            // 
            // lblUtf8
            // 
            lblUtf8.AutoSize = true;
            lblUtf8.Location = new Point(412, 35);
            lblUtf8.Name = "lblUtf8";
            lblUtf8.Size = new Size(62, 15);
            lblUtf8.TabIndex = 3;
            lblUtf8.Text = "UTF-8 Text";
            // 
            // Base64DecoderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUtf8);
            Controls.Add(lbl64);
            Controls.Add(Utf8TextBox);
            Controls.Add(Base64TextBox);
            Name = "Base64DecoderForm";
            Text = "Base 64 Decoder Form";
            Load += Base64DecoderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Base64TextBox;
        private RichTextBox Utf8TextBox;
        private Label lbl64;
        private Label lblUtf8;
    }
}