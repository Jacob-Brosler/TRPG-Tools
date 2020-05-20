using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class BattleItemTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<BattleItemBase> itemBoundList = new BindingList<BattleItemBase>();

        public BattleItemTool()
        {
            InitializeComponent();
            itemBoundList = DataStorage.BattleItemRegistry;
            itemList.DataSource = itemBoundList;
            itemList.DisplayMember = "name";
            if (itemBoundList.Count > 0)
            {
                itemList.SelectedIndex = 0;
                itemList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex != previousSelectedIndex)
            {
                if (SaveItem(previousSelectedIndex))
                {
                    if (itemList.SelectedIndex != -1)
                    {
                        backPanel.Visible = true;
                        backPanel.Enabled = true;
                        //Displays the values for the newly selected item
                        BattleItemBase displayItem = itemBoundList[itemList.SelectedIndex];
                        nameBox.Text = displayItem.name;
                        targetType.SelectedIndex = (int)displayItem.targetType;
                        useableOutOfBattle.Checked = displayItem.usableOutOfBattle;
                        effectList.Items.Clear();
                        foreach (SkillPartBase effect in displayItem.partList)
                        {
                            effectList.Items.Add(effect);
                        }
                        maxStackCount.Value = displayItem.maxStack;
                        sellPriceCount.Value = displayItem.sellAmount;
                        flavorTextBox.Text = displayItem.flavorText;
                    }
                    else
                    {
                        backPanel.Visible = false;
                        backPanel.Enabled = false;
                    }
                    previousSelectedIndex = itemList.SelectedIndex;
                }
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string name = "BattleItem";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach (BattleItemBase item in itemBoundList)
                {
                    if (item.name == name + append)
                        validName = false;
                }
            } while (!validName);
            itemBoundList.Add(new BattleItemBase(name + append, TargettingType.Self, false, new List<SkillPartBase>(), 1, 1, ""));

            if (itemBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                itemList.SelectedIndex = 0;
                itemList_SelectedIndexChanged(null, null);
            }
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this item? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(itemList.SelectedIndex);
                itemList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
                if (itemList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    itemList_SelectedIndexChanged(null, null);
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
                    MessageBox.Show("The name of the item cannot be empty or only whitespace. Please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    itemList.SelectedIndex = index;
                    return false;
                }

                for (int i = 0; i < itemBoundList.Count; i++)
                {
                    if (i == index)
                        continue;
                    //If the name they want is already in use
                    if ((itemBoundList[i]).name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the item needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        itemList.SelectedIndex = index;
                        return false;
                    }
                }
                List<SkillPartBase> tempEffectList = new List<SkillPartBase>();
                foreach (SkillPartBase effect in effectList.Items)
                {
                    tempEffectList.Add(effect);
                }
                //Stores the changed item values
                itemBoundList[index] = new BattleItemBase(nameBox.Text, (TargettingType)targetType.SelectedIndex, useableOutOfBattle.Checked,
                    tempEffectList, (int)maxStackCount.Value, (int)sellPriceCount.Value, flavorTextBox.Text);
            }
            return true;
        }

        private void BattleItemTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveItem(itemList.SelectedIndex);
        }
    }
}
