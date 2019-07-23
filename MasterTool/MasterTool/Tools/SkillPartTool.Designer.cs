namespace MasterTool.Tools
{
    partial class SkillPartTool
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
            this.typeSelector = new System.Windows.Forms.ComboBox();
            this.targetType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.addTriggerBox = new System.Windows.Forms.GroupBox();
            this.removeEffect = new System.Windows.Forms.Button();
            this.addEffect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.effectList = new System.Windows.Forms.ListBox();
            this.activeTurnCount = new System.Windows.Forms.NumericUpDown();
            this.activeTurns = new System.Windows.Forms.CheckBox();
            this.cooldownCount = new System.Windows.Forms.NumericUpDown();
            this.turnCD = new System.Windows.Forms.CheckBox();
            this.timesPerBattle = new System.Windows.Forms.CheckBox();
            this.timesPerBattleCount = new System.Windows.Forms.NumericUpDown();
            this.addTriggerTrigger = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chance)).BeginInit();
            this.addTriggerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeTurnCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesPerBattleCount)).BeginInit();
            this.SuspendLayout();
            // 
            // typeSelector
            // 
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Add Trigger",
            "Damage",
            "Heal",
            "Stat Change",
            "Movement",
            "Status Effect",
            "Unique Effect"});
            this.typeSelector.Location = new System.Drawing.Point(12, 28);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(121, 21);
            this.typeSelector.TabIndex = 0;
            this.typeSelector.Text = "Add Trigger";
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
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
            this.targetType.Location = new System.Drawing.Point(12, 77);
            this.targetType.Name = "targetType";
            this.targetType.Size = new System.Drawing.Size(121, 21);
            this.targetType.TabIndex = 0;
            this.targetType.Text = "All";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Effect Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Targetting Type";
            // 
            // chance
            // 
            this.chance.Location = new System.Drawing.Point(12, 130);
            this.chance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chance.Name = "chance";
            this.chance.Size = new System.Drawing.Size(120, 20);
            this.chance.TabIndex = 4;
            this.chance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proc Chance";
            // 
            // addTriggerBox
            // 
            this.addTriggerBox.Controls.Add(this.removeEffect);
            this.addTriggerBox.Controls.Add(this.addEffect);
            this.addTriggerBox.Controls.Add(this.label5);
            this.addTriggerBox.Controls.Add(this.effectList);
            this.addTriggerBox.Controls.Add(this.activeTurnCount);
            this.addTriggerBox.Controls.Add(this.activeTurns);
            this.addTriggerBox.Controls.Add(this.cooldownCount);
            this.addTriggerBox.Controls.Add(this.turnCD);
            this.addTriggerBox.Controls.Add(this.timesPerBattle);
            this.addTriggerBox.Controls.Add(this.timesPerBattleCount);
            this.addTriggerBox.Controls.Add(this.addTriggerTrigger);
            this.addTriggerBox.Controls.Add(this.label4);
            this.addTriggerBox.Location = new System.Drawing.Point(139, 12);
            this.addTriggerBox.Name = "addTriggerBox";
            this.addTriggerBox.Size = new System.Drawing.Size(268, 237);
            this.addTriggerBox.TabIndex = 6;
            this.addTriggerBox.TabStop = false;
            this.addTriggerBox.Text = "Add Trigger Effect";
            // 
            // removeEffect
            // 
            this.removeEffect.Location = new System.Drawing.Point(69, 208);
            this.removeEffect.Margin = new System.Windows.Forms.Padding(1);
            this.removeEffect.Name = "removeEffect";
            this.removeEffect.Size = new System.Drawing.Size(58, 23);
            this.removeEffect.TabIndex = 16;
            this.removeEffect.Text = "-";
            this.removeEffect.UseVisualStyleBackColor = true;
            this.removeEffect.Click += new System.EventHandler(this.removeEffect_Click);
            // 
            // addEffect
            // 
            this.addEffect.Location = new System.Drawing.Point(6, 208);
            this.addEffect.Margin = new System.Windows.Forms.Padding(1);
            this.addEffect.Name = "addEffect";
            this.addEffect.Size = new System.Drawing.Size(57, 23);
            this.addEffect.TabIndex = 15;
            this.addEffect.Text = "+";
            this.addEffect.UseVisualStyleBackColor = true;
            this.addEffect.Click += new System.EventHandler(this.addEffect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Effects";
            // 
            // effectList
            // 
            this.effectList.FormattingEnabled = true;
            this.effectList.Location = new System.Drawing.Point(6, 88);
            this.effectList.Name = "effectList";
            this.effectList.Size = new System.Drawing.Size(120, 121);
            this.effectList.TabIndex = 7;
            this.effectList.DoubleClick += new System.EventHandler(this.effectList_DoubleClick);
            // 
            // activeTurnCount
            // 
            this.activeTurnCount.Location = new System.Drawing.Point(142, 153);
            this.activeTurnCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.activeTurnCount.Name = "activeTurnCount";
            this.activeTurnCount.Size = new System.Drawing.Size(120, 20);
            this.activeTurnCount.TabIndex = 13;
            this.activeTurnCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // activeTurns
            // 
            this.activeTurns.AutoSize = true;
            this.activeTurns.Location = new System.Drawing.Point(142, 130);
            this.activeTurns.Name = "activeTurns";
            this.activeTurns.Size = new System.Drawing.Size(86, 17);
            this.activeTurns.TabIndex = 12;
            this.activeTurns.Text = "Active Turns";
            this.activeTurns.UseVisualStyleBackColor = true;
            // 
            // cooldownCount
            // 
            this.cooldownCount.Location = new System.Drawing.Point(142, 88);
            this.cooldownCount.Name = "cooldownCount";
            this.cooldownCount.Size = new System.Drawing.Size(120, 20);
            this.cooldownCount.TabIndex = 11;
            // 
            // turnCD
            // 
            this.turnCD.AutoSize = true;
            this.turnCD.Location = new System.Drawing.Point(142, 69);
            this.turnCD.Name = "turnCD";
            this.turnCD.Size = new System.Drawing.Size(98, 17);
            this.turnCD.TabIndex = 10;
            this.turnCD.Text = "Turn Cooldown";
            this.turnCD.UseVisualStyleBackColor = true;
            // 
            // timesPerBattle
            // 
            this.timesPerBattle.AutoSize = true;
            this.timesPerBattle.Location = new System.Drawing.Point(142, 15);
            this.timesPerBattle.Name = "timesPerBattle";
            this.timesPerBattle.Size = new System.Drawing.Size(120, 17);
            this.timesPerBattle.TabIndex = 9;
            this.timesPerBattle.Text = "Max times per battle";
            this.timesPerBattle.UseVisualStyleBackColor = true;
            // 
            // timesPerBattleCount
            // 
            this.timesPerBattleCount.Location = new System.Drawing.Point(142, 32);
            this.timesPerBattleCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timesPerBattleCount.Name = "timesPerBattleCount";
            this.timesPerBattleCount.Size = new System.Drawing.Size(120, 20);
            this.timesPerBattleCount.TabIndex = 7;
            this.timesPerBattleCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addTriggerTrigger
            // 
            this.addTriggerTrigger.FormattingEnabled = true;
            this.addTriggerTrigger.Items.AddRange(new object[] {
            "Fall Below 25%",
            "Fall Below 50%",
            "Rise Above 25%",
            "Rise Above 50%",
            "Take Damage",
            "Deal Damage",
            "Take Physical Damage",
            "Deal Physical Damage",
            "Take Magic Damage",
            "Deal Magic Damage",
            "Basic Attack",
            "Hit with Basic Attack",
            "Spell Cast",
            "Deal Spell Damage",
            "Heal with Spell",
            "Kill an Enemy",
            "Die",
            "Getting Healed",
            "Healing",
            "Start of Match",
            "Start of Turn",
            "End of Turn",
            "End of Match"});
            this.addTriggerTrigger.Location = new System.Drawing.Point(6, 32);
            this.addTriggerTrigger.Name = "addTriggerTrigger";
            this.addTriggerTrigger.Size = new System.Drawing.Size(121, 21);
            this.addTriggerTrigger.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trigger";
            // 
            // SkillPartTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.addTriggerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetType);
            this.Controls.Add(this.typeSelector);
            this.Name = "SkillPartTool";
            this.Text = "Skill Part";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillPartTool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chance)).EndInit();
            this.addTriggerBox.ResumeLayout(false);
            this.addTriggerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeTurnCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesPerBattleCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox typeSelector;
        private System.Windows.Forms.ComboBox targetType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown chance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown activeTurnCount;
        private System.Windows.Forms.CheckBox activeTurns;
        private System.Windows.Forms.NumericUpDown cooldownCount;
        private System.Windows.Forms.CheckBox turnCD;
        private System.Windows.Forms.CheckBox timesPerBattle;
        private System.Windows.Forms.NumericUpDown timesPerBattleCount;
        private System.Windows.Forms.ComboBox addTriggerTrigger;
        private System.Windows.Forms.Button removeEffect;
        private System.Windows.Forms.Button addEffect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox effectList;
        private System.Windows.Forms.GroupBox addTriggerBox;
    }
}