using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class WeaponTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<EquippableBase> itemBoundList = new BindingList<EquippableBase>();

        public WeaponTool()
        {
            InitializeComponent();
            if (DataStorage.WeaponTypeRegistry.Count == 0)
            {
                MessageBox.Show("You must have a valid weapon type before you can make a weapon. Please make one and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                weaponType.Items.Clear();
                foreach (WeaponType type in DataStorage.WeaponTypeRegistry)
                {
                    weaponType.Items.Add(type.name);
                }
            }
            itemBoundList = DataStorage.WeaponRegistry;
            weaponList.DataSource = itemBoundList;
            weaponList.DisplayMember = "name";

            if (itemBoundList.Count > 0)
            {
                weaponList.SelectedIndex = 0;
                WeaponList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void WeaponList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weaponList.SelectedIndex != previousSelectedIndex)
            {
                if (SaveItem(previousSelectedIndex))
                {
                    if (weaponList.SelectedIndex != -1)
                    {
                        backPanel.Visible = true;
                        backPanel.Enabled = true;
                        //Displays the values for the newly selected item
                        EquippableBase displayItem = itemBoundList[weaponList.SelectedIndex];
                        nameBox.Text = displayItem.name;
                        weaponType.SelectedIndex = displayItem.subType;
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
                    previousSelectedIndex = weaponList.SelectedIndex;
                }
            }
        }

        private void AddWeapon_Click(object sender, EventArgs e)
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
            itemBoundList.Add(new EquippableBase(name + append, 0, 0, 1, "", new List<StatChangePart>(), new List<AddTriggerPart>()));

            if (itemBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                weaponList.SelectedIndex = 0;
                WeaponList_SelectedIndexChanged(null, null);
            }
        }

        private void RemoveWeapon_Click(object sender, EventArgs e)
        {
            if (weaponList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this weapon? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(weaponList.SelectedIndex);
                weaponList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
                if (weaponList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    WeaponList_SelectedIndexChanged(null, null);
            }
        }

        private void StatList_DoubleClick(object sender, EventArgs e)
        {
            if (statList.SelectedIndex != -1)
            {
                using (SkillPartTool newEffect = new SkillPartTool((StatChangePart)statList.SelectedItem, false))
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
                    MessageBox.Show("The name of the weapon cannot be empty or only whitespace. Please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    weaponList.SelectedIndex = index;
                    return false;
                }

                for (int i = 0; i < itemBoundList.Count; i++)
                {
                    if (i == index)
                        continue;
                    //If the name they want is already in use
                    if ((itemBoundList[i]).name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the weapon needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        weaponList.SelectedIndex = index;
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
                itemBoundList[index] = new EquippableBase(nameBox.Text, 0, weaponType.SelectedIndex,
                    (int)sellPriceCount.Value, flavorTextBox.Text, tempStatEffectList, tempEffectList);
            }
            return true;
        }

        private void WeaponTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveItem(weaponList.SelectedIndex);
        }
    }
}
