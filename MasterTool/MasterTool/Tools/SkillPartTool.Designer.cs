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
            this.damageEffectBox = new System.Windows.Forms.GroupBox();
            this.healBox = new System.Windows.Forms.GroupBox();
            this.healingModByValue = new System.Windows.Forms.CheckBox();
            this.healingModifiedValue = new System.Windows.Forms.NumericUpDown();
            this.maxHPHeal = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.flatHealValue = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.healValue = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.damageModByValue = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.damageType = new System.Windows.Forms.ComboBox();
            this.damageModifiedValue = new System.Windows.Forms.NumericUpDown();
            this.missingHpPercent = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.maxHpPercent = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.flatDamageValue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.damageValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
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
            this.movementBox = new System.Windows.Forms.GroupBox();
            this.movementForced = new System.Windows.Forms.CheckBox();
            this.moveDistance = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.moveType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statChangeBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.statToChange = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.flatStatChange = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.statMultiplier = new System.Windows.Forms.NumericUpDown();
            this.statDurationTracked = new System.Windows.Forms.CheckBox();
            this.statDuration = new System.Windows.Forms.NumericUpDown();
            this.statusEffectBox = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.statusEffectType = new System.Windows.Forms.ComboBox();
            this.addEffectChoice = new System.Windows.Forms.RadioButton();
            this.removeEffectChoice = new System.Windows.Forms.RadioButton();
            this.uniqueEffectBox = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.uniqueEffectType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chance)).BeginInit();
            this.addTriggerBox.SuspendLayout();
            this.damageEffectBox.SuspendLayout();
            this.healBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healingModifiedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHPHeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHealValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageModifiedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingHpPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHpPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatDamageValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeTurnCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesPerBattleCount)).BeginInit();
            this.movementBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveDistance)).BeginInit();
            this.statChangeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatStatChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDuration)).BeginInit();
            this.statusEffectBox.SuspendLayout();
            this.uniqueEffectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeSelector
            // 
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Add Trigger",
            "Damage",
            "Healing",
            "Movement",
            "Stat Change",
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
            this.addTriggerBox.Controls.Add(this.damageEffectBox);
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
            // damageEffectBox
            // 
            this.damageEffectBox.Controls.Add(this.healBox);
            this.damageEffectBox.Controls.Add(this.damageModByValue);
            this.damageEffectBox.Controls.Add(this.label11);
            this.damageEffectBox.Controls.Add(this.damageType);
            this.damageEffectBox.Controls.Add(this.damageModifiedValue);
            this.damageEffectBox.Controls.Add(this.missingHpPercent);
            this.damageEffectBox.Controls.Add(this.label9);
            this.damageEffectBox.Controls.Add(this.maxHpPercent);
            this.damageEffectBox.Controls.Add(this.label8);
            this.damageEffectBox.Controls.Add(this.flatDamageValue);
            this.damageEffectBox.Controls.Add(this.label7);
            this.damageEffectBox.Controls.Add(this.damageValue);
            this.damageEffectBox.Controls.Add(this.label6);
            this.damageEffectBox.Location = new System.Drawing.Point(0, 0);
            this.damageEffectBox.Name = "damageEffectBox";
            this.damageEffectBox.Size = new System.Drawing.Size(268, 237);
            this.damageEffectBox.TabIndex = 7;
            this.damageEffectBox.TabStop = false;
            this.damageEffectBox.Text = "Damage Effect";
            // 
            // healBox
            // 
            this.healBox.Controls.Add(this.healingModByValue);
            this.healBox.Controls.Add(this.healingModifiedValue);
            this.healBox.Controls.Add(this.maxHPHeal);
            this.healBox.Controls.Add(this.label14);
            this.healBox.Controls.Add(this.flatHealValue);
            this.healBox.Controls.Add(this.label13);
            this.healBox.Controls.Add(this.healValue);
            this.healBox.Controls.Add(this.label12);
            this.healBox.Location = new System.Drawing.Point(0, 0);
            this.healBox.Name = "healBox";
            this.healBox.Size = new System.Drawing.Size(268, 236);
            this.healBox.TabIndex = 7;
            this.healBox.TabStop = false;
            this.healBox.Text = "Heal Effect";
            // 
            // healingModByValue
            // 
            this.healingModByValue.AutoSize = true;
            this.healingModByValue.Location = new System.Drawing.Point(142, 66);
            this.healingModByValue.Name = "healingModByValue";
            this.healingModByValue.Size = new System.Drawing.Size(110, 17);
            this.healingModByValue.TabIndex = 7;
            this.healingModByValue.Text = "Modified by Value";
            this.healingModByValue.UseVisualStyleBackColor = true;
            // 
            // healingModifiedValue
            // 
            this.healingModifiedValue.DecimalPlaces = 2;
            this.healingModifiedValue.Location = new System.Drawing.Point(142, 83);
            this.healingModifiedValue.Name = "healingModifiedValue";
            this.healingModifiedValue.Size = new System.Drawing.Size(120, 20);
            this.healingModifiedValue.TabIndex = 6;
            // 
            // maxHPHeal
            // 
            this.maxHPHeal.DecimalPlaces = 2;
            this.maxHPHeal.Location = new System.Drawing.Point(142, 34);
            this.maxHPHeal.Name = "maxHPHeal";
            this.maxHPHeal.Size = new System.Drawing.Size(120, 20);
            this.maxHPHeal.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Max HP Percent";
            // 
            // flatHealValue
            // 
            this.flatHealValue.Location = new System.Drawing.Point(6, 83);
            this.flatHealValue.Name = "flatHealValue";
            this.flatHealValue.Size = new System.Drawing.Size(120, 20);
            this.flatHealValue.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Flat Heal";
            // 
            // healValue
            // 
            this.healValue.Location = new System.Drawing.Point(6, 34);
            this.healValue.Name = "healValue";
            this.healValue.Size = new System.Drawing.Size(120, 20);
            this.healValue.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Heal";
            // 
            // damageModByValue
            // 
            this.damageModByValue.AutoSize = true;
            this.damageModByValue.Location = new System.Drawing.Point(142, 64);
            this.damageModByValue.Name = "damageModByValue";
            this.damageModByValue.Size = new System.Drawing.Size(110, 17);
            this.damageModByValue.TabIndex = 7;
            this.damageModByValue.Text = "Modified by Value";
            this.damageModByValue.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Damage Type";
            // 
            // damageType
            // 
            this.damageType.FormattingEnabled = true;
            this.damageType.Items.AddRange(new object[] {
            "Physical",
            "Magical"});
            this.damageType.Location = new System.Drawing.Point(142, 133);
            this.damageType.Name = "damageType";
            this.damageType.Size = new System.Drawing.Size(121, 21);
            this.damageType.TabIndex = 17;
            this.damageType.Text = "Physical";
            // 
            // damageModifiedValue
            // 
            this.damageModifiedValue.DecimalPlaces = 2;
            this.damageModifiedValue.Location = new System.Drawing.Point(142, 81);
            this.damageModifiedValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.damageModifiedValue.Name = "damageModifiedValue";
            this.damageModifiedValue.Size = new System.Drawing.Size(120, 20);
            this.damageModifiedValue.TabIndex = 15;
            // 
            // missingHpPercent
            // 
            this.missingHpPercent.DecimalPlaces = 2;
            this.missingHpPercent.Location = new System.Drawing.Point(142, 35);
            this.missingHpPercent.Name = "missingHpPercent";
            this.missingHpPercent.Size = new System.Drawing.Size(120, 20);
            this.missingHpPercent.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Missing HP Percent";
            // 
            // maxHpPercent
            // 
            this.maxHpPercent.DecimalPlaces = 2;
            this.maxHpPercent.Location = new System.Drawing.Point(6, 134);
            this.maxHpPercent.Name = "maxHpPercent";
            this.maxHpPercent.Size = new System.Drawing.Size(120, 20);
            this.maxHpPercent.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Max HP Percent";
            // 
            // flatDamageValue
            // 
            this.flatDamageValue.Location = new System.Drawing.Point(6, 81);
            this.flatDamageValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.flatDamageValue.Name = "flatDamageValue";
            this.flatDamageValue.Size = new System.Drawing.Size(120, 20);
            this.flatDamageValue.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Flat Damage";
            // 
            // damageValue
            // 
            this.damageValue.Location = new System.Drawing.Point(6, 35);
            this.damageValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.damageValue.Name = "damageValue";
            this.damageValue.Size = new System.Drawing.Size(120, 20);
            this.damageValue.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Damage";
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
            // movementBox
            // 
            this.movementBox.Controls.Add(this.movementForced);
            this.movementBox.Controls.Add(this.moveDistance);
            this.movementBox.Controls.Add(this.label15);
            this.movementBox.Controls.Add(this.moveType);
            this.movementBox.Controls.Add(this.label10);
            this.movementBox.Location = new System.Drawing.Point(139, 12);
            this.movementBox.Name = "movementBox";
            this.movementBox.Size = new System.Drawing.Size(268, 237);
            this.movementBox.TabIndex = 7;
            this.movementBox.TabStop = false;
            this.movementBox.Text = "Movement Effect";
            // 
            // movementForced
            // 
            this.movementForced.AutoSize = true;
            this.movementForced.Location = new System.Drawing.Point(6, 121);
            this.movementForced.Name = "movementForced";
            this.movementForced.Size = new System.Drawing.Size(59, 17);
            this.movementForced.TabIndex = 4;
            this.movementForced.Text = "Forced";
            this.movementForced.UseVisualStyleBackColor = true;
            // 
            // moveDistance
            // 
            this.moveDistance.Location = new System.Drawing.Point(6, 86);
            this.moveDistance.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.moveDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.moveDistance.Name = "moveDistance";
            this.moveDistance.Size = new System.Drawing.Size(120, 20);
            this.moveDistance.TabIndex = 3;
            this.moveDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Distance";
            // 
            // moveType
            // 
            this.moveType.FormattingEnabled = true;
            this.moveType.Items.AddRange(new object[] {
            "Up",
            "Right",
            "Down",
            "Left",
            "Random",
            "From Center"});
            this.moveType.Location = new System.Drawing.Point(6, 35);
            this.moveType.Name = "moveType";
            this.moveType.Size = new System.Drawing.Size(121, 21);
            this.moveType.TabIndex = 1;
            this.moveType.Text = "Up";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Move Type";
            // 
            // statChangeBox
            // 
            this.statChangeBox.Controls.Add(this.statDuration);
            this.statChangeBox.Controls.Add(this.statDurationTracked);
            this.statChangeBox.Controls.Add(this.statMultiplier);
            this.statChangeBox.Controls.Add(this.label18);
            this.statChangeBox.Controls.Add(this.flatStatChange);
            this.statChangeBox.Controls.Add(this.label17);
            this.statChangeBox.Controls.Add(this.statToChange);
            this.statChangeBox.Controls.Add(this.label16);
            this.statChangeBox.Location = new System.Drawing.Point(139, 12);
            this.statChangeBox.Name = "statChangeBox";
            this.statChangeBox.Size = new System.Drawing.Size(268, 237);
            this.statChangeBox.TabIndex = 8;
            this.statChangeBox.TabStop = false;
            this.statChangeBox.Text = "Stat Change Part";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Stat";
            // 
            // statToChange
            // 
            this.statToChange.FormattingEnabled = true;
            this.statToChange.Items.AddRange(new object[] {
            "Max Health",
            "Attack",
            "Defense",
            "Magic Attack",
            "Magic Defense",
            "Crit Chance",
            "Max Move",
            "Lifesteal",
            "Spellsteal",
            "Basic Attack Effectiveness",
            "Basic Attack Receptiveness",
            "Spell Damage Effectiveness",
            "Spell Damage Receptiveness",
            "Healing Effectiveness",
            "Healing Receptiveness"});
            this.statToChange.Location = new System.Drawing.Point(6, 35);
            this.statToChange.Name = "statToChange";
            this.statToChange.Size = new System.Drawing.Size(121, 21);
            this.statToChange.TabIndex = 1;
            this.statToChange.Text = "Max Health";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Flat Change";
            // 
            // flatStatChange
            // 
            this.flatStatChange.Location = new System.Drawing.Point(6, 84);
            this.flatStatChange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.flatStatChange.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.flatStatChange.Name = "flatStatChange";
            this.flatStatChange.Size = new System.Drawing.Size(120, 20);
            this.flatStatChange.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Multiplier";
            // 
            // statMultiplier
            // 
            this.statMultiplier.DecimalPlaces = 3;
            this.statMultiplier.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.statMultiplier.Location = new System.Drawing.Point(6, 137);
            this.statMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.statMultiplier.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.statMultiplier.Name = "statMultiplier";
            this.statMultiplier.Size = new System.Drawing.Size(120, 20);
            this.statMultiplier.TabIndex = 5;
            this.statMultiplier.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            // 
            // statDurationTracked
            // 
            this.statDurationTracked.AutoSize = true;
            this.statDurationTracked.Location = new System.Drawing.Point(9, 172);
            this.statDurationTracked.Name = "statDurationTracked";
            this.statDurationTracked.Size = new System.Drawing.Size(66, 17);
            this.statDurationTracked.TabIndex = 6;
            this.statDurationTracked.Text = "Duration";
            this.statDurationTracked.UseVisualStyleBackColor = true;
            // 
            // statDuration
            // 
            this.statDuration.Location = new System.Drawing.Point(6, 189);
            this.statDuration.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.statDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statDuration.Name = "statDuration";
            this.statDuration.Size = new System.Drawing.Size(120, 20);
            this.statDuration.TabIndex = 7;
            this.statDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // statusEffectBox
            // 
            this.statusEffectBox.Controls.Add(this.removeEffectChoice);
            this.statusEffectBox.Controls.Add(this.addEffectChoice);
            this.statusEffectBox.Controls.Add(this.statusEffectType);
            this.statusEffectBox.Controls.Add(this.label19);
            this.statusEffectBox.Location = new System.Drawing.Point(139, 12);
            this.statusEffectBox.Name = "statusEffectBox";
            this.statusEffectBox.Size = new System.Drawing.Size(268, 237);
            this.statusEffectBox.TabIndex = 9;
            this.statusEffectBox.TabStop = false;
            this.statusEffectBox.Text = "Status Effect";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Status Effect";
            // 
            // statusEffectType
            // 
            this.statusEffectType.FormattingEnabled = true;
            this.statusEffectType.Location = new System.Drawing.Point(6, 35);
            this.statusEffectType.Name = "statusEffectType";
            this.statusEffectType.Size = new System.Drawing.Size(121, 21);
            this.statusEffectType.TabIndex = 1;
            // 
            // addEffectChoice
            // 
            this.addEffectChoice.AutoSize = true;
            this.addEffectChoice.Checked = true;
            this.addEffectChoice.Location = new System.Drawing.Point(9, 73);
            this.addEffectChoice.Name = "addEffectChoice";
            this.addEffectChoice.Size = new System.Drawing.Size(75, 17);
            this.addEffectChoice.TabIndex = 2;
            this.addEffectChoice.TabStop = true;
            this.addEffectChoice.Text = "Add Effect";
            this.addEffectChoice.UseVisualStyleBackColor = true;
            // 
            // removeEffectChoice
            // 
            this.removeEffectChoice.AutoSize = true;
            this.removeEffectChoice.Location = new System.Drawing.Point(9, 96);
            this.removeEffectChoice.Name = "removeEffectChoice";
            this.removeEffectChoice.Size = new System.Drawing.Size(96, 17);
            this.removeEffectChoice.TabIndex = 3;
            this.removeEffectChoice.Text = "Remove Effect";
            this.removeEffectChoice.UseVisualStyleBackColor = true;
            // 
            // uniqueEffectBox
            // 
            this.uniqueEffectBox.Controls.Add(this.uniqueEffectType);
            this.uniqueEffectBox.Controls.Add(this.label20);
            this.uniqueEffectBox.Location = new System.Drawing.Point(139, 12);
            this.uniqueEffectBox.Name = "uniqueEffectBox";
            this.uniqueEffectBox.Size = new System.Drawing.Size(268, 237);
            this.uniqueEffectBox.TabIndex = 4;
            this.uniqueEffectBox.TabStop = false;
            this.uniqueEffectBox.Text = "Unique Effect";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Effect";
            // 
            // uniqueEffectType
            // 
            this.uniqueEffectType.FormattingEnabled = true;
            this.uniqueEffectType.Items.AddRange(new object[] {
            "Move Again"});
            this.uniqueEffectType.Location = new System.Drawing.Point(6, 35);
            this.uniqueEffectType.Name = "uniqueEffectType";
            this.uniqueEffectType.Size = new System.Drawing.Size(121, 21);
            this.uniqueEffectType.TabIndex = 1;
            this.uniqueEffectType.Text = "Move Again";
            // 
            // SkillPartTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.uniqueEffectBox);
            this.Controls.Add(this.statusEffectBox);
            this.Controls.Add(this.statChangeBox);
            this.Controls.Add(this.movementBox);
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
            this.damageEffectBox.ResumeLayout(false);
            this.damageEffectBox.PerformLayout();
            this.healBox.ResumeLayout(false);
            this.healBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healingModifiedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHPHeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHealValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageModifiedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingHpPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHpPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatDamageValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeTurnCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesPerBattleCount)).EndInit();
            this.movementBox.ResumeLayout(false);
            this.movementBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveDistance)).EndInit();
            this.statChangeBox.ResumeLayout(false);
            this.statChangeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatStatChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDuration)).EndInit();
            this.statusEffectBox.ResumeLayout(false);
            this.statusEffectBox.PerformLayout();
            this.uniqueEffectBox.ResumeLayout(false);
            this.uniqueEffectBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox damageEffectBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox damageType;
        private System.Windows.Forms.NumericUpDown damageModifiedValue;
        private System.Windows.Forms.NumericUpDown missingHpPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxHpPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown flatDamageValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown damageValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox healBox;
        private System.Windows.Forms.NumericUpDown healingModifiedValue;
        private System.Windows.Forms.NumericUpDown maxHPHeal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown flatHealValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown healValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox damageModByValue;
        private System.Windows.Forms.CheckBox healingModByValue;
        private System.Windows.Forms.GroupBox movementBox;
        private System.Windows.Forms.ComboBox moveType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox movementForced;
        private System.Windows.Forms.NumericUpDown moveDistance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox statChangeBox;
        private System.Windows.Forms.ComboBox statToChange;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown flatStatChange;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown statMultiplier;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown statDuration;
        private System.Windows.Forms.CheckBox statDurationTracked;
        private System.Windows.Forms.GroupBox statusEffectBox;
        private System.Windows.Forms.ComboBox statusEffectType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton removeEffectChoice;
        private System.Windows.Forms.RadioButton addEffectChoice;
        private System.Windows.Forms.GroupBox uniqueEffectBox;
        private System.Windows.Forms.ComboBox uniqueEffectType;
        private System.Windows.Forms.Label label20;
    }
}