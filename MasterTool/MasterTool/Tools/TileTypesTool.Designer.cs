﻿namespace MasterTool.Tools
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            this.startOfTurn = new System.Windows.Forms.CheckBox();
            this.startOfTurnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passOverButton = new System.Windows.Forms.Button();
            this.passOver = new System.Windows.Forms.CheckBox();
            this.stopOnTileButton = new System.Windows.Forms.Button();
            this.stopOnTile = new System.Windows.Forms.CheckBox();
            this.endOfTurnButton = new System.Windows.Forms.Button();
            this.endOfTurn = new System.Windows.Forms.CheckBox();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeTileType
            // 
            this.removeTileType.Location = new System.Drawing.Point(63, 282);
            this.removeTileType.Margin = new System.Windows.Forms.Padding(4);
            this.removeTileType.Name = "removeTileType";
            this.removeTileType.Size = new System.Drawing.Size(59, 28);
            this.removeTileType.TabIndex = 34;
            this.removeTileType.Text = "-";
            this.removeTileType.UseVisualStyleBackColor = true;
            this.removeTileType.Click += new System.EventHandler(this.RemoveTileType_Click);
            // 
            // addTileType
            // 
            this.addTileType.Location = new System.Drawing.Point(4, 282);
            this.addTileType.Margin = new System.Windows.Forms.Padding(4);
            this.addTileType.Name = "addTileType";
            this.addTileType.Size = new System.Drawing.Size(59, 28);
            this.addTileType.TabIndex = 33;
            this.addTileType.Text = "+";
            this.addTileType.UseVisualStyleBackColor = true;
            this.addTileType.Click += new System.EventHandler(this.AddTileType_Click);
            // 
            // tileList
            // 
            this.tileList.FormattingEnabled = true;
            this.tileList.ItemHeight = 16;
            this.tileList.Location = new System.Drawing.Point(4, 4);
            this.tileList.Margin = new System.Windows.Forms.Padding(4);
            this.tileList.Name = "tileList";
            this.tileList.Size = new System.Drawing.Size(116, 276);
            this.tileList.TabIndex = 32;
            this.tileList.SelectedIndexChanged += new System.EventHandler(this.TileList_SelectedIndexChanged);
            // 
            // backPanel
            // 
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
            this.backPanel.Location = new System.Drawing.Point(127, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(487, 306);
            this.backPanel.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(94, 9);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Flavor Text";
            // 
            // flavorTextBox
            // 
            this.flavorTextBox.DetectUrls = false;
            this.flavorTextBox.Location = new System.Drawing.Point(4, 70);
            this.flavorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flavorTextBox.Multiline = false;
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(232, 155);
            this.flavorTextBox.TabIndex = 37;
            this.flavorTextBox.Text = "";
            // 
            // startOfTurn
            // 
            this.startOfTurn.AutoSize = true;
            this.startOfTurn.Location = new System.Drawing.Point(256, 38);
            this.startOfTurn.Name = "startOfTurn";
            this.startOfTurn.Size = new System.Drawing.Size(110, 21);
            this.startOfTurn.TabIndex = 38;
            this.startOfTurn.Text = "Start of Turn";
            this.startOfTurn.UseVisualStyleBackColor = true;
            this.startOfTurn.CheckedChanged += new System.EventHandler(this.StartOfTurn_CheckedChanged);
            // 
            // startOfTurnButton
            // 
            this.startOfTurnButton.Enabled = false;
            this.startOfTurnButton.Location = new System.Drawing.Point(372, 30);
            this.startOfTurnButton.Name = "startOfTurnButton";
            this.startOfTurnButton.Size = new System.Drawing.Size(90, 35);
            this.startOfTurnButton.TabIndex = 39;
            this.startOfTurnButton.Text = "Edit Effect";
            this.startOfTurnButton.UseVisualStyleBackColor = true;
            this.startOfTurnButton.Click += new System.EventHandler(this.StartOfTurnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Effects";
            // 
            // passOverButton
            // 
            this.passOverButton.Enabled = false;
            this.passOverButton.Location = new System.Drawing.Point(372, 83);
            this.passOverButton.Name = "passOverButton";
            this.passOverButton.Size = new System.Drawing.Size(90, 35);
            this.passOverButton.TabIndex = 42;
            this.passOverButton.Text = "Edit Effect";
            this.passOverButton.UseVisualStyleBackColor = true;
            this.passOverButton.Click += new System.EventHandler(this.PassOverButton_Click);
            // 
            // passOver
            // 
            this.passOver.AutoSize = true;
            this.passOver.Location = new System.Drawing.Point(256, 91);
            this.passOver.Name = "passOver";
            this.passOver.Size = new System.Drawing.Size(96, 21);
            this.passOver.TabIndex = 41;
            this.passOver.Text = "Pass Over";
            this.passOver.UseVisualStyleBackColor = true;
            this.passOver.CheckedChanged += new System.EventHandler(this.PassOver_CheckedChanged);
            // 
            // stopOnTileButton
            // 
            this.stopOnTileButton.Enabled = false;
            this.stopOnTileButton.Location = new System.Drawing.Point(372, 135);
            this.stopOnTileButton.Name = "stopOnTileButton";
            this.stopOnTileButton.Size = new System.Drawing.Size(90, 35);
            this.stopOnTileButton.TabIndex = 44;
            this.stopOnTileButton.Text = "Edit Effect";
            this.stopOnTileButton.UseVisualStyleBackColor = true;
            this.stopOnTileButton.Click += new System.EventHandler(this.StopOnTileButton_Click);
            // 
            // stopOnTile
            // 
            this.stopOnTile.AutoSize = true;
            this.stopOnTile.Location = new System.Drawing.Point(256, 143);
            this.stopOnTile.Name = "stopOnTile";
            this.stopOnTile.Size = new System.Drawing.Size(106, 21);
            this.stopOnTile.TabIndex = 43;
            this.stopOnTile.Text = "Stop on Tile";
            this.stopOnTile.UseVisualStyleBackColor = true;
            this.stopOnTile.CheckedChanged += new System.EventHandler(this.StopOnTile_CheckedChanged);
            // 
            // endOfTurnButton
            // 
            this.endOfTurnButton.Enabled = false;
            this.endOfTurnButton.Location = new System.Drawing.Point(372, 190);
            this.endOfTurnButton.Name = "endOfTurnButton";
            this.endOfTurnButton.Size = new System.Drawing.Size(90, 35);
            this.endOfTurnButton.TabIndex = 46;
            this.endOfTurnButton.Text = "Edit Effect";
            this.endOfTurnButton.UseVisualStyleBackColor = true;
            this.endOfTurnButton.Click += new System.EventHandler(this.EndOfTurnButton_Click);
            // 
            // endOfTurn
            // 
            this.endOfTurn.AutoSize = true;
            this.endOfTurn.Location = new System.Drawing.Point(256, 198);
            this.endOfTurn.Name = "endOfTurn";
            this.endOfTurn.Size = new System.Drawing.Size(105, 21);
            this.endOfTurn.TabIndex = 45;
            this.endOfTurn.Text = "End of Turn";
            this.endOfTurn.UseVisualStyleBackColor = true;
            this.endOfTurn.CheckedChanged += new System.EventHandler(this.EndOfTurn_CheckedChanged);
            // 
            // TileTypesTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 321);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.removeTileType);
            this.Controls.Add(this.addTileType);
            this.Controls.Add(this.tileList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TileTypesTool";
            this.Text = "Tile Types";
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
    }
}