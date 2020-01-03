namespace MasterTool.Tools
{
    partial class EquipmentTool
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
            this.weightClass = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellPriceCount = new System.Windows.Forms.NumericUpDown();
            this.removeEquipment = new System.Windows.Forms.Button();
            this.addEquipment = new System.Windows.Forms.Button();
            this.equipmentList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.equipSlot = new System.Windows.Forms.ComboBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.label7);
            this.backPanel.Controls.Add(this.equipSlot);
            this.backPanel.Controls.Add(this.statList);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Controls.Add(this.addStat);
            this.backPanel.Controls.Add(this.removeStat);
            this.backPanel.Controls.Add(this.effectList);
            this.backPanel.Controls.Add(this.label6);
            this.backPanel.Controls.Add(this.addEffect);
            this.backPanel.Controls.Add(this.removeEffect);
            this.backPanel.Controls.Add(this.label5);
            this.backPanel.Controls.Add(this.weightClass);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.flavorTextBox);
            this.backPanel.Controls.Add(this.label4);
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.sellPriceCount);
            this.backPanel.Location = new System.Drawing.Point(127, 4);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(621, 305);
            this.backPanel.TabIndex = 18;
            // 
            // statList
            // 
            this.statList.FormattingEnabled = true;
            this.statList.ItemHeight = 16;
            this.statList.Location = new System.Drawing.Point(270, 28);
            this.statList.Margin = new System.Windows.Forms.Padding(4);
            this.statList.Name = "statList";
            this.statList.Size = new System.Drawing.Size(159, 228);
            this.statList.TabIndex = 46;
            this.statList.DoubleClick += new System.EventHandler(this.StatList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Stats";
            // 
            // addStat
            // 
            this.addStat.Location = new System.Drawing.Point(270, 255);
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
            this.removeStat.Location = new System.Drawing.Point(354, 255);
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
            this.effectList.Location = new System.Drawing.Point(452, 28);
            this.effectList.Margin = new System.Windows.Forms.Padding(4);
            this.effectList.Name = "effectList";
            this.effectList.Size = new System.Drawing.Size(159, 228);
            this.effectList.TabIndex = 42;
            this.effectList.DoubleClick += new System.EventHandler(this.EffectList_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Triggered Effects";
            // 
            // addEffect
            // 
            this.addEffect.Location = new System.Drawing.Point(452, 255);
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
            this.removeEffect.Location = new System.Drawing.Point(536, 255);
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
            this.label5.Location = new System.Drawing.Point(1, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Weight Class";
            // 
            // weightClass
            // 
            this.weightClass.FormattingEnabled = true;
            this.weightClass.Items.AddRange(new object[] {
            "Heavy",
            "Medium",
            "Light"});
            this.weightClass.Location = new System.Drawing.Point(99, 76);
            this.weightClass.Margin = new System.Windows.Forms.Padding(4);
            this.weightClass.Name = "weightClass";
            this.weightClass.Size = new System.Drawing.Size(160, 24);
            this.weightClass.TabIndex = 39;
            this.weightClass.Text = "Heavy";
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
            this.flavorTextBox.Location = new System.Drawing.Point(5, 166);
            this.flavorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flavorTextBox.Multiline = false;
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(232, 117);
            this.flavorTextBox.TabIndex = 8;
            this.flavorTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Flavor Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sell Price";
            // 
            // sellPriceCount
            // 
            this.sellPriceCount.Location = new System.Drawing.Point(77, 108);
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
            // removeEquipment
            // 
            this.removeEquipment.Location = new System.Drawing.Point(62, 282);
            this.removeEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.removeEquipment.Name = "removeEquipment";
            this.removeEquipment.Size = new System.Drawing.Size(59, 28);
            this.removeEquipment.TabIndex = 17;
            this.removeEquipment.Text = "-";
            this.removeEquipment.UseVisualStyleBackColor = true;
            this.removeEquipment.Click += new System.EventHandler(this.RemoveEquipment_Click);
            // 
            // addEquipment
            // 
            this.addEquipment.Location = new System.Drawing.Point(3, 282);
            this.addEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.addEquipment.Name = "addEquipment";
            this.addEquipment.Size = new System.Drawing.Size(59, 28);
            this.addEquipment.TabIndex = 16;
            this.addEquipment.Text = "+";
            this.addEquipment.UseVisualStyleBackColor = true;
            this.addEquipment.Click += new System.EventHandler(this.AddEquipment_Click);
            // 
            // equipmentList
            // 
            this.equipmentList.FormattingEnabled = true;
            this.equipmentList.ItemHeight = 16;
            this.equipmentList.Location = new System.Drawing.Point(3, 4);
            this.equipmentList.Margin = new System.Windows.Forms.Padding(4);
            this.equipmentList.Name = "equipmentList";
            this.equipmentList.Size = new System.Drawing.Size(116, 276);
            this.equipmentList.TabIndex = 15;
            this.equipmentList.SelectedIndexChanged += new System.EventHandler(this.EquipmentList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Equip Slot";
            // 
            // equipSlot
            // 
            this.equipSlot.FormattingEnabled = true;
            this.equipSlot.Items.AddRange(new object[] {
            "Helmet",
            "Chestplate",
            "Legs",
            "Boots",
            "Gloves",
            "Accessories"});
            this.equipSlot.Location = new System.Drawing.Point(81, 44);
            this.equipSlot.Margin = new System.Windows.Forms.Padding(4);
            this.equipSlot.Name = "equipSlot";
            this.equipSlot.Size = new System.Drawing.Size(160, 24);
            this.equipSlot.TabIndex = 51;
            this.equipSlot.Text = "Helmet";
            // 
            // EquipmentTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 313);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.removeEquipment);
            this.Controls.Add(this.addEquipment);
            this.Controls.Add(this.equipmentList);
            this.Name = "EquipmentTool";
            this.Text = "EquipmentTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EquipmentTool_FormClosing);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.ListBox statList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addStat;
        private System.Windows.Forms.Button removeStat;
        private System.Windows.Forms.ListBox effectList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addEffect;
        private System.Windows.Forms.Button removeEffect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox weightClass;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox flavorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sellPriceCount;
        private System.Windows.Forms.Button removeEquipment;
        private System.Windows.Forms.Button addEquipment;
        public System.Windows.Forms.ListBox equipmentList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox equipSlot;
    }
}