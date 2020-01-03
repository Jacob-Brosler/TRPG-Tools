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

        public SkillPartTool(SkillPartBase effect = null, bool switchEnabled = true)
        {
            InitializeComponent();
            panels = new GroupBox[] { addTriggerBox, damageEffectBox, healBox, movementBox, statChangeBox, statusEffectBox, uniqueEffectBox };
            typeSelector.SelectedIndex = LoadEffect(effect);
            typeSelector_SelectedIndexChanged(null, null);
            typeSelector.Enabled = switchEnabled;
            statusEffectType.Items.Clear();
            statusEffectType.Items.Add("All");
            foreach(StatusEffectDefinition status in DataStorage.StatusEffectRegistry)
            {
                statusEffectType.Items.Add(status.name);
            }
            statusEffectType.SelectedIndex = 0;
        }

        public int LoadEffect(SkillPartBase effect)
        {
            if (effect == null)
                return 0;

            targetType.SelectedIndex = (int)effect.targetType;
            chance.Value = effect.chanceToProc;

            if (effect is AddTriggerPart)
            {
                AddTriggerPart actualEffect = effect as AddTriggerPart;
                addTriggerTrigger.SelectedIndex = (int)actualEffect.effect.trigger;

                if(actualEffect.maxTimesThisBattle == -1)
                {
                    timesPerBattle.Checked = false;
                }
                else
                {
                    timesPerBattle.Checked = true;
                    timesPerBattleCount.Value = actualEffect.maxTimesThisBattle;
                }

                if (actualEffect.turnCooldown == -1)
                {
                    turnCD.Checked = false;
                }
                else
                {
                    turnCD.Checked = true;
                    cooldownCount.Value = actualEffect.turnCooldown;
                }

                if (actualEffect.maxActiveTurns == -1)
                {
                    activeTurns.Checked = false;
                }
                else
                {
                    activeTurns.Checked = true;
                    activeTurnCount.Value = actualEffect.maxActiveTurns;
                }

                effectList.Items.Clear();
                foreach (SkillPartBase subeffect in actualEffect.effect.effects)
                {
                    effectList.Items.Add(subeffect);
                }
                return 0;
            }
            else if(effect is DamagePart)
            {
                DamagePart actualEffect = effect as DamagePart;
                damageType.SelectedIndex = (int)actualEffect.damageType;
                damageValue.Value = actualEffect.damage;
                flatDamageValue.Value = actualEffect.flatDamage;
                maxHpPercent.Value = actualEffect.maxHpPercent;
                missingHpPercent.Value = actualEffect.missingHpPercent;

                if (actualEffect.modifiedByValue == 0)
                {
                    damageModByValue.Checked = false;
                }
                else
                {
                    damageModByValue.Checked = true;
                    damageModifiedValue.Value = (decimal)actualEffect.modifiedByValue;
                }
                return 1;
            }
            else if (effect is HealingPart)
            {
                HealingPart actualEffect = effect as HealingPart;
                healValue.Value = actualEffect.healing;
                flatHealValue.Value = actualEffect.flatHealing;
                maxHPHeal.Value = actualEffect.maxHpPercent;

                if (actualEffect.modifiedByValue == 0)
                {
                    healingModByValue.Checked = false;
                }
                else
                {
                    healingModByValue.Checked = true;
                    healingModifiedValue.Value = (decimal)actualEffect.modifiedByValue;
                }
                return 2;
            }
            else if (effect is MovePart)
            {
                MovePart actualEffect = effect as MovePart;
                moveType.SelectedIndex = (int)actualEffect.direction;
                moveDistance.Value = actualEffect.amount;
                movementForced.Checked = actualEffect.forced;
                return 3;
            }
            else if (effect is StatChangePart)
            {
                StatChangePart actualEffect = effect as StatChangePart;
                statToChange.SelectedIndex = (int)actualEffect.affectedStat;
                flatStatChange.Value = actualEffect.flatChange;
                statMultiplier.Value = (decimal)actualEffect.multiplier;

                if (actualEffect.duration == 0)
                {
                    statDurationTracked.Checked = false;
                }
                else
                {
                    statDurationTracked.Checked = true;
                    statDuration.Value = (decimal)actualEffect.duration;
                }
                return 4;
            }
            else if (effect is StatusEffectPart)
            {
                StatusEffectPart actualEffect = effect as StatusEffectPart;
                statusEffectType.SelectedItem = actualEffect.status;
                addEffectChoice.Checked = !actualEffect.remove;
                removeEffectChoice.Checked = actualEffect.remove;
                return 5;
            }
            else if(effect is UniqueEffectPart)
            {
                uniqueEffectType.SelectedIndex = (int)(effect as UniqueEffectPart).effectType;
                return 6;
            }
            //Screaming
            return -1;
        }

        /// <summary>
        /// Saves the created effect
        /// </summary>
        private void SkillPartTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch ((string)typeSelector.SelectedItem)
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
                        (int)maxHPHeal.Value, (int)chance.Value, (healingModByValue.Checked ? (int)healingModifiedValue.Value : 0));
                    break;
                case "Movement":
                    returnEffect = new MovePart((TargettingType)targetType.SelectedIndex, (MoveDirection)moveType.SelectedIndex, (int)moveDistance.Value,
                        movementForced.Checked, (int)chance.Value);
                    break;
                case "Stat Change":
                    returnEffect = new StatChangePart((TargettingType)targetType.SelectedIndex, (Stats)statToChange.SelectedIndex, (int)flatStatChange.Value,
                        (float)statMultiplier.Value, (statDurationTracked.Checked ? (int)statDuration.Value : 0), (int)chance.Value);
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
            if (effectList.SelectedIndex != -1)
            {
                using (SkillPartTool newEffect = new SkillPartTool((SkillPartBase)effectList.SelectedItem))
                {
                    newEffect.ShowDialog(this);
                    effectList.Items[effectList.SelectedIndex] = newEffect.returnEffect;
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

        /// <summary>
        /// Locks out most selections for a stat change part for making stat changes for equippables
        /// </summary>
        public void LockoutStatChange()
        {
            targetType.Enabled = false;
            statMultiplier.Enabled = false;
            statDurationTracked.Enabled = false;
            chance.Enabled = false;
            statDuration.Enabled = false;
        }
    }
}
