using System;
using System.ComponentModel;
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
            spellList.DisplayMember = "name";
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
                if (SaveItem(previousSelectedIndex))
                {
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
        }

        private void addSpell_Click(object sender, EventArgs e)
        {
            string name = "Spell";
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
            if (itemBoundList.Count != 1)
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
                foreach (Skill spell in itemBoundList)
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

        /// <summary>
        /// Saves the selected index
        /// </summary>
        /// <returns>Did the item save successfully</returns>
        private bool SaveItem(int index)
        {
            if (index != -1)
            {
                if (string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    MessageBox.Show("The name of the spell cannot be empty or only whitespace. Please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    spellList.SelectedIndex = index;
                    return false;
                }

                for (int i = 0; i < itemBoundList.Count; i++)
                {
                    if (i == index)
                        continue;
                    //If the name they want is already in use
                    if ((itemBoundList[i]).name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the spell needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        spellList.SelectedIndex = index;
                        return false;
                    }
                }
                //Stores the changed item values
                itemBoundList[index] = new Skill(nameBox.Text, (TargettingType)targetType.SelectedIndex, (int)castCost.Value,
                    (int)targetRange.Value, (int)aoeX.Value, (int)aoeY.Value, (int)unlockCost.Value, (int)unlockLevel.Value, flavorTextBox.Text);
                foreach (int id in dependencyList.CheckedIndices)
                {
                    itemBoundList[index].dependencies.Add(id + (id >= index ? 1 : 0));
                }
                foreach (SkillPartBase effect in effectList.Items)
                {
                    itemBoundList[index].partList.Add(effect);
                }
            }
            return true;
        }

        private void SpellTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveItem(spellList.SelectedIndex);
        }
    }
}
