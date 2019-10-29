namespace SpeechToTextWindowsApplication
{
    partial class Form1
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
            this.btnStartSpeaking = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            // 
            // btnStartSpeaking
            // 
            this.btnStartSpeaking.Location = new System.Drawing.Point(411, 352);
            this.btnStartSpeaking.Name = "btnStartSpeaking";
            this.btnStartSpeaking.Size = new System.Drawing.Size(337, 66);
            this.btnStartSpeaking.TabIndex = 0;
            this.btnStartSpeaking.Text = "Start Speaking";
            this.btnStartSpeaking.UseVisualStyleBackColor = true;
            this.btnStartSpeaking.Click += new System.EventHandler(this.btnStartSpeaking_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(54, 68);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(59, 25);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(867, 460);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnStartSpeaking);
            this.Name = "Form1";

        }

        #endregion

        private System.Windows.Forms.Button btnStartSpeaking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText;
    }
}

