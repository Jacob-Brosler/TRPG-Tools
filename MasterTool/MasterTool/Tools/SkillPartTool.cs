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
            panels = new GroupBox[] { addTriggerBox, damageEffectBox, healBox, movementBox, statChangeBox, statusEffectBox };
            typeSelector.SelectedIndex = 0;
            statusEffectType.Items.Clear();
            statusEffectType.Items.Add("All");
            foreach(string status in DataStorage.StatusEffectRegistry.Keys)
            {
                statusEffectType.Items.Add(status);
            }
            statusEffectType.SelectedIndex = 0;
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
                case "Damage":
                    returnEffect = new DamagePart((TargettingType)targetType.SelectedIndex, (DamageType)damageType.SelectedIndex,
                        (int)damageValue.Value, (int)flatDamageValue.Value, (int)maxHpPercent.Value, (int)missingHpPercent.Value, 
                        (int)chance.Value, (damageModByValue.Checked ? (int)damageModifiedValue.Value : 0));
                    break;
                case "Healing":
                    returnEffect = new HealingPart((TargettingType)targetType.SelectedIndex, (int)healValue.Value, (int)flatHealValue.Value,
                        (int)flatHealValue.Value, (int)chance.Value, (healingModByValue.Checked ? (int)healingModifiedValue.Value : 0));
                    break;
                case "Movement":
                    returnEffect = new MovePart((TargettingType)targetType.SelectedIndex, (MoveDirection)moveType.SelectedIndex, (int)moveDistance.Value,
                        movementForced.Checked, (int)chance.Value);
                    break;
                case "Stat Change":
                    returnEffect = new StatChangePart((TargettingType)targetType.SelectedIndex, (Stats)statToChange.SelectedIndex, (int)flatStatChange.Value,
                        (int)statMultiplier.Value, (statDurationTracked.Checked ? (int)statDuration.Value : -1), (int)chance.Value);
                    break;
                case "Status Effect":
                    returnEffect = new StatusEffectPart((TargettingType)targetType.SelectedIndex, (string)statusEffectType.SelectedItem, 
                        removeEffectChoice.Checked, (int)chance.Value);
                    break;
                case "Unique Effect":
                    returnEffect = new UniqueEffectPart((TargettingType)targetType.SelectedIndex, (UniqueEffects)uniqueEffectType.SelectedIndex, (int)chance.Value);
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
