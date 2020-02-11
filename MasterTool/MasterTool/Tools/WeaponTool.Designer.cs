namespace MasterTool.Tools
{
    partial class WeaponTool
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
            this.removeWeapon = new System.Windows.Forms.Button();
            this.addWeapon = new System.Windows.Forms.Button();
            this.weaponList = new System.Windows.Forms.ListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.statList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addStat = new System.Windows.Forms.Button();
            this.removeStat = new System.Windows.Forms.Button();
            this.effectList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEffect = new System.Windows.Forms.Button();
            this.removeEffect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.weaponType = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellPriceCount = new System.Windows.Forms.NumericUpDown();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // removeWeapon
            // 
            this.removeWeapon.Location = new System.Drawing.Point(62, 281);
            this.removeWeapon.Margin = new System.Windows.Forms.Padding(4);
            this.removeWeapon.Name = "removeWeapon";
            this.removeWeapon.Size = new System.Drawing.Size(59, 28);
            this.removeWeapon.TabIndex = 13;
            this.removeWeapon.Text = "-";
            this.removeWeapon.UseVisualStyleBackColor = true;
            this.removeWeapon.Click += new System.EventHandler(this.RemoveWeapon_Click);
            // 
            // addWeapon
            // 
            this.addWeapon.Location = new System.Drawing.Point(3, 281);
            this.addWeapon.Margin = new System.Windows.Forms.Padding(4);
            this.addWeapon.Name = "addWeapon";
            this.addWeapon.Size = new System.Drawing.Size(59, 28);
            this.addWeapon.TabIndex = 12;
            this.addWeapon.Text = "+";
            this.addWeapon.UseVisualStyleBackColor = true;
            this.addWeapon.Click += new System.EventHandler(this.AddWeapon_Click);
            // 
            // weaponList
            // 
            this.weaponList.FormattingEnabled = true;
            this.weaponList.ItemHeight = 16;
            this.weaponList.Location = new System.Drawing.Point(3, 3);
            this.weaponList.Margin = new System.Windows.Forms.Padding(4);
            this.weaponList.Name = "weaponList";
            this.weaponList.Size = new System.Drawing.Size(116, 276);
            this.weaponList.TabIndex = 11;
            this.weaponList.SelectedIndexChanged += new System.EventHandler(this.WeaponList_SelectedIndexChanged);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.statList);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Controls.Add(this.addStat);
            this.backPanel.Controls.Add(this.removeStat);
            this.backPanel.Controls.Add(this.effectList);
            this.backPanel.Controls.Add(this.label6);
            this.backPanel.Controls.Add(this.addEffect);
            this.backPanel.Controls.Add(this.removeEffect);
            this.backPanel.Controls.Add(this.label5);
            this.backPanel.Controls.Add(this.weaponType);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.flavorTextBox);
            this.backPanel.Controls.Add(this.label4);
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.sellPriceCount);
            this.backPanel.Location = new System.Drawing.Point(127, 3);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(648, 305);
            this.backPanel.TabIndex = 14;
            // 
            // statList
            // 
            this.statList.FormattingEnabled = true;
            this.statList.ItemHeight = 16;
            this.statList.Location = new System.Drawing.Point(287, 32);
            this.statList.Margin = new System.Windows.Forms.Padding(4);
            this.statList.Name = "statList";
            this.statList.Size = new System.Drawing.Size(159, 228);
            this.statList.TabIndex = 46;
            this.statList.DoubleClick += new System.EventHandler(this.StatList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Stats";
            // 
            // addStat
            // 
            this.addStat.Location = new System.Drawing.Point(287, 259);
            this.addStat.Margin = new System.Windows.Forms.Padding(1);
            this.addStat.Name = "addStat";
            this.addStat.Size = new System.Drawing.Size(76, 28);
            this.addStat.TabIndex = 48;
            this.addStat.Text = "+";
            this.addStat.UseVisualStyleBackColor = true;
            this.addStat.Click += new System.EventHandler(this.AddStat_Click);
            // 
            // removeStat
            // 
            this.removeStat.Location = new System.Drawing.Point(371, 259);
            this.removeStat.Margin = new System.Windows.Forms.Padding(1);
            this.removeStat.Name = "removeStat";
            this.removeStat.Size = new System.Drawing.Size(77, 28);
            this.removeStat.TabIndex = 49;
            this.removeStat.Text = "-";
            this.removeStat.UseVisualStyleBackColor = true;
            this.removeStat.Click += new System.EventHandler(this.RemoveStat_Click);
            // 
            // effectList
            // 
            this.effectList.FormattingEnabled = true;
            this.effectList.ItemHeight = 16;
            this.effectList.Location = new System.Drawing.Point(469, 32);
            this.effectList.Margin = new System.Windows.Forms.Padding(4);
            this.effectList.Name = "effectList";
            this.effectList.Size = new System.Drawing.Size(159, 228);
            this.effectList.TabIndex = 42;
            this.effectList.DoubleClick += new System.EventHandler(this.EffectList_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Triggered Effects";
            // 
            // addEffect
            // 
            this.addEffect.Location = new System.Drawing.Point(469, 259);
            this.addEffect.Margin = new System.Windows.Forms.Padding(1);
            this.addEffect.Name = "addEffect";
            this.addEffect.Size = new System.Drawing.Size(76, 28);
            this.addEffect.TabIndex = 44;
            this.addEffect.Text = "+";
            this.addEffect.UseVisualStyleBackColor = true;
            this.addEffect.Click += new System.EventHandler(this.AddEffect_Click);
            // 
            // removeEffect
            // 
            this.removeEffect.Location = new System.Drawing.Point(553, 259);
            this.removeEffect.Margin = new System.Windows.Forms.Padding(1);
            this.removeEffect.Name = "removeEffect";
            this.removeEffect.Size = new System.Drawing.Size(77, 28);
            this.removeEffect.TabIndex = 45;
            this.removeEffect.Text = "-";
            this.removeEffect.UseVisualStyleBackColor = true;
            this.removeEffect.Click += new System.EventHandler(this.RemoveEffect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Weapon Type";
            // 
            // weaponType
            // 
            this.weaponType.FormattingEnabled = true;
            this.weaponType.Location = new System.Drawing.Point(106, 57);
            this.weaponType.Margin = new System.Windows.Forms.Padding(4);
            this.weaponType.Name = "weaponType";
            this.weaponType.Size = new System.Drawing.Size(160, 24);
            this.weaponType.TabIndex = 39;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(56, 14);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // flavorTextBox
            // 
            this.flavorTextBox.DetectUrls = false;
            this.flavorTextBox.Location = new System.Drawing.Point(5, 160);
            this.flavorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(232, 117);
            this.flavorTextBox.TabIndex = 8;
            this.flavorTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Flavor Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sell Price";
            // 
            // sellPriceCount
            // 
            this.sellPriceCount.Location = new System.Drawing.Point(77, 101);
            this.sellPriceCount.Margin = new System.Windows.Forms.Padding(4);
            this.sellPriceCount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.sellPriceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sellPriceCount.Name = "sellPriceCount";
            this.sellPriceCount.Size = new System.Drawing.Size(160, 22);
            this.sellPriceCount.TabIndex = 5;
            this.sellPriceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeaponTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 314);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.removeWeapon);
            this.Controls.Add(this.addWeapon);
            this.Controls.Add(this.weaponList);
            this.Name = "WeaponTool";
            this.Text = "WeaponTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WeaponTool_FormClosing);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeWeapon;
        private System.Windows.Forms.Button addWeapon;
        public System.Windows.Forms.ListBox weaponList;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox flavorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sellPriceCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox weaponType;
        private System.Windows.Forms.ListBox effectList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addEffect;
        private System.Windows.Forms.Button removeEffect;
        private System.Windows.Forms.ListBox statList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addStat;
        private System.Windows.Forms.Button removeStat;
    }
}