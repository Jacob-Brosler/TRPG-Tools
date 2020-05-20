using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class ConnectedChanceEffectTool : Form
    {
        public ConnectedChanceEffect returnEffect;
        int chanceOutOf;

        public ConnectedChanceEffectTool(ConnectedChanceEffect effect, int chanceOutOf)
        {
            InitializeComponent();
            this.chanceOutOf = chanceOutOf;
            foreach (SkillPartBase part in effect.effects)
            {
                effectList.Items.Add(part);
            }
            chanceToTrigger.Value = effect.triggerChance;
            chanceOutOfLabel.Text = "/" + chanceOutOf;
            UpdatePercent();
        }

        private void effectList_DoubleClick(object sender, EventArgs e)
        {
            if (effectList.SelectedIndex != -1)
            {
                using (SkillPartTool newEffect = new SkillPartTool((SkillPartBase)effectList.SelectedItem))
                {
                    newEffect.ShowDialog(this);
                    effectList.Items[effectList.SelectedIndex] = newEffect.returnEffect;
                    UpdatePercent();
                }
            }
        }

        private void addEffect_Click(object sender, EventArgs e)
        {
            effectList.Items.Add(new AddTriggerPart(TargettingType.Self, new TriggeredEffect(EffectTriggers.FallBelow25Percent)));
        }

        private void removeEffect_Click(object sender, EventArgs e)
        {
            if (effectList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this effect? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                effectList.Items.RemoveAt(effectList.SelectedIndex);
            }
        }

        private void chanceToTrigger_ValueChanged(object sender, EventArgs e)
        {
            UpdatePercent();
        }

        private void UpdatePercent()
        {
            percentToTrigger.Text = "Percent Chance to Trigger:\n" + (((int)chanceToTrigger.Value) / (1.0f * chanceOutOf) * 100) + "%";
        }

        private void ConnectedChanceEffectTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<SkillPartBase> finalEffectList = new List<SkillPartBase>();
            foreach (SkillPartBase part in effectList.Items)
            {
                finalEffectList.Add(part);
            }
            returnEffect = new ConnectedChanceEffect(finalEffectList, (int)chanceToTrigger.Value);
        }
    }
}
