namespace Crazy_Checkers
{
    partial class FormSettings
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ruleSetLabel = new System.Windows.Forms.Label();
            this.ruleSetComboBox = new System.Windows.Forms.ComboBox();
            this.soundCheckBox = new System.Windows.Forms.CheckBox();
            this.gridSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.gridSizeUnitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(52, 248);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 34);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(233, 248);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ruleSetLabel
            // 
            this.ruleSetLabel.AutoSize = true;
            this.ruleSetLabel.Location = new System.Drawing.Point(46, 36);
            this.ruleSetLabel.Name = "ruleSetLabel";
            this.ruleSetLabel.Size = new System.Drawing.Size(62, 17);
            this.ruleSetLabel.TabIndex = 2;
            this.ruleSetLabel.Text = "Rule Set";
            // 
            // ruleSetComboBox
            // 
            this.ruleSetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ruleSetComboBox.FormattingEnabled = true;
            this.ruleSetComboBox.Items.AddRange(new object[] {
            "International Draughts",
            "Suicide Checkers",
            "Canadian Checkers",
            "Italian Checkers"});
            this.ruleSetComboBox.Location = new System.Drawing.Point(49, 67);
            this.ruleSetComboBox.Name = "ruleSetComboBox";
            this.ruleSetComboBox.Size = new System.Drawing.Size(259, 24);
            this.ruleSetComboBox.TabIndex = 4;
            // 
            // soundCheckBox
            // 
            this.soundCheckBox.AutoSize = true;
            this.soundCheckBox.Checked = true;
            this.soundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundCheckBox.Location = new System.Drawing.Point(49, 117);
            this.soundCheckBox.Name = "soundCheckBox";
            this.soundCheckBox.Size = new System.Drawing.Size(71, 21);
            this.soundCheckBox.TabIndex = 5;
            this.soundCheckBox.Text = "Sound";
            this.soundCheckBox.UseVisualStyleBackColor = true;
            // 
            // gridSizeTrackBar
            // 
            this.gridSizeTrackBar.LargeChange = 2;
            this.gridSizeTrackBar.Location = new System.Drawing.Point(49, 186);
            this.gridSizeTrackBar.Maximum = 12;
            this.gridSizeTrackBar.Minimum = 8;
            this.gridSizeTrackBar.Name = "gridSizeTrackBar";
            this.gridSizeTrackBar.Size = new System.Drawing.Size(259, 56);
            this.gridSizeTrackBar.TabIndex = 6;
            this.gridSizeTrackBar.Value = 8;
            this.gridSizeTrackBar.Scroll += new System.EventHandler(this.gridSizeTrackBar_Scroll);
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Location = new System.Drawing.Point(49, 166);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(66, 17);
            this.gridSizeLabel.TabIndex = 7;
            this.gridSizeLabel.Text = "Grid Size";
            // 
            // gridSizeUnitsLabel
            // 
            this.gridSizeUnitsLabel.AutoSize = true;
            this.gridSizeUnitsLabel.Location = new System.Drawing.Point(284, 166);
            this.gridSizeUnitsLabel.Name = "gridSizeUnitsLabel";
            this.gridSizeUnitsLabel.Size = new System.Drawing.Size(24, 17);
            this.gridSizeUnitsLabel.TabIndex = 8;
            this.gridSizeUnitsLabel.Text = "64";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 321);
            this.Controls.Add(this.gridSizeUnitsLabel);
            this.Controls.Add(this.gridSizeLabel);
            this.Controls.Add(this.gridSizeTrackBar);
            this.Controls.Add(this.soundCheckBox);
            this.Controls.Add(this.ruleSetComboBox);
            this.Controls.Add(this.ruleSetLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(374, 368);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(374, 368);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crazy Checkers Settings";
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label ruleSetLabel;
        private System.Windows.Forms.ComboBox ruleSetComboBox;
        private System.Windows.Forms.CheckBox soundCheckBox;
        private System.Windows.Forms.TrackBar gridSizeTrackBar;
        private System.Windows.Forms.Label gridSizeLabel;
        private System.Windows.Forms.Label gridSizeUnitsLabel;
    }
}