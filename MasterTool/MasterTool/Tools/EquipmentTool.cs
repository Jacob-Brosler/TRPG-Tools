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
    public partial class EquipmentTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<EquippableBase> itemBoundList = new BindingList<EquippableBase>();

        public EquipmentTool()
        {
            InitializeComponent();
            itemBoundList = DataStorage.EquipmentRegistry;
            equipmentList.DataSource = itemBoundList;
            equipmentList.DisplayMember = "name";

            if (itemBoundList.Count > 0)
            {
                equipmentList.SelectedIndex = 0;
                EquipmentList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void EquipmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipmentList.SelectedIndex != previousSelectedIndex)
            {
                if (SaveItem(previousSelectedIndex))
                {
                    if (equipmentList.SelectedIndex != -1)
                    {
                        backPanel.Visible = true;
                        backPanel.Enabled = true;
                        //Displays the values for the newly selected item
                        EquippableBase displayItem = itemBoundList[equipmentList.SelectedIndex];
                        nameBox.Text = displayItem.name;
                        equipSlot.SelectedIndex = displayItem.equipSlot - 1;
                        weightClass.SelectedIndex = displayItem.subType;
                        effectList.Items.Clear();
                        foreach (AddTriggerPart effect in displayItem.effects)
                        {
                            effectList.Items.Add(effect);
                        }
                        statList.Items.Clear();
                        foreach (KeyValuePair<Stats, int> effect in displayItem.stats)
                        {
                            statList.Items.Add(new StatChangePart(TargettingType.Self, effect.Key, effect.Value, 1, -1));
                        }
                        sellPriceCount.Value = displayItem.sellAmount;
                        flavorTextBox.Text = displayItem.flavorText;
                    }
                    else
                    {
                        backPanel.Visible = false;
                        backPanel.Enabled = false;
                    }
                    previousSelectedIndex = equipmentList.SelectedIndex;
                }
            }
        }

        private void AddEquipment_Click(object sender, EventArgs e)
        {
            string name = "BattleItem";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach (EquippableBase item in itemBoundList)
                {
                    if (item.name == name + append)
                        validName = false;
                }
            } while (!validName);
            itemBoundList.Add(new EquippableBase(name + append, 1, 0, 1, "", new List<StatChangePart>(), new List<AddTriggerPart>()));

            if (itemBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                equipmentList.SelectedIndex = 0;
                EquipmentList_SelectedIndexChanged(null, null);
            }
        }

        private void RemoveEquipment_Click(object sender, EventArgs e)
        {
            if (equipmentList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this equipment? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(equipmentList.SelectedIndex);
                equipmentList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
                if (equipmentList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    EquipmentList_SelectedIndexChanged(null, null);
            }
        }

        private void StatList_DoubleClick(object sender, EventArgs e)
        {
            if (statList.SelectedIndex != -1)
            {
                using (SkillPartTool newEffect = new SkillPartTool((StatChangePart)statList.SelectedItem))
                {
                    newEffect.LockoutStatChange();
                    newEffect.ShowDialog(this);
                    statList.Items[statList.SelectedIndex] = newEffect.returnEffect;
                }
            }
        }

        private void AddStat_Click(object sender, EventArgs e)
        {
            statList.Items.Add(new StatChangePart(TargettingType.Self, Stats.Attack, 0, 1, 0));
        }

        private void RemoveStat_Click(object sender, EventArgs e)
        {
            if (statList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this stat change? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                statList.Items.RemoveAt(statList.SelectedIndex);
            }
        }

        private void EffectList_DoubleClick(object sender, EventArgs e)
        {
            if (effectList.SelectedIndex != -1)
            {
                using (SkillPartTool newEffect = new SkillPartTool((AddTriggerPart)effectList.SelectedItem, false))
                {
                    newEffect.ShowDialog(this);
                    effectList.Items[effectList.SelectedIndex] = newEffect.returnEffect;
                }
            }
        }

        private void AddEffect_Click(object sender, EventArgs e)
        {
            effectList.Items.Add(new AddTriggerPart(TargettingType.Self, new TriggeredEffect(EffectTriggers.FallBelow25Percent)));
        }

        private void RemoveEffect_Click(object sender, EventArgs e)
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
                    MessageBox.Show("The name of the equipment cannot be empty or only whitespace. Please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    equipmentList.SelectedIndex = index;
                    return false;
                }

                for (int i = 0; i < itemBoundList.Count; i++)
                {
                    if (i == index)
                        continue;
                    //If the name they want is already in use
                    if ((itemBoundList[i]).name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the equipment needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        equipmentList.SelectedIndex = index;
                        return false;
                    }
                }
                //Stores the changed item values
                List<StatChangePart> tempStatEffectList = new List<StatChangePart>();
                foreach (StatChangePart effect in statList.Items)
                {
                    tempStatEffectList.Add(effect);
                }
                List<AddTriggerPart> tempEffectList = new List<AddTriggerPart>();
                foreach (AddTriggerPart effect in effectList.Items)
                {
                    tempEffectList.Add(effect);
                }
                itemBoundList[index] = new EquippableBase(nameBox.Text, equipSlot.SelectedIndex + 1, weightClass.SelectedIndex,
                    (int)sellPriceCount.Value, flavorTextBox.Text, tempStatEffectList, tempEffectList);
            }
            return true;
        }

        private void EquipmentTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveItem(equipmentList.SelectedIndex);
        }
    }
}
