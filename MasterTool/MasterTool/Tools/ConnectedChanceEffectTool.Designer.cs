namespace MasterTool.Tools
{
    partial class ConnectedChanceEffectTool
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
            this.percentToTrigger = new System.Windows.Forms.Label();
            this.chanceToTrigger = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.removeEffect = new System.Windows.Forms.Button();
            this.addEffect = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.effectList = new System.Windows.Forms.ListBox();
            this.chanceOutOfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chanceToTrigger)).BeginInit();
            this.SuspendLayout();
            // 
            // percentToTrigger
            // 
            this.percentToTrigger.AutoSize = true;
            this.percentToTrigger.Location = new System.Drawing.Point(136, 57);
            this.percentToTrigger.Name = "percentToTrigger";
            this.percentToTrigger.Size = new System.Drawing.Size(135, 13);
            this.percentToTrigger.TabIndex = 41;
            this.percentToTrigger.Text = "Percent Chance to Trigger:";
            // 
            // chanceToTrigger
            // 
            this.chanceToTrigger.Location = new System.Drawing.Point(139, 19);
            this.chanceToTrigger.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.chanceToTrigger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chanceToTrigger.Name = "chanceToTrigger";
            this.chanceToTrigger.Size = new System.Drawing.Size(63, 20);
            this.chanceToTrigger.TabIndex = 40;
            this.chanceToTrigger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chanceToTrigger.ValueChanged += new System.EventHandler(this.chanceToTrigger_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(136, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "Chance to Trigger";
            // 
            // removeEffect
            // 
            this.removeEffect.Location = new System.Drawing.Point(66, 191);
            this.removeEffect.Margin = new System.Windows.Forms.Padding(1);
            this.removeEffect.Name = "removeEffect";
            this.removeEffect.Size = new System.Drawing.Size(58, 23);
            this.removeEffect.TabIndex = 39;
            this.removeEffect.Text = "-";
            this.removeEffect.UseVisualStyleBackColor = true;
            this.removeEffect.Click += new System.EventHandler(this.removeEffect_Click);
            // 
            // addEffect
            // 
            this.addEffect.Location = new System.Drawing.Point(3, 191);
            this.addEffect.Margin = new System.Windows.Forms.Padding(1);
            this.addEffect.Name = "addEffect";
            this.addEffect.Size = new System.Drawing.Size(57, 23);
            this.addEffect.TabIndex = 38;
            this.addEffect.Text = "+";
            this.addEffect.UseVisualStyleBackColor = true;
            this.addEffect.Click += new System.EventHandler(this.addEffect_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Effects";
            // 
            // effectList
            // 
            this.effectList.FormattingEnabled = true;
            this.effectList.Location = new System.Drawing.Point(3, 19);
            this.effectList.Name = "effectList";
            this.effectList.Size = new System.Drawing.Size(120, 173);
            this.effectList.TabIndex = 36;
            this.effectList.DoubleClick += new System.EventHandler(this.effectList_DoubleClick);
            // 
            // chanceOutOfLabel
            // 
            this.chanceOutOfLabel.AutoSize = true;
            this.chanceOutOfLabel.Location = new System.Drawing.Point(204, 22);
            this.chanceOutOfLabel.Name = "chanceOutOfLabel";
            this.chanceOutOfLabel.Size = new System.Drawing.Size(24, 13);
            this.chanceOutOfLabel.TabIndex = 42;
            this.chanceOutOfLabel.Text = "/15";
            this.chanceOutOfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConnectedChanceEffectTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 220);
            this.Controls.Add(this.chanceOutOfLabel);
            this.Controls.Add(this.percentToTrigger);
            this.Controls.Add(this.chanceToTrigger);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.removeEffect);
            this.Controls.Add(this.addEffect);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.effectList);
            this.Name = "ConnectedChanceEffectTool";
            this.Text = "Connected Chance Effect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectedChanceEffectTool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chanceToTrigger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentToTrigger;
        private System.Windows.Forms.NumericUpDown chanceToTrigger;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button removeEffect;
        private System.Windows.Forms.Button addEffect;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox effectList;
        private System.Windows.Forms.Label chanceOutOfLabel;
    }
}