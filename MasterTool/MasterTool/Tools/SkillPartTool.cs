using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class SkillPartTool : Form
    {
        public SkillPartBase returnEffect;
        private GroupBox[] panels;

        public SkillPartTool()
        {
            InitializeComponent();
            panels = new GroupBox[] { addTriggerBox };
        }

        /// <summary>
        /// Saves the created effect
        /// </summary>
        private void SkillPartTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (typeSelector.SelectedItem)
            {
                case "Add Trigger":
                    returnEffect = new AddTriggerPart((TargettingType)targetType.SelectedIndex, 
                        new TriggeredEffect((EffectTriggers)addTriggerTrigger.SelectedIndex),
                        (timesPerBattle.Checked ? (int)timesPerBattleCount.Value : -1),
                        (turnCD.Checked ? (int)cooldownCount.Value : -1),
                        (activeTurns.Checked ? (int)activeTurnCount.Value : -1),
                        (int)chance.Value);
                    foreach(SkillPartBase effect in effectList.Items)
                    {
                        ((AddTriggerPart)returnEffect).effect.AddEffect(effect);
                    }
                    break;
            }
        }

        /// <summary>
        /// Switches the shown effect options to match the new selection
        /// </summary>
        private void typeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < panels.Length; i++)
            {
                panels[i].Enabled = (i == typeSelector.SelectedIndex);
                panels[i].Visible = (i == typeSelector.SelectedIndex);
            }
        }

        ///
        /// Add Trigger Effect
        ///

        private void effectList_DoubleClick(object sender, EventArgs e)
        {
            using(SkillPartTool newEffect = new SkillPartTool())
            {
                newEffect.Show(this);
                effectList.Items[effectList.SelectedIndex] = newEffect.returnEffect;
            }
        }

        private void addEffect_Click(object sender, EventArgs e)
        {
            effectList.Items.Add(new AddTriggerPart(TargettingType.Self, null));
        }

        private void removeEffect_Click(object sender, EventArgs e)
        {
            if (effectList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this effect? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                effectList.Items.RemoveAt(effectList.SelectedIndex);
            }
        }
    }
}
