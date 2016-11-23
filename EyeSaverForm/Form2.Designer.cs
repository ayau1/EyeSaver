namespace EyeSaverForm
{
    partial class Form2
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
            this.numberOfMinsToWorkLabel = new System.Windows.Forms.Label();
            this.numberOfMinsToWorkTextBox = new System.Windows.Forms.TextBox();
            this.minutesToWorkSubmitButton = new System.Windows.Forms.Button();
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // numberOfMinsToWorkLabel
            // 
            this.numberOfMinsToWorkLabel.AutoSize = true;
            this.numberOfMinsToWorkLabel.Location = new System.Drawing.Point(115, 87);
            this.numberOfMinsToWorkLabel.Name = "numberOfMinsToWorkLabel";
            this.numberOfMinsToWorkLabel.Size = new System.Drawing.Size(239, 20);
            this.numberOfMinsToWorkLabel.TabIndex = 0;
            this.numberOfMinsToWorkLabel.Text = "Enter number of minutes to work";
            // 
            // numberOfMinsToWorkTextBox
            // 
            this.numberOfMinsToWorkTextBox.Location = new System.Drawing.Point(119, 140);
            this.numberOfMinsToWorkTextBox.Name = "numberOfMinsToWorkTextBox";
            this.numberOfMinsToWorkTextBox.Size = new System.Drawing.Size(100, 26);
            this.numberOfMinsToWorkTextBox.TabIndex = 1;
            // 
            // minutesToWorkSubmitButton
            // 
            this.minutesToWorkSubmitButton.Location = new System.Drawing.Point(119, 204);
            this.minutesToWorkSubmitButton.Name = "minutesToWorkSubmitButton";
            this.minutesToWorkSubmitButton.Size = new System.Drawing.Size(100, 45);
            this.minutesToWorkSubmitButton.TabIndex = 2;
            this.minutesToWorkSubmitButton.Text = "submit";
            this.minutesToWorkSubmitButton.UseVisualStyleBackColor = true;
            this.minutesToWorkSubmitButton.Click += new System.EventHandler(this.minutesToWorkSubmitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 527);
            this.Controls.Add(this.minutesToWorkSubmitButton);
            this.Controls.Add(this.numberOfMinsToWorkTextBox);
            this.Controls.Add(this.numberOfMinsToWorkLabel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfMinsToWorkLabel;
        private System.Windows.Forms.TextBox numberOfMinsToWorkTextBox;
        private System.Windows.Forms.Button minutesToWorkSubmitButton;
        private System.Windows.Forms.Timer breakTimer;
    }
}