namespace Assignment10.View
{
    partial class MainForm
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
            outputLabel = new Label();
            outputTextBox = new TextBox();
            SuspendLayout();
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(18, 14);
            outputLabel.Margin = new Padding(2, 0, 2, 0);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(69, 25);
            outputLabel.TabIndex = 0;
            outputLabel.Text = "Output";
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(18, 41);
            outputTextBox.Margin = new Padding(2, 2, 2, 2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(589, 286);
            outputTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 344);
            Controls.Add(outputTextBox);
            Controls.Add(outputLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Assignment 10 by Gillespie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label outputLabel;
        private TextBox outputTextBox;
    }
}