﻿namespace Entrega2_Equipo1
{
    partial class SelectFaceLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFaceLocationForm));
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SelectedWidthTag = new System.Windows.Forms.Label();
            this.SelectedHeightTag = new System.Windows.Forms.Label();
            this.TopData = new System.Windows.Forms.Label();
            this.LeftData = new System.Windows.Forms.Label();
            this.SelectedTopTag = new System.Windows.Forms.Label();
            this.SelectedLeftTag = new System.Windows.Forms.Label();
            this.SelectedTopData = new System.Windows.Forms.Label();
            this.SelectedLeftData = new System.Windows.Forms.Label();
            this.SelectedWidthData = new System.Windows.Forms.Label();
            this.SelectedHeightData = new System.Windows.Forms.Label();
            this.WidthData = new System.Windows.Forms.Label();
            this.HeightData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(800, 409);
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            this.ImagePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagePictureBox_MouseDown);
            this.ImagePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImagePictureBox_MouseMove);
            this.ImagePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImagePictureBox_MouseUp);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(713, 418);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // SelectedWidthTag
            // 
            this.SelectedWidthTag.AutoSize = true;
            this.SelectedWidthTag.Location = new System.Drawing.Point(452, 423);
            this.SelectedWidthTag.Name = "SelectedWidthTag";
            this.SelectedWidthTag.Size = new System.Drawing.Size(83, 13);
            this.SelectedWidthTag.TabIndex = 4;
            this.SelectedWidthTag.Text = "Selected Width:";
            // 
            // SelectedHeightTag
            // 
            this.SelectedHeightTag.AutoSize = true;
            this.SelectedHeightTag.Location = new System.Drawing.Point(583, 423);
            this.SelectedHeightTag.Name = "SelectedHeightTag";
            this.SelectedHeightTag.Size = new System.Drawing.Size(86, 13);
            this.SelectedHeightTag.TabIndex = 5;
            this.SelectedHeightTag.Text = "Selected Height:";
            // 
            // TopData
            // 
            this.TopData.AutoSize = true;
            this.TopData.Location = new System.Drawing.Point(46, 428);
            this.TopData.Name = "TopData";
            this.TopData.Size = new System.Drawing.Size(28, 13);
            this.TopData.TabIndex = 6;
            this.TopData.Text = "data";
            // 
            // LeftData
            // 
            this.LeftData.AutoSize = true;
            this.LeftData.Location = new System.Drawing.Point(12, 428);
            this.LeftData.Name = "LeftData";
            this.LeftData.Size = new System.Drawing.Size(28, 13);
            this.LeftData.TabIndex = 7;
            this.LeftData.Text = "data";
            // 
            // SelectedTopTag
            // 
            this.SelectedTopTag.AutoSize = true;
            this.SelectedTopTag.Location = new System.Drawing.Point(233, 423);
            this.SelectedTopTag.Name = "SelectedTopTag";
            this.SelectedTopTag.Size = new System.Drawing.Size(74, 13);
            this.SelectedTopTag.TabIndex = 8;
            this.SelectedTopTag.Text = "Selected Top:";
            // 
            // SelectedLeftTag
            // 
            this.SelectedLeftTag.AutoSize = true;
            this.SelectedLeftTag.Location = new System.Drawing.Point(343, 423);
            this.SelectedLeftTag.Name = "SelectedLeftTag";
            this.SelectedLeftTag.Size = new System.Drawing.Size(73, 13);
            this.SelectedLeftTag.TabIndex = 9;
            this.SelectedLeftTag.Text = "Selected Left:";
            // 
            // SelectedTopData
            // 
            this.SelectedTopData.AutoSize = true;
            this.SelectedTopData.Location = new System.Drawing.Point(313, 423);
            this.SelectedTopData.Name = "SelectedTopData";
            this.SelectedTopData.Size = new System.Drawing.Size(12, 13);
            this.SelectedTopData.TabIndex = 10;
            this.SelectedTopData.Text = "x";
            // 
            // SelectedLeftData
            // 
            this.SelectedLeftData.AutoSize = true;
            this.SelectedLeftData.Location = new System.Drawing.Point(422, 423);
            this.SelectedLeftData.Name = "SelectedLeftData";
            this.SelectedLeftData.Size = new System.Drawing.Size(12, 13);
            this.SelectedLeftData.TabIndex = 11;
            this.SelectedLeftData.Text = "x";
            // 
            // SelectedWidthData
            // 
            this.SelectedWidthData.AutoSize = true;
            this.SelectedWidthData.Location = new System.Drawing.Point(541, 423);
            this.SelectedWidthData.Name = "SelectedWidthData";
            this.SelectedWidthData.Size = new System.Drawing.Size(12, 13);
            this.SelectedWidthData.TabIndex = 12;
            this.SelectedWidthData.Text = "x";
            // 
            // SelectedHeightData
            // 
            this.SelectedHeightData.AutoSize = true;
            this.SelectedHeightData.Location = new System.Drawing.Point(675, 423);
            this.SelectedHeightData.Name = "SelectedHeightData";
            this.SelectedHeightData.Size = new System.Drawing.Size(12, 13);
            this.SelectedHeightData.TabIndex = 13;
            this.SelectedHeightData.Text = "x";
            // 
            // WidthData
            // 
            this.WidthData.AutoSize = true;
            this.WidthData.Location = new System.Drawing.Point(80, 428);
            this.WidthData.Name = "WidthData";
            this.WidthData.Size = new System.Drawing.Size(28, 13);
            this.WidthData.TabIndex = 14;
            this.WidthData.Text = "data";
            // 
            // HeightData
            // 
            this.HeightData.AutoSize = true;
            this.HeightData.Location = new System.Drawing.Point(114, 428);
            this.HeightData.Name = "HeightData";
            this.HeightData.Size = new System.Drawing.Size(28, 13);
            this.HeightData.TabIndex = 15;
            this.HeightData.Text = "data";
            // 
            // SelectFaceLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeightData);
            this.Controls.Add(this.WidthData);
            this.Controls.Add(this.SelectedHeightData);
            this.Controls.Add(this.SelectedWidthData);
            this.Controls.Add(this.SelectedLeftData);
            this.Controls.Add(this.SelectedTopData);
            this.Controls.Add(this.SelectedLeftTag);
            this.Controls.Add(this.SelectedTopTag);
            this.Controls.Add(this.LeftData);
            this.Controls.Add(this.TopData);
            this.Controls.Add(this.SelectedHeightTag);
            this.Controls.Add(this.SelectedWidthTag);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ImagePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectFaceLocationForm";
            this.Text = "Select Face Location";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectFaceLocationForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectFaceLocationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label SelectedWidthTag;
        private System.Windows.Forms.Label SelectedHeightTag;
        private System.Windows.Forms.Label TopData;
        private System.Windows.Forms.Label LeftData;
        private System.Windows.Forms.Label SelectedTopTag;
        private System.Windows.Forms.Label SelectedLeftTag;
        private System.Windows.Forms.Label SelectedTopData;
        private System.Windows.Forms.Label SelectedLeftData;
        private System.Windows.Forms.Label SelectedWidthData;
        private System.Windows.Forms.Label SelectedHeightData;
        private System.Windows.Forms.Label WidthData;
        private System.Windows.Forms.Label HeightData;
    }
}