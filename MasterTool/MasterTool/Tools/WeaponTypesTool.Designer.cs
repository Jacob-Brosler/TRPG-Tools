namespace MasterTool.Tools
{
    partial class WeaponTypesTool
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
            this.removeType = new System.Windows.Forms.Button();
            this.addType = new System.Windows.Forms.Button();
            this.weaponTypeList = new System.Windows.Forms.ListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeRange = new System.Windows.Forms.Button();
            this.addRange = new System.Windows.Forms.Button();
            this.rangesList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeDiagRange = new System.Windows.Forms.Button();
            this.addDiagRange = new System.Windows.Forms.Button();
            this.diagRangeList = new System.Windows.Forms.ListBox();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeType
            // 
            this.removeType.Location = new System.Drawing.Point(63, 282);
            this.removeType.Margin = new System.Windows.Forms.Padding(4);
            this.removeType.Name = "removeType";
            this.removeType.Size = new System.Drawing.Size(59, 28);
            this.removeType.TabIndex = 13;
            this.removeType.Text = "-";
            this.removeType.UseVisualStyleBackColor = true;
            this.removeType.Click += new System.EventHandler(this.RemoveType_Click);
            // 
            // addType
            // 
            this.addType.Location = new System.Drawing.Point(4, 282);
            this.addType.Margin = new System.Windows.Forms.Padding(4);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(59, 28);
            this.addType.TabIndex = 12;
            this.addType.Text = "+";
            this.addType.UseVisualStyleBackColor = true;
            this.addType.Click += new System.EventHandler(this.AddType_Click);
            // 
            // weaponTypeList
            // 
            this.weaponTypeList.FormattingEnabled = true;
            this.weaponTypeList.ItemHeight = 16;
            this.weaponTypeList.Location = new System.Drawing.Point(4, 4);
            this.weaponTypeList.Margin = new System.Windows.Forms.Padding(4);
            this.weaponTypeList.Name = "weaponTypeList";
            this.weaponTypeList.Size = new System.Drawing.Size(116, 276);
            this.weaponTypeList.TabIndex = 11;
            this.weaponTypeList.SelectedIndexChanged += new System.EventHandler(this.WeaponTypeList_SelectedIndexChanged);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.removeDiagRange);
            this.backPanel.Controls.Add(this.addDiagRange);
            this.backPanel.Controls.Add(this.diagRangeList);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Controls.Add(this.removeRange);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.addRange);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.rangesList);
            this.backPanel.Location = new System.Drawing.Point(127, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(287, 305);
            this.backPanel.TabIndex = 14;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(59, 9);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // removeRange
            // 
            this.removeRange.Location = new System.Drawing.Point(66, 269);
            this.removeRange.Margin = new System.Windows.Forms.Padding(4);
            this.removeRange.Name = "removeRange";
            this.removeRange.Size = new System.Drawing.Size(59, 28);
            this.removeRange.TabIndex = 17;
            this.removeRange.Text = "-";
            this.removeRange.UseVisualStyleBackColor = true;
            this.removeRange.Click += new System.EventHandler(this.RemoveRange_Click);
            // 
            // addRange
            // 
            this.addRange.Location = new System.Drawing.Point(7, 269);
            this.addRange.Margin = new System.Windows.Forms.Padding(4);
            this.addRange.Name = "addRange";
            this.addRange.Size = new System.Drawing.Size(59, 28);
            this.addRange.TabIndex = 16;
            this.addRange.Text = "+";
            this.addRange.UseVisualStyleBackColor = true;
            this.addRange.Click += new System.EventHandler(this.AddRange_Click);
            // 
            // rangesList
            // 
            this.rangesList.FormattingEnabled = true;
            this.rangesList.ItemHeight = 16;
            this.rangesList.Location = new System.Drawing.Point(7, 71);
            this.rangesList.Margin = new System.Windows.Forms.Padding(4);
            this.rangesList.Name = "rangesList";
            this.rangesList.Size = new System.Drawing.Size(116, 196);
            this.rangesList.TabIndex = 15;
            this.rangesList.DoubleClick += new System.EventHandler(this.RangesList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Orthogonal Ranges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Diagonal Ranges";
            // 
            // removeDiagRange
            // 
            this.removeDiagRange.Location = new System.Drawing.Point(218, 269);
            this.removeDiagRange.Margin = new System.Windows.Forms.Padding(4);
            this.removeDiagRange.Name = "removeDiagRange";
            this.removeDiagRange.Size = new System.Drawing.Size(59, 28);
            this.removeDiagRange.TabIndex = 21;
            this.removeDiagRange.Text = "-";
            this.removeDiagRange.UseVisualStyleBackColor = true;
            this.removeDiagRange.Click += new System.EventHandler(this.RemoveDiagRange_Click);
            // 
            // addDiagRange
            // 
            this.addDiagRange.Location = new System.Drawing.Point(159, 269);
            this.addDiagRange.Margin = new System.Windows.Forms.Padding(4);
            this.addDiagRange.Name = "addDiagRange";
            this.addDiagRange.Size = new System.Drawing.Size(59, 28);
            this.addDiagRange.TabIndex = 20;
            this.addDiagRange.Text = "+";
            this.addDiagRange.UseVisualStyleBackColor = true;
            this.addDiagRange.Click += new System.EventHandler(this.AddDiagRange_Click);
            // 
            // diagRangeList
            // 
            this.diagRangeList.FormattingEnabled = true;
            this.diagRangeList.ItemHeight = 16;
            this.diagRangeList.Location = new System.Drawing.Point(159, 71);
            this.diagRangeList.Margin = new System.Windows.Forms.Padding(4);
            this.diagRangeList.Name = "diagRangeList";
            this.diagRangeList.Size = new System.Drawing.Size(116, 196);
            this.diagRangeList.TabIndex = 19;
            this.diagRangeList.DoubleClick += new System.EventHandler(this.DiagRangeList_DoubleClick);
            // 
            // WeaponTypesTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 321);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.removeType);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.weaponTypeList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WeaponTypesTool";
            this.Text = "Weapon Types";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeType;
        private System.Windows.Forms.Button addType;
        public System.Windows.Forms.ListBox weaponTypeList;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeDiagRange;
        private System.Windows.Forms.Button addDiagRange;
        public System.Windows.Forms.ListBox diagRangeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeRange;
        private System.Windows.Forms.Button addRange;
        public System.Windows.Forms.ListBox rangesList;
    }
}