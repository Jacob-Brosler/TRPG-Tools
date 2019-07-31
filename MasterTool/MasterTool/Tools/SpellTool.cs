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
    public partial class SpellTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<Skill> itemBoundList = new BindingList<Skill>();

        public SpellTool(SpellTree tree)
        {
            InitializeComponent();
            itemBoundList = tree.spells;
            spellList.DataSource = itemBoundList;
            spellList.DisplayMember = "Name";
            if (itemBoundList.Count > 0)
            {
                spellList.SelectedIndex = 0;
                spellList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void spellList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spellList.SelectedIndex != previousSelectedIndex)
            {
                if (previousSelectedIndex != -1)
                {
                    for (int i = 0; i < itemBoundList.Count; i++)
                    {
                        if (i == previousSelectedIndex)
                            continue;
                        //If the name they want is already in use
                        if (itemBoundList[i].name == nameBox.Text)
                        {
                            MessageBox.Show("The name of the item needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            spellList.SelectedIndex = previousSelectedIndex;
                            return;
                        }
                    }
                    List<SkillPartBase> tempEffectList = new List<SkillPartBase>();
                    foreach (SkillPartBase effect in effectList.Items)
                    {
                        tempEffectList.Add(effect);
                    }
                    //Stores the changed item values
                    itemBoundList[previousSelectedIndex] = new Skill(nameBox.Text, (TargettingType)targetType.SelectedIndex, (int)castCost.Value,
                        (int)targetRange.Value, (int)aoeX.Value, (int)aoeY.Value, (int)unlockCost.Value, (int)unlockLevel.Value, flavorTextBox.Text);
                    foreach(int id in dependencyList.CheckedIndices)
                    {
                        itemBoundList[previousSelectedIndex].dependencies.Add(id + (id >= previousSelectedIndex ? 1 : 0));
                    }
                }
                if (spellList.SelectedIndex != -1)
                {
                    backPanel.Visible = true;
                    backPanel.Enabled = true;
                    //Displays the values for the newly selected item
                    Skill displayItem = itemBoundList[spellList.SelectedIndex];
                    nameBox.Text = displayItem.name;
                    targetType.SelectedIndex = (int)displayItem.targetType;
                    castCost.Value = displayItem.aEtherCost;
                    targetRange.Value = displayItem.targettingRange;
                    aoeX.Value = displayItem.xRange;
                    aoeY.Value = displayItem.yRange;
                    unlockCost.Value = displayItem.unlockCost;
                    unlockLevel.Value = displayItem.unlockLevel;
                    effectList.Items.Clear();
                    foreach (SkillPartBase effect in displayItem.partList)
                    {
                        effectList.Items.Add(effect);
                    }

                    dependencyList.Items.Clear();
                    for (int i = 0; i < itemBoundList.Count; i++)
                    {
                        if (i == spellList.SelectedIndex)
                            continue;
                        dependencyList.Items.Add(itemBoundList[i].name);
                        dependencyList.SetItemChecked(i - (i > spellList.SelectedIndex ? 1 : 0), itemBoundList[spellList.SelectedIndex].dependencies.Contains(i));
                    }

                    flavorTextBox.Text = displayItem.flavorText;
                }
                else
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                previousSelectedIndex = spellList.SelectedIndex;
            }
        }

        private void addSpell_Click(object sender, EventArgs e)
        {
            string name = "BattleItem";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach (Skill item in itemBoundList)
                {
                    if (item.name == name + append)
                        validName = false;
                }
            } while (!validName);
            itemBoundList.Add(new Skill(name + append, TargettingType.Self, 1, 1, 1, 1, 1, 1, ""));
            //Keeps the first item in a tree from being able to add itself as a dependency
            if(itemBoundList.Count != 1)
                dependencyList.Items.Add(itemBoundList[itemBoundList.Count - 1].name);

            if (itemBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                spellList.SelectedIndex = 0;
                spellList_SelectedIndexChanged(null, null);
            }
        }

        private void removeSpell_Click(object sender, EventArgs e)
        {
            if (spellList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this spell? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(spellList.SelectedIndex);
                foreach(Skill spell in itemBoundList)
                {
                    spell.RemoveSpell(spellList.SelectedIndex);
                }
                spellList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
                if (spellList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    spellList_SelectedIndexChanged(null, null);
            }
        }

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
    }
}
