namespace MasterTool.Tools
{
    partial class TileTypeMoveInfoTool
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
            this.onFromUp = new System.Windows.Forms.CheckBox();
            this.onFromRight = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.onFromLeft = new System.Windows.Forms.CheckBox();
            this.onFromDown = new System.Windows.Forms.CheckBox();
            this.offThroughDown = new System.Windows.Forms.CheckBox();
            this.offThroughLeft = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.offThroughRight = new System.Windows.Forms.CheckBox();
            this.offThroughUp = new System.Windows.Forms.CheckBox();
            this.moveDifficulty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.limitedMovement = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.moveDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // onFromUp
            // 
            this.onFromUp.AutoSize = true;
            this.onFromUp.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.onFromUp.Location = new System.Drawing.Point(55, 28);
            this.onFromUp.Name = "onFromUp";
            this.onFromUp.Size = new System.Drawing.Size(25, 31);
            this.onFromUp.TabIndex = 0;
            this.onFromUp.Text = "Up";
            this.onFromUp.UseVisualStyleBackColor = true;
            // 
            // onFromRight
            // 
            this.onFromRight.AutoSize = true;
            this.onFromRight.Location = new System.Drawing.Point(75, 63);
            this.onFromRight.Name = "onFromRight";
            this.onFromRight.Size = new System.Drawing.Size(51, 17);
            this.onFromRight.TabIndex = 1;
            this.onFromRight.Text = "Right";
            this.onFromRight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Can Move Onto Tile From:";
            // 
            // onFromLeft
            // 
            this.onFromLeft.AutoSize = true;
            this.onFromLeft.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.onFromLeft.Location = new System.Drawing.Point(15, 62);
            this.onFromLeft.Name = "onFromLeft";
            this.onFromLeft.Size = new System.Drawing.Size(44, 17);
            this.onFromLeft.TabIndex = 3;
            this.onFromLeft.Text = "Left";
            this.onFromLeft.UseVisualStyleBackColor = true;
            // 
            // onFromDown
            // 
            this.onFromDown.AutoSize = true;
            this.onFromDown.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.onFromDown.Location = new System.Drawing.Point(48, 80);
            this.onFromDown.Name = "onFromDown";
            this.onFromDown.Size = new System.Drawing.Size(39, 31);
            this.onFromDown.TabIndex = 4;
            this.onFromDown.Text = "Down";
            this.onFromDown.UseVisualStyleBackColor = true;
            // 
            // offThroughDown
            // 
            this.offThroughDown.AutoSize = true;
            this.offThroughDown.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.offThroughDown.Location = new System.Drawing.Point(205, 80);
            this.offThroughDown.Name = "offThroughDown";
            this.offThroughDown.Size = new System.Drawing.Size(39, 31);
            this.offThroughDown.TabIndex = 9;
            this.offThroughDown.Text = "Down";
            this.offThroughDown.UseVisualStyleBackColor = true;
            // 
            // offThroughLeft
            // 
            this.offThroughLeft.AutoSize = true;
            this.offThroughLeft.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.offThroughLeft.Location = new System.Drawing.Point(172, 62);
            this.offThroughLeft.Name = "offThroughLeft";
            this.offThroughLeft.Size = new System.Drawing.Size(44, 17);
            this.offThroughLeft.TabIndex = 8;
            this.offThroughLeft.Text = "Left";
            this.offThroughLeft.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Can Move Off Of Tile Through:";
            // 
            // offThroughRight
            // 
            this.offThroughRight.AutoSize = true;
            this.offThroughRight.Location = new System.Drawing.Point(232, 63);
            this.offThroughRight.Name = "offThroughRight";
            this.offThroughRight.Size = new System.Drawing.Size(51, 17);
            this.offThroughRight.TabIndex = 6;
            this.offThroughRight.Text = "Right";
            this.offThroughRight.UseVisualStyleBackColor = true;
            // 
            // offThroughUp
            // 
            this.offThroughUp.AutoSize = true;
            this.offThroughUp.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.offThroughUp.Location = new System.Drawing.Point(212, 28);
            this.offThroughUp.Name = "offThroughUp";
            this.offThroughUp.Size = new System.Drawing.Size(25, 31);
            this.offThroughUp.TabIndex = 5;
            this.offThroughUp.Text = "Up";
            this.offThroughUp.UseVisualStyleBackColor = true;
            // 
            // moveDifficulty
            // 
            this.moveDifficulty.Location = new System.Drawing.Point(96, 126);
            this.moveDifficulty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moveDifficulty.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.moveDifficulty.Name = "moveDifficulty";
            this.moveDifficulty.Size = new System.Drawing.Size(120, 20);
            this.moveDifficulty.TabIndex = 18;
            this.moveDifficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Move Difficulty";
            // 
            // limitedMovement
            // 
            this.limitedMovement.AutoSize = true;
            this.limitedMovement.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limitedMovement.Location = new System.Drawing.Point(12, 162);
            this.limitedMovement.Name = "limitedMovement";
            this.limitedMovement.Size = new System.Drawing.Size(112, 17);
            this.limitedMovement.TabIndex = 20;
            this.limitedMovement.Text = "Limited Movement";
            this.limitedMovement.UseVisualStyleBackColor = true;
            // 
            // TileTypeMoveInfoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 190);
            this.Controls.Add(this.limitedMovement);
            this.Controls.Add(this.moveDifficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.offThroughDown);
            this.Controls.Add(this.offThroughLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offThroughRight);
            this.Controls.Add(this.offThroughUp);
            this.Controls.Add(this.onFromDown);
            this.Controls.Add(this.onFromLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onFromRight);
            this.Controls.Add(this.onFromUp);
            this.Name = "TileTypeMoveInfoTool";
            this.Text = "Tile Type Move Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TileTypeMoveInfoTool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.moveDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onFromUp;
        private System.Windows.Forms.CheckBox onFromRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox onFromLeft;
        private System.Windows.Forms.CheckBox onFromDown;
        private System.Windows.Forms.CheckBox offThroughDown;
        private System.Windows.Forms.CheckBox offThroughLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox offThroughRight;
        private System.Windows.Forms.CheckBox offThroughUp;
        private System.Windows.Forms.NumericUpDown moveDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox limitedMovement;
    }
}