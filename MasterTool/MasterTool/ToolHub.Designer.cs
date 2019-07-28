namespace MasterTool
{
    partial class ToolHub
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
            this.ItemDefinitions = new System.Windows.Forms.Button();
            this.BattleItems = new System.Windows.Forms.Button();
            this.PlayerTemplates = new System.Windows.Forms.Button();
            this.EnemyDefinitions = new System.Windows.Forms.Button();
            this.WeaponTypes = new System.Windows.Forms.Button();
            this.TileTypes = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemDefinitions
            // 
            this.ItemDefinitions.Location = new System.Drawing.Point(12, 12);
            this.ItemDefinitions.Name = "ItemDefinitions";
            this.ItemDefinitions.Size = new System.Drawing.Size(100, 25);
            this.ItemDefinitions.TabIndex = 0;
            this.ItemDefinitions.Text = "Item Definitions";
            this.ItemDefinitions.UseVisualStyleBackColor = true;
            this.ItemDefinitions.Click += new System.EventHandler(this.ItemDefinitions_Click);
            // 
            // BattleItems
            // 
            this.BattleItems.Location = new System.Drawing.Point(118, 12);
            this.BattleItems.Name = "BattleItems";
            this.BattleItems.Size = new System.Drawing.Size(100, 25);
            this.BattleItems.TabIndex = 1;
            this.BattleItems.Text = "Battle Items";
            this.BattleItems.UseVisualStyleBackColor = true;
            this.BattleItems.Click += new System.EventHandler(this.BattleItems_Click);
            // 
            // PlayerTemplates
            // 
            this.PlayerTemplates.Location = new System.Drawing.Point(224, 12);
            this.PlayerTemplates.Name = "PlayerTemplates";
            this.PlayerTemplates.Size = new System.Drawing.Size(100, 25);
            this.PlayerTemplates.TabIndex = 2;
            this.PlayerTemplates.Text = "Player Templates";
            this.PlayerTemplates.UseVisualStyleBackColor = true;
            this.PlayerTemplates.Click += new System.EventHandler(this.PlayerTemplates_Click);
            // 
            // EnemyDefinitions
            // 
            this.EnemyDefinitions.Location = new System.Drawing.Point(12, 43);
            this.EnemyDefinitions.Name = "EnemyDefinitions";
            this.EnemyDefinitions.Size = new System.Drawing.Size(100, 25);
            this.EnemyDefinitions.TabIndex = 3;
            this.EnemyDefinitions.Text = "Enemy Definitions";
            this.EnemyDefinitions.UseVisualStyleBackColor = true;
            this.EnemyDefinitions.Click += new System.EventHandler(this.EnemyDefinitions_Click);
            // 
            // WeaponTypes
            // 
            this.WeaponTypes.Location = new System.Drawing.Point(118, 43);
            this.WeaponTypes.Name = "WeaponTypes";
            this.WeaponTypes.Size = new System.Drawing.Size(100, 25);
            this.WeaponTypes.TabIndex = 4;
            this.WeaponTypes.Text = "Weapon Types";
            this.WeaponTypes.UseVisualStyleBackColor = true;
            this.WeaponTypes.Click += new System.EventHandler(this.WeaponTypes_Click);
            // 
            // TileTypes
            // 
            this.TileTypes.Location = new System.Drawing.Point(224, 43);
            this.TileTypes.Name = "TileTypes";
            this.TileTypes.Size = new System.Drawing.Size(100, 25);
            this.TileTypes.TabIndex = 5;
            this.TileTypes.Text = "Tile Types";
            this.TileTypes.UseVisualStyleBackColor = true;
            this.TileTypes.Click += new System.EventHandler(this.TileTypes_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(132, 74);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ToolHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 106);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TileTypes);
            this.Controls.Add(this.WeaponTypes);
            this.Controls.Add(this.EnemyDefinitions);
            this.Controls.Add(this.PlayerTemplates);
            this.Controls.Add(this.BattleItems);
            this.Controls.Add(this.ItemDefinitions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolHub";
            this.Text = "TRPG Tool Hub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ItemDefinitions;
        private System.Windows.Forms.Button BattleItems;
        private System.Windows.Forms.Button PlayerTemplates;
        private System.Windows.Forms.Button EnemyDefinitions;
        private System.Windows.Forms.Button TileTypes;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button WeaponTypes;
    }
}

