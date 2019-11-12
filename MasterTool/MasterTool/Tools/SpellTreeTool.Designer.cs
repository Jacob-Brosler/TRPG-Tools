namespace MasterTool.Tools
{
    partial class SpellTreeTool
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
            this.removeTree = new System.Windows.Forms.Button();
            this.addTree = new System.Windows.Forms.Button();
            this.spellTreeList = new System.Windows.Forms.ListBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editSpells = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeTree
            // 
            this.removeTree.Location = new System.Drawing.Point(75, 293);
            this.removeTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeTree.Name = "removeTree";
            this.removeTree.Size = new System.Drawing.Size(59, 28);
            this.removeTree.TabIndex = 34;
            this.removeTree.Text = "-";
            this.removeTree.UseVisualStyleBackColor = true;
            this.removeTree.Click += new System.EventHandler(this.removeTree_Click);
            // 
            // addTree
            // 
            this.addTree.Location = new System.Drawing.Point(16, 293);
            this.addTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTree.Name = "addTree";
            this.addTree.Size = new System.Drawing.Size(59, 28);
            this.addTree.TabIndex = 33;
            this.addTree.Text = "+";
            this.addTree.UseVisualStyleBackColor = true;
            this.addTree.Click += new System.EventHandler(this.addTree_Click);
            // 
            // spellTreeList
            // 
            this.spellTreeList.FormattingEnabled = true;
            this.spellTreeList.ItemHeight = 16;
            this.spellTreeList.Location = new System.Drawing.Point(16, 15);
            this.spellTreeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spellTreeList.Name = "spellTreeList";
            this.spellTreeList.Size = new System.Drawing.Size(116, 276);
            this.spellTreeList.TabIndex = 32;
            this.spellTreeList.SelectedIndexChanged += new System.EventHandler(this.spellTreeList_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(67, 11);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // editSpells
            // 
            this.editSpells.Location = new System.Drawing.Point(16, 43);
            this.editSpells.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editSpells.Name = "editSpells";
            this.editSpells.Size = new System.Drawing.Size(100, 28);
            this.editSpells.TabIndex = 37;
            this.editSpells.Text = "Edit Tree";
            this.editSpells.UseVisualStyleBackColor = true;
            this.editSpells.Click += new System.EventHandler(this.editSpells_Click);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.editSpells);
            this.backPanel.Location = new System.Drawing.Point(141, 4);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(213, 123);
            this.backPanel.TabIndex = 38;
            // 
            // SpellTreeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 332);
            this.Controls.Add(this.removeTree);
            this.Controls.Add(this.addTree);
            this.Controls.Add(this.spellTreeList);
            this.Controls.Add(this.backPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SpellTreeTool";
            this.Text = "SpellTreeTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpellTreeTool_FormClosing);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeTree;
        private System.Windows.Forms.Button addTree;
        public System.Windows.Forms.ListBox spellTreeList;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editSpells;
        private System.Windows.Forms.Panel backPanel;
    }
}