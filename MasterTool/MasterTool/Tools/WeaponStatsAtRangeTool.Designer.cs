namespace MasterTool.Tools
{
    partial class WeaponStatsAtRangeTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.damageType = new System.Windows.Forms.ComboBox();
            this.range = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.canDamage = new System.Windows.Forms.CheckBox();
            this.canHeal = new System.Windows.Forms.CheckBox();
            this.ranged = new System.Windows.Forms.CheckBox();
            this.damageMod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Damage Type";
            // 
            // damageType
            // 
            this.damageType.FormattingEnabled = true;
            this.damageType.Items.AddRange(new object[] {
            "Physical",
            "Magical"});
            this.damageType.Location = new System.Drawing.Point(12, 29);
            this.damageType.Name = "damageType";
            this.damageType.Size = new System.Drawing.Size(121, 24);
            this.damageType.TabIndex = 1;
            this.damageType.Text = "Physical";
            // 
            // range
            // 
            this.range.Location = new System.Drawing.Point(12, 90);
            this.range.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(120, 22);
            this.range.TabIndex = 2;
            this.range.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Range";
            // 
            // canDamage
            // 
            this.canDamage.AutoSize = true;
            this.canDamage.Checked = true;
            this.canDamage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.canDamage.Location = new System.Drawing.Point(12, 143);
            this.canDamage.Name = "canDamage";
            this.canDamage.Size = new System.Drawing.Size(90, 21);
            this.canDamage.TabIndex = 4;
            this.canDamage.Text = "Damages";
            this.canDamage.UseVisualStyleBackColor = true;
            // 
            // canHeal
            // 
            this.canHeal.AutoSize = true;
            this.canHeal.Location = new System.Drawing.Point(192, 143);
            this.canHeal.Name = "canHeal";
            this.canHeal.Size = new System.Drawing.Size(66, 21);
            this.canHeal.TabIndex = 5;
            this.canHeal.Text = "Heals";
            this.canHeal.UseVisualStyleBackColor = true;
            // 
            // ranged
            // 
            this.ranged.AutoSize = true;
            this.ranged.Location = new System.Drawing.Point(192, 31);
            this.ranged.Name = "ranged";
            this.ranged.Size = new System.Drawing.Size(80, 21);
            this.ranged.TabIndex = 6;
            this.ranged.Text = "Ranged";
            this.ranged.UseVisualStyleBackColor = true;
            // 
            // damageMod
            // 
            this.damageMod.DecimalPlaces = 3;
            this.damageMod.Location = new System.Drawing.Point(192, 90);
            this.damageMod.Name = "damageMod";
            this.damageMod.Size = new System.Drawing.Size(120, 22);
            this.damageMod.TabIndex = 7;
            this.damageMod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Damage Modifier";
            // 
            // WeaponStatsAtRangeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.damageMod);
            this.Controls.Add(this.ranged);
            this.Controls.Add(this.canHeal);
            this.Controls.Add(this.canDamage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.range);
            this.Controls.Add(this.damageType);
            this.Controls.Add(this.label1);
            this.Name = "WeaponStatsAtRangeTool";
            this.Text = "Weapon Range";
            ((System.ComponentModel.ISupportInitialize)(this.range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox damageType;
        private System.Windows.Forms.NumericUpDown range;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox canDamage;
        private System.Windows.Forms.CheckBox canHeal;
        private System.Windows.Forms.CheckBox ranged;
        private System.Windows.Forms.NumericUpDown damageMod;
        private System.Windows.Forms.Label label3;
    }
}