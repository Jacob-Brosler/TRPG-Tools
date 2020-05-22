namespace MasterTool.Tools
{
    partial class MovementTypesTool
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
            this.removeMoveType = new System.Windows.Forms.Button();
            this.addMoveType = new System.Windows.Forms.Button();
            this.moveTypeList = new System.Windows.Forms.ListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.moveSpeed = new System.Windows.Forms.NumericUpDown();
            this.tileDataList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // removeMoveType
            // 
            this.removeMoveType.Location = new System.Drawing.Point(48, 230);
            this.removeMoveType.Name = "removeMoveType";
            this.removeMoveType.Size = new System.Drawing.Size(44, 23);
            this.removeMoveType.TabIndex = 32;
            this.removeMoveType.Text = "-";
            this.removeMoveType.UseVisualStyleBackColor = true;
            this.removeMoveType.Click += new System.EventHandler(this.removeMoveType_Click);
            // 
            // addMoveType
            // 
            this.addMoveType.Location = new System.Drawing.Point(4, 230);
            this.addMoveType.Name = "addMoveType";
            this.addMoveType.Size = new System.Drawing.Size(44, 23);
            this.addMoveType.TabIndex = 31;
            this.addMoveType.Text = "+";
            this.addMoveType.UseVisualStyleBackColor = true;
            this.addMoveType.Click += new System.EventHandler(this.addMoveType_Click);
            // 
            // moveTypeList
            // 
            this.moveTypeList.FormattingEnabled = true;
            this.moveTypeList.Location = new System.Drawing.Point(4, 4);
            this.moveTypeList.Name = "moveTypeList";
            this.moveTypeList.Size = new System.Drawing.Size(88, 225);
            this.moveTypeList.TabIndex = 30;
            this.moveTypeList.SelectedIndexChanged += new System.EventHandler(this.moveTypeList_SelectedIndexChanged);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.label6);
            this.backPanel.Controls.Add(this.moveSpeed);
            this.backPanel.Controls.Add(this.tileDataList);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Location = new System.Drawing.Point(98, 5);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(203, 248);
            this.backPanel.TabIndex = 33;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(43, 9);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tiles";
            // 
            // moveSpeed
            // 
            this.moveSpeed.Location = new System.Drawing.Point(76, 45);
            this.moveSpeed.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.moveSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.moveSpeed.Name = "moveSpeed";
            this.moveSpeed.Size = new System.Drawing.Size(120, 20);
            this.moveSpeed.TabIndex = 15;
            this.moveSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tileDataList
            // 
            this.tileDataList.FormattingEnabled = true;
            this.tileDataList.Location = new System.Drawing.Point(5, 94);
            this.tileDataList.Name = "tileDataList";
            this.tileDataList.Size = new System.Drawing.Size(91, 147);
            this.tileDataList.TabIndex = 25;
            this.tileDataList.DoubleClick += new System.EventHandler(this.tileDataList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Move Speed";
            // 
            // MovementTypesTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 256);
            this.Controls.Add(this.removeMoveType);
            this.Controls.Add(this.addMoveType);
            this.Controls.Add(this.moveTypeList);
            this.Controls.Add(this.backPanel);
            this.Name = "MovementTypesTool";
            this.Text = "Movement Types";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovementTypesTool_FormClosing);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeMoveType;
        private System.Windows.Forms.Button addMoveType;
        public System.Windows.Forms.ListBox moveTypeList;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown moveSpeed;
        private System.Windows.Forms.ListBox tileDataList;
        private System.Windows.Forms.Label label2;
    }
}