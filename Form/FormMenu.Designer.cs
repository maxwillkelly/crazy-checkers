﻿namespace Crazy_Checkers
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.Divider = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.Btn1Player = new System.Windows.Forms.Button();
            this.Btn2Player = new System.Windows.Forms.Button();
            this.Divider.SuspendLayout();
            this.SuspendLayout();
            // 
            // Divider
            // 
            this.Divider.AutoSize = true;
            this.Divider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Divider.ColumnCount = 2;
            this.Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Divider.Controls.Add(this.BtnLoad, 0, 1);
            this.Divider.Controls.Add(this.BtnSettings, 0, 1);
            this.Divider.Controls.Add(this.Btn1Player, 0, 0);
            this.Divider.Controls.Add(this.Btn2Player, 1, 0);
            this.Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divider.Location = new System.Drawing.Point(0, 0);
            this.Divider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Divider.Name = "Divider";
            this.Divider.RowCount = 2;
            this.Divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Divider.Size = new System.Drawing.Size(537, 487);
            this.Divider.TabIndex = 0;
            // 
            // BtnLoad
            // 
            this.BtnLoad.AutoSize = true;
            this.BtnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLoad.BackgroundImage")));
            this.BtnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLoad.FlatAppearance.BorderSize = 10;
            this.BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoad.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLoad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLoad.Location = new System.Drawing.Point(0, 243);
            this.BtnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.BtnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLoad.Size = new System.Drawing.Size(268, 244);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load Game";
            this.BtnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.AutoSize = true;
            this.BtnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSettings.BackgroundImage")));
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSettings.FlatAppearance.BorderSize = 10;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSettings.Location = new System.Drawing.Point(268, 243);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Padding = new System.Windows.Forms.Padding(0, 144, 0, 0);
            this.BtnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSettings.Size = new System.Drawing.Size(269, 244);
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // Btn1Player
            // 
            this.Btn1Player.AutoSize = true;
            this.Btn1Player.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn1Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn1Player.BackgroundImage")));
            this.Btn1Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn1Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn1Player.FlatAppearance.BorderSize = 0;
            this.Btn1Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1Player.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1Player.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn1Player.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn1Player.Location = new System.Drawing.Point(0, 0);
            this.Btn1Player.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1Player.Name = "Btn1Player";
            this.Btn1Player.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.Btn1Player.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn1Player.Size = new System.Drawing.Size(268, 243);
            this.Btn1Player.TabIndex = 0;
            this.Btn1Player.Text = "Single Player";
            this.Btn1Player.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn1Player.UseVisualStyleBackColor = true;
            this.Btn1Player.Click += new System.EventHandler(this.Btn1Player_Click);
            // 
            // Btn2Player
            // 
            this.Btn2Player.AutoSize = true;
            this.Btn2Player.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn2Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn2Player.BackgroundImage")));
            this.Btn2Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn2Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn2Player.FlatAppearance.BorderSize = 10;
            this.Btn2Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2Player.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2Player.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn2Player.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn2Player.Location = new System.Drawing.Point(268, 0);
            this.Btn2Player.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2Player.Name = "Btn2Player";
            this.Btn2Player.Padding = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.Btn2Player.Size = new System.Drawing.Size(269, 243);
            this.Btn2Player.TabIndex = 3;
            this.Btn2Player.Text = "Dual Player";
            this.Btn2Player.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn2Player.UseVisualStyleBackColor = true;
            this.Btn2Player.Click += new System.EventHandler(this.Btn2Player_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 487);
            this.Controls.Add(this.Divider);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(555, 534);
            this.MinimumSize = new System.Drawing.Size(555, 534);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crazy Checkers";
            this.Divider.ResumeLayout(false);
            this.Divider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Divider;
        private System.Windows.Forms.Button Btn1Player;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button Btn2Player;
    }
}