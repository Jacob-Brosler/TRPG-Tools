namespace MasterTool.Tools
{
    partial class TileTypesTool
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
            this.removeTileType = new System.Windows.Forms.Button();
            this.addTileType = new System.Windows.Forms.Button();
            this.tileList = new System.Windows.Forms.ListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.stopsMelee = new System.Windows.Forms.CheckBox();
            this.stopsRanged = new System.Windows.Forms.CheckBox();
            this.endOfTurnButton = new System.Windows.Forms.Button();
            this.endOfTurn = new System.Windows.Forms.CheckBox();
            this.stopOnTileButton = new System.Windows.Forms.Button();
            this.stopOnTile = new System.Windows.Forms.CheckBox();
            this.passOverButton = new System.Windows.Forms.Button();
            this.passOver = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startOfTurnButton = new System.Windows.Forms.Button();
            this.startOfTurn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeTileType
            // 
            this.removeTileType.Location = new System.Drawing.Point(47, 229);
            this.removeTileType.Name = "removeTileType";
            this.removeTileType.Size = new System.Drawing.Size(44, 23);
            this.removeTileType.TabIndex = 34;
            this.removeTileType.Text = "-";
            this.removeTileType.UseVisualStyleBackColor = true;
            this.removeTileType.Click += new System.EventHandler(this.RemoveTileType_Click);
            // 
            // addTileType
            // 
            this.addTileType.Location = new System.Drawing.Point(3, 229);
            this.addTileType.Name = "addTileType";
            this.addTileType.Size = new System.Drawing.Size(44, 23);
            this.addTileType.TabIndex = 33;
            this.addTileType.Text = "+";
            this.addTileType.UseVisualStyleBackColor = true;
            this.addTileType.Click += new System.EventHandler(this.AddTileType_Click);
            // 
            // tileList
            // 
            this.tileList.FormattingEnabled = true;
            this.tileList.Location = new System.Drawing.Point(3, 3);
            this.tileList.Name = "tileList";
            this.tileList.Size = new System.Drawing.Size(88, 225);
            this.tileList.TabIndex = 32;
            this.tileList.SelectedIndexChanged += new System.EventHandler(this.TileList_SelectedIndexChanged);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.stopsMelee);
            this.backPanel.Controls.Add(this.stopsRanged);
            this.backPanel.Controls.Add(this.endOfTurnButton);
            this.backPanel.Controls.Add(this.endOfTurn);
            this.backPanel.Controls.Add(this.stopOnTileButton);
            this.backPanel.Controls.Add(this.stopOnTile);
            this.backPanel.Controls.Add(this.passOverButton);
            this.backPanel.Controls.Add(this.passOver);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Controls.Add(this.startOfTurnButton);
            this.backPanel.Controls.Add(this.startOfTurn);
            this.backPanel.Controls.Add(this.label4);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.flavorTextBox);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Location = new System.Drawing.Point(95, 3);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(362, 249);
            this.backPanel.TabIndex = 35;
            // 
            // stopsMelee
            // 
            this.stopsMelee.AutoSize = true;
            this.stopsMelee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopsMelee.Location = new System.Drawing.Point(0, 36);
            this.stopsMelee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopsMelee.Name = "stopsMelee";
            this.stopsMelee.Size = new System.Drawing.Size(124, 17);
            this.stopsMelee.TabIndex = 47;
            this.stopsMelee.Text = "Stops Melee Attacks";
            this.stopsMelee.UseVisualStyleBackColor = true;
            // 
            // stopsRanged
            // 
            this.stopsRanged.AutoSize = true;
            this.stopsRanged.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopsRanged.Location = new System.Drawing.Point(0, 58);
            this.stopsRanged.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopsRanged.Name = "stopsRanged";
            this.stopsRanged.Size = new System.Drawing.Size(133, 17);
            this.stopsRanged.TabIndex = 47;
            this.stopsRanged.Text = "Stops Ranged Attacks";
            this.stopsRanged.UseVisualStyleBackColor = true;
            // 
            // endOfTurnButton
            // 
            this.endOfTurnButton.Enabled = false;
            this.endOfTurnButton.Location = new System.Drawing.Point(279, 154);
            this.endOfTurnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endOfTurnButton.Name = "endOfTurnButton";
            this.endOfTurnButton.Size = new System.Drawing.Size(68, 28);
            this.endOfTurnButton.TabIndex = 46;
            this.endOfTurnButton.Text = "Edit Effect";
            this.endOfTurnButton.UseVisualStyleBackColor = true;
            this.endOfTurnButton.Click += new System.EventHandler(this.EndOfTurnButton_Click);
            // 
            // endOfTurn
            // 
            this.endOfTurn.AutoSize = true;
            this.endOfTurn.Location = new System.Drawing.Point(192, 161);
            this.endOfTurn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endOfTurn.Name = "endOfTurn";
            this.endOfTurn.Size = new System.Drawing.Size(82, 17);
            this.endOfTurn.TabIndex = 45;
            this.endOfTurn.Text = "End of Turn";
            this.endOfTurn.UseVisualStyleBackColor = true;
            this.endOfTurn.CheckedChanged += new System.EventHandler(this.EndOfTurn_CheckedChanged);
            // 
            // stopOnTileButton
            // 
            this.stopOnTileButton.Enabled = false;
            this.stopOnTileButton.Location = new System.Drawing.Point(279, 110);
            this.stopOnTileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopOnTileButton.Name = "stopOnTileButton";
            this.stopOnTileButton.Size = new System.Drawing.Size(68, 28);
            this.stopOnTileButton.TabIndex = 44;
            this.stopOnTileButton.Text = "Edit Effect";
            this.stopOnTileButton.UseVisualStyleBackColor = true;
            this.stopOnTileButton.Click += new System.EventHandler(this.StopOnTileButton_Click);
            // 
            // stopOnTile
            // 
            this.stopOnTile.AutoSize = true;
            this.stopOnTile.Location = new System.Drawing.Point(192, 116);
            this.stopOnTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopOnTile.Name = "stopOnTile";
            this.stopOnTile.Size = new System.Drawing.Size(83, 17);
            this.stopOnTile.TabIndex = 43;
            this.stopOnTile.Text = "Stop on Tile";
            this.stopOnTile.UseVisualStyleBackColor = true;
            this.stopOnTile.CheckedChanged += new System.EventHandler(this.StopOnTile_CheckedChanged);
            // 
            // passOverButton
            // 
            this.passOverButton.Enabled = false;
            this.passOverButton.Location = new System.Drawing.Point(279, 67);
            this.passOverButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passOverButton.Name = "passOverButton";
            this.passOverButton.Size = new System.Drawing.Size(68, 28);
            this.passOverButton.TabIndex = 42;
            this.passOverButton.Text = "Edit Effect";
            this.passOverButton.UseVisualStyleBackColor = true;
            this.passOverButton.Click += new System.EventHandler(this.PassOverButton_Click);
            // 
            // passOver
            // 
            this.passOver.AutoSize = true;
            this.passOver.Location = new System.Drawing.Point(192, 74);
            this.passOver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passOver.Name = "passOver";
            this.passOver.Size = new System.Drawing.Size(75, 17);
            this.passOver.TabIndex = 41;
            this.passOver.Text = "Pass Over";
            this.passOver.UseVisualStyleBackColor = true;
            this.passOver.CheckedChanged += new System.EventHandler(this.PassOver_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Effects";
            // 
            // startOfTurnButton
            // 
            this.startOfTurnButton.Enabled = false;
            this.startOfTurnButton.Location = new System.Drawing.Point(279, 24);
            this.startOfTurnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startOfTurnButton.Name = "startOfTurnButton";
            this.startOfTurnButton.Size = new System.Drawing.Size(68, 28);
            this.startOfTurnButton.TabIndex = 39;
            this.startOfTurnButton.Text = "Edit Effect";
            this.startOfTurnButton.UseVisualStyleBackColor = true;
            this.startOfTurnButton.Click += new System.EventHandler(this.StartOfTurnButton_Click);
            // 
            // startOfTurn
            // 
            this.startOfTurn.AutoSize = true;
            this.startOfTurn.Location = new System.Drawing.Point(192, 31);
            this.startOfTurn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startOfTurn.Name = "startOfTurn";
            this.startOfTurn.Size = new System.Drawing.Size(85, 17);
            this.startOfTurn.TabIndex = 38;
            this.startOfTurn.Text = "Start of Turn";
            this.startOfTurn.UseVisualStyleBackColor = true;
            this.startOfTurn.CheckedChanged += new System.EventHandler(this.StartOfTurn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Flavor Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name";
            // 
            // flavorTextBox
            // 
            this.flavorTextBox.DetectUrls = false;
            this.flavorTextBox.Location = new System.Drawing.Point(4, 98);
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(175, 127);
            this.flavorTextBox.TabIndex = 37;
            this.flavorTextBox.Text = "";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(70, 7);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 35;
            // 
            // TileTypesTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 257);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.removeTileType);
            this.Controls.Add(this.addTileType);
            this.Controls.Add(this.tileList);
            this.Name = "TileTypesTool";
            this.Text = "Tile Types";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TileTypesTool_FormClosing);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeTileType;
        private System.Windows.Forms.Button addTileType;
        public System.Windows.Forms.ListBox tileList;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox flavorTextBox;
        private System.Windows.Forms.Button startOfTurnButton;
        private System.Windows.Forms.CheckBox startOfTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button endOfTurnButton;
        private System.Windows.Forms.CheckBox endOfTurn;
        private System.Windows.Forms.Button stopOnTileButton;
        private System.Windows.Forms.CheckBox stopOnTile;
        private System.Windows.Forms.Button passOverButton;
        private System.Windows.Forms.CheckBox passOver;
        private System.Windows.Forms.CheckBox stopsRanged;
        private System.Windows.Forms.CheckBox stopsMelee;
    }
}