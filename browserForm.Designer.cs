namespace Browser
{
    partial class browserForm
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
            this.urlField = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.browserField = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // urlField
            // 
            this.urlField.Location = new System.Drawing.Point(12, 10);
            this.urlField.Name = "urlField";
            this.urlField.Size = new System.Drawing.Size(531, 20);
            this.urlField.TabIndex = 0;
            this.urlField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlField_KeyPress);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(549, 8);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(43, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // browserField
            // 
            this.browserField.Location = new System.Drawing.Point(12, 36);
            this.browserField.Name = "browserField";
            this.browserField.Size = new System.Drawing.Size(580, 398);
            this.browserField.TabIndex = 2;
            this.browserField.Text = "";
            // 
            // browserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 446);
            this.Controls.Add(this.browserField);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.urlField);
            this.Name = "browserForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlField;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RichTextBox browserField;
    }
}

