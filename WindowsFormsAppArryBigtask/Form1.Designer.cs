namespace WindowsFormsAppArryBigtask
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.addCountLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Name";
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(55, 41);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(297, 20);
            this.addNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(376, 37);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(52, 86);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(63, 13);
            this.Label.TabIndex = 3;
            this.Label.Text = "Add Count :";
            // 
            // addCountLabel
            // 
            this.addCountLabel.AutoSize = true;
            this.addCountLabel.Location = new System.Drawing.Point(121, 86);
            this.addCountLabel.Name = "addCountLabel";
            this.addCountLabel.Size = new System.Drawing.Size(0, 13);
            this.addCountLabel.TabIndex = 4;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(376, 76);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(122, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(376, 134);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(122, 23);
            this.showAllButton.TabIndex = 6;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(55, 188);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(443, 134);
            this.nameListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 361);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addCountLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label addCountLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ListBox nameListBox;
    }
}

