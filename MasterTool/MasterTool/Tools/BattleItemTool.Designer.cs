namespace MasterTool.Tools
{
    partial class BattleItemTool
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
            this.removeItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListBox();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellPriceCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.maxStackCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.targetType = new System.Windows.Forms.ComboBox();
            this.useableOutOfBattle = new System.Windows.Forms.CheckBox();
            this.removeEffect = new System.Windows.Forms.Button();
            this.addEffect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.effectList = new System.Windows.Forms.ListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxStackCount)).BeginInit();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(46, 228);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(44, 23);
            this.removeItem.TabIndex = 13;
            this.removeItem.Text = "-";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(2, 228);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(44, 23);
            this.addItem.TabIndex = 12;
            this.addItem.Text = "+";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(2, 2);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(88, 225);
            this.itemList.TabIndex = 11;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // flavorTextBox
            // 
            this.flavorTextBox.DetectUrls = false;
            this.flavorTextBox.Location = new System.Drawing.Point(5, 128);
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(175, 96);
            this.flavorTextBox.TabIndex = 21;
            this.flavorTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Flavor Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sell Price";
            // 
            // sellPriceCount
            // 
            this.sellPriceCount.Location = new System.Drawing.Point(59, 80);
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
            this.sellPriceCount.Size = new System.Drawing.Size(120, 20);
            this.sellPriceCount.TabIndex = 18;
            this.sellPriceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Max Stack";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(43, 9);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 16;
            // 
            // maxStackCount
            // 
            this.maxStackCount.Location = new System.Drawing.Point(60, 45);
            this.maxStackCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxStackCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxStackCount.Name = "maxStackCount";
            this.maxStackCount.Size = new System.Drawing.Size(120, 20);
            this.maxStackCount.TabIndex = 15;
            this.maxStackCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Targetting Type";
            // 
            // targetType
            // 
            this.targetType.FormattingEnabled = true;
            this.targetType.Items.AddRange(new object[] {
            "Self",
            "Ally",
            "Enemy",
            "All In Range",
            "All Allies",
            "All Allies Except Self",
            "All Enemies"});
            this.targetType.Location = new System.Drawing.Point(286, 8);
            this.targetType.Name = "targetType";
            this.targetType.Size = new System.Drawing.Size(121, 21);
            this.targetType.TabIndex = 23;
            this.targetType.Text = "Self";
            // 
            // useableOutOfBattle
            // 
            this.useableOutOfBattle.AutoSize = true;
            this.useableOutOfBattle.Location = new System.Drawing.Point(200, 46);
            this.useableOutOfBattle.Name = "useableOutOfBattle";
            this.useableOutOfBattle.Size = new System.Drawing.Size(142, 17);
            this.useableOutOfBattle.TabIndex = 24;
            this.useableOutOfBattle.Text = "Usable outside of battles";
            this.useableOutOfBattle.UseVisualStyleBackColor = true;
            // 
            // removeEffect
            // 
            this.removeEffect.Location = new System.Drawing.Point(261, 215);
            this.removeEffect.Margin = new System.Windows.Forms.Padding(1);
            this.removeEffect.Name = "removeEffect";
            this.removeEffect.Size = new System.Drawing.Size(58, 23);
            this.removeEffect.TabIndex = 28;
            this.removeEffect.Text = "-";
            this.removeEffect.UseVisualStyleBackColor = true;
            this.removeEffect.Click += new System.EventHandler(this.removeEffect_Click);
            // 
            // addEffect
            // 
            this.addEffect.Location = new System.Drawing.Point(198, 215);
            this.addEffect.Margin = new System.Windows.Forms.Padding(1);
            this.addEffect.Name = "addEffect";
            this.addEffect.Size = new System.Drawing.Size(57, 23);
            this.addEffect.TabIndex = 27;
            this.addEffect.Text = "+";
            this.addEffect.UseVisualStyleBackColor = true;
            this.addEffect.Click += new System.EventHandler(this.addEffect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Effects";
            // 
            // effectList
            // 
            this.effectList.FormattingEnabled = true;
            this.effectList.Location = new System.Drawing.Point(198, 95);
            this.effectList.Name = "effectList";
            this.effectList.Size = new System.Drawing.Size(120, 121);
            this.effectList.TabIndex = 25;
            this.effectList.DoubleClick += new System.EventHandler(this.effectList_DoubleClick);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.removeEffect);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.addEffect);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.label6);
            this.backPanel.Controls.Add(this.maxStackCount);
            this.backPanel.Controls.Add(this.effectList);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Controls.Add(this.useableOutOfBattle);
            this.backPanel.Controls.Add(this.sellPriceCount);
            this.backPanel.Controls.Add(this.targetType);
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.label5);
            this.backPanel.Controls.Add(this.label4);
            this.backPanel.Controls.Add(this.flavorTextBox);
            this.backPanel.Location = new System.Drawing.Point(96, 3);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(412, 248);
            this.backPanel.TabIndex = 29;
            // 
            // BattleItemTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 255);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.backPanel);
            this.Name = "BattleItemTool";
            this.Text = "BattleItemTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BattleItemTool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxStackCount)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button addItem;
        public System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.RichTextBox flavorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sellPriceCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.NumericUpDown maxStackCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox targetType;
        private System.Windows.Forms.CheckBox useableOutOfBattle;
        private System.Windows.Forms.Button removeEffect;
        private System.Windows.Forms.Button addEffect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox effectList;
        private System.Windows.Forms.Panel backPanel;
    }
}