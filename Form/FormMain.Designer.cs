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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageRed32 = new System.Windows.Forms.PictureBox();
            this.ImageBlack32 = new System.Windows.Forms.PictureBox();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.ScoreRed = new System.Windows.Forms.Label();
            this.ScoreBlack = new System.Windows.Forms.Label();
            this.TopPanelTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRed32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBlack32)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanelTable
            // 
            this.TopPanelTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopPanelTable.ColumnCount = 1;
            this.TopPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanelTable.Controls.Add(this.panel1, 0, 0);
            this.TopPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanelTable.Location = new System.Drawing.Point(0, 0);
            this.TopPanelTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPanelTable.Name = "TopPanelTable";
            this.TopPanelTable.RowCount = 2;
            this.TopPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.TopPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TopPanelTable.Size = new System.Drawing.Size(900, 658);
            this.TopPanelTable.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ImageRed32);
            this.panel1.Controls.Add(this.ImageBlack32);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnAbout);
            this.panel1.Controls.Add(this.ScoreRed);
            this.panel1.Controls.Add(this.ScoreBlack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 62);
            this.panel1.TabIndex = 2;
            // 
            // ImageRed32
            // 
            this.ImageRed32.Location = new System.Drawing.Point(506, 10);
            this.ImageRed32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageRed32.Name = "ImageRed32";
            this.ImageRed32.Size = new System.Drawing.Size(36, 40);
            this.ImageRed32.TabIndex = 5;
            this.ImageRed32.TabStop = false;
            // 
            // ImageBlack32
            // 
            this.ImageBlack32.Location = new System.Drawing.Point(362, 10);
            this.ImageBlack32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageBlack32.Name = "ImageBlack32";
            this.ImageBlack32.Size = new System.Drawing.Size(36, 40);
            this.ImageBlack32.TabIndex = 4;
            this.ImageBlack32.TabStop = false;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(101, 10);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(84, 42);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(10, 10);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(84, 42);
            this.BtnAbout.TabIndex = 2;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            // 
            // ScoreRed
            // 
            this.ScoreRed.AutoSize = true;
            this.ScoreRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreRed.Location = new System.Drawing.Point(456, 14);
            this.ScoreRed.Name = "ScoreRed";
            this.ScoreRed.Size = new System.Drawing.Size(47, 32);
            this.ScoreRed.TabIndex = 1;
            this.ScoreRed.Text = "00";
            // 
            // ScoreBlack
            // 
            this.ScoreBlack.AutoSize = true;
            this.ScoreBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBlack.Location = new System.Drawing.Point(405, 14);
            this.ScoreBlack.Name = "ScoreBlack";
            this.ScoreBlack.Size = new System.Drawing.Size(47, 32);
            this.ScoreBlack.TabIndex = 0;
            this.ScoreBlack.Text = "00";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 658);
            this.Controls.Add(this.TopPanelTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Crazy Checkers";
            this.TopPanelTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRed32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBlack32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.TableLayoutPanel TopPanelTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Label ScoreRed;
        private System.Windows.Forms.Label ScoreBlack;
        private System.Windows.Forms.PictureBox ImageRed32;
        private System.Windows.Forms.PictureBox ImageBlack32;
    }
}

