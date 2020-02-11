using System.Windows.Forms;

namespace Crazy_Checkers
{
    partial class FormMain
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
            this.TopPanelTable = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.ScoreRed = new System.Windows.Forms.Label();
            this.ScoreBlack = new System.Windows.Forms.Label();
            this.redTurnIndicator = new System.Windows.Forms.Label();
            this.blackTurnIndicator = new System.Windows.Forms.Label();
            this.TopPanelTable.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanelTable
            // 
            this.TopPanelTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopPanelTable.ColumnCount = 1;
            this.TopPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanelTable.Controls.Add(this.topPanel, 0, 0);
            this.TopPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanelTable.Location = new System.Drawing.Point(0, 0);
            this.TopPanelTable.Name = "TopPanelTable";
            this.TopPanelTable.RowCount = 2;
            this.TopPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TopPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TopPanelTable.Size = new System.Drawing.Size(782, 832);
            this.TopPanelTable.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.Controls.Add(this.blackTurnIndicator);
            this.topPanel.Controls.Add(this.redTurnIndicator);
            this.topPanel.Controls.Add(this.BtnSettings);
            this.topPanel.Controls.Add(this.BtnAbout);
            this.topPanel.Controls.Add(this.ScoreRed);
            this.topPanel.Controls.Add(this.ScoreBlack);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(782, 50);
            this.topPanel.TabIndex = 2;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(90, 8);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(75, 34);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(9, 8);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(75, 34);
            this.BtnAbout.TabIndex = 2;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // ScoreRed
            // 
            this.ScoreRed.AutoSize = true;
            this.ScoreRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreRed.Location = new System.Drawing.Point(405, 8);
            this.ScoreRed.Margin = new System.Windows.Forms.Padding(3);
            this.ScoreRed.Name = "ScoreRed";
            this.ScoreRed.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.ScoreRed.Size = new System.Drawing.Size(39, 33);
            this.ScoreRed.TabIndex = 1;
            this.ScoreRed.Text = "00";
            // 
            // ScoreBlack
            // 
            this.ScoreBlack.AutoSize = true;
            this.ScoreBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBlack.Location = new System.Drawing.Point(360, 8);
            this.ScoreBlack.Margin = new System.Windows.Forms.Padding(3);
            this.ScoreBlack.Name = "ScoreBlack";
            this.ScoreBlack.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.ScoreBlack.Size = new System.Drawing.Size(39, 33);
            this.ScoreBlack.TabIndex = 0;
            this.ScoreBlack.Text = "00";
            // 
            // redTurnIndicator
            // 
            this.redTurnIndicator.AutoSize = true;
            this.redTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redTurnIndicator.ForeColor = System.Drawing.Color.Red;
            this.redTurnIndicator.Location = new System.Drawing.Point(316, 5);
            this.redTurnIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.redTurnIndicator.Name = "redTurnIndicator";
            this.redTurnIndicator.Size = new System.Drawing.Size(41, 39);
            this.redTurnIndicator.TabIndex = 4;
            this.redTurnIndicator.Text = "⬤";
            // 
            // blackTurnIndicator
            // 
            this.blackTurnIndicator.AutoSize = true;
            this.blackTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackTurnIndicator.ForeColor = System.Drawing.Color.Black;
            this.blackTurnIndicator.Location = new System.Drawing.Point(447, 5);
            this.blackTurnIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.blackTurnIndicator.Name = "blackTurnIndicator";
            this.blackTurnIndicator.Size = new System.Drawing.Size(41, 39);
            this.blackTurnIndicator.TabIndex = 5;
            this.blackTurnIndicator.Text = "⬤";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 832);
            this.Controls.Add(this.TopPanelTable);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crazy Checkers";
            this.TopPanelTable.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TopPanelTable;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Label ScoreRed;
        private System.Windows.Forms.Label ScoreBlack;
        private Label redTurnIndicator;
        private Label blackTurnIndicator;
    }
}

