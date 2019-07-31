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
            this.SuspendLayout();
            // 
            // removeTree
            // 
            this.removeTree.Location = new System.Drawing.Point(56, 238);
            this.removeTree.Name = "removeTree";
            this.removeTree.Size = new System.Drawing.Size(44, 23);
            this.removeTree.TabIndex = 34;
            this.removeTree.Text = "-";
            this.removeTree.UseVisualStyleBackColor = true;
            this.removeTree.Click += new System.EventHandler(this.removeTree_Click);
            // 
            // addTree
            // 
            this.addTree.Location = new System.Drawing.Point(12, 238);
            this.addTree.Name = "addTree";
            this.addTree.Size = new System.Drawing.Size(44, 23);
            this.addTree.TabIndex = 33;
            this.addTree.Text = "+";
            this.addTree.UseVisualStyleBackColor = true;
            this.addTree.Click += new System.EventHandler(this.addTree_Click);
            // 
            // spellTreeList
            // 
            this.spellTreeList.FormattingEnabled = true;
            this.spellTreeList.Location = new System.Drawing.Point(12, 12);
            this.spellTreeList.Name = "spellTreeList";
            this.spellTreeList.Size = new System.Drawing.Size(88, 225);
            this.spellTreeList.TabIndex = 32;
            this.spellTreeList.SelectedIndexChanged += new System.EventHandler(this.spellTreeList_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(156, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // editSpells
            // 
            this.editSpells.Location = new System.Drawing.Point(118, 38);
            this.editSpells.Name = "editSpells";
            this.editSpells.Size = new System.Drawing.Size(75, 23);
            this.editSpells.TabIndex = 37;
            this.editSpells.Text = "Edit Tree";
            this.editSpells.UseVisualStyleBackColor = true;
            this.editSpells.Click += new System.EventHandler(this.editSpells_Click);
            // 
            // SpellTreeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 270);
            this.Controls.Add(this.editSpells);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeTree);
            this.Controls.Add(this.addTree);
            this.Controls.Add(this.spellTreeList);
            this.Name = "SpellTreeTool";
            this.Text = "SpellTreeTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeTree;
        private System.Windows.Forms.Button addTree;
        public System.Windows.Forms.ListBox spellTreeList;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editSpells;
    }
}