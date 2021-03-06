﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class WeaponTypesTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<WeaponType> weaponTypeBoundList = new BindingList<WeaponType>();

        public WeaponTypesTool()
        {
            InitializeComponent();
            weaponTypeBoundList = DataStorage.WeaponTypeRegistry;
            weaponTypeList.DataSource = weaponTypeBoundList;
            weaponTypeList.DisplayMember = "name";
            if (weaponTypeBoundList.Count > 0)
            {
                weaponTypeList.SelectedIndex = 0;
                WeaponTypeList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void WeaponTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weaponTypeList.SelectedIndex != previousSelectedIndex)
            {
                if (SaveItem(previousSelectedIndex))
                {
                    if (weaponTypeList.SelectedIndex != -1)
                    {
                        backPanel.Visible = true;
                        backPanel.Enabled = true;
                        //Displays the values for the newly selected item
                        WeaponType displayItem = weaponTypeBoundList[weaponTypeList.SelectedIndex];
                        nameBox.Text = displayItem.name;
                        rangesList.Items.Clear();
                        foreach (WeaponStatsAtRange effect in displayItem.ranges)
                        {
                            rangesList.Items.Add(effect);
                        }
                        diagRangeList.Items.Clear();
                        foreach (WeaponStatsAtRange effect in displayItem.diagonalRanges)
                        {
                            diagRangeList.Items.Add(effect);
                        }
                    }
                    else
                    {
                        backPanel.Visible = false;
                        backPanel.Enabled = false;
                    }
                    previousSelectedIndex = weaponTypeList.SelectedIndex;
                }
            }
        }

        private void AddType_Click(object sender, EventArgs e)
        {
            string name = "WeaponType";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach (WeaponType item in weaponTypeBoundList)
                {
                    if (item.name == name + append)
                        validName = false;
                }
            } while (!validName);
            weaponTypeBoundList.Add(new WeaponType(name + append, new List<WeaponStatsAtRange>(), new List<WeaponStatsAtRange>()));

            if (weaponTypeBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                weaponTypeList.SelectedIndex = 0;
                WeaponTypeList_SelectedIndexChanged(null, null);
            }
        }

        private void RemoveType_Click(object sender, EventArgs e)
        {
            foreach (EquippableBase weapon in DataStorage.WeaponRegistry)
            {
                if (weapon.subType == weaponTypeList.SelectedIndex)
                {
                    MessageBox.Show("This weapon type is used by an existing weapon. Please make sure no weapon uses this type then try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (weaponTypeList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this weapon type? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                weaponTypeBoundList.RemoveAt(weaponTypeList.SelectedIndex);
                foreach (EquippableBase weapon in DataStorage.WeaponRegistry)
                {
                    if (weapon.subType > weaponTypeList.SelectedIndex)
                        weapon.subType--;
                }
                weaponTypeList.SelectedIndex = (weaponTypeBoundList.Count == 0 ? -1 : 0);
                if (weaponTypeList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    WeaponTypeList_SelectedIndexChanged(null, null);
            }
        }

        private void RangesList_DoubleClick(object sender, EventArgs e)
        {
            if (rangesList.SelectedIndex != -1)
            {
                using (WeaponStatsAtRangeTool newEffect = new WeaponStatsAtRangeTool((WeaponStatsAtRange)rangesList.SelectedItem))
                {
                    newEffect.ShowDialog(this);
                    rangesList.Items[rangesList.SelectedIndex] = newEffect.GetStats();
                }
            }
        }

        private void AddRange_Click(object sender, EventArgs e)
        {
            rangesList.Items.Add(new WeaponStatsAtRange(1, false, DamageType.Physical, false, false));
        }

        private void RemoveRange_Click(object sender, EventArgs e)
        {
            if (rangesList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this range? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                rangesList.Items.RemoveAt(rangesList.SelectedIndex);
            }
        }

        private void DiagRangeList_DoubleClick(object sender, EventArgs e)
        {
            if (diagRangeList.SelectedIndex != -1)
            {
                using (WeaponStatsAtRangeTool newEffect = new WeaponStatsAtRangeTool((WeaponStatsAtRange)diagRangeList.SelectedItem))
                {
                    newEffect.ShowDialog(this);
                    diagRangeList.Items[diagRangeList.SelectedIndex] = newEffect.GetStats();
                }
            }
        }

        private void AddDiagRange_Click(object sender, EventArgs e)
        {
            diagRangeList.Items.Add(new WeaponStatsAtRange(1, false, DamageType.Physical, false, false));
        }

        private void RemoveDiagRange_Click(object sender, EventArgs e)
        {
            if (diagRangeList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this range? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                diagRangeList.Items.RemoveAt(diagRangeList.SelectedIndex);
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
                    weaponTypeList.SelectedIndex = index;
                    return false;
                }

                for (int i = 0; i < weaponTypeBoundList.Count; i++)
                {
                    if (i == index)
                        continue;
                    //If the name they want is already in use
                    if ((weaponTypeBoundList[i]).name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the item needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        weaponTypeList.SelectedIndex = index;
                        return false;
                    }
                }

                //Stores the changed item values
                List<WeaponStatsAtRange> tempOrthoRangeList = new List<WeaponStatsAtRange>();
                foreach (WeaponStatsAtRange range in rangesList.Items)
                {
                    tempOrthoRangeList.Add(range);
                }
                List<WeaponStatsAtRange> tempDiagRangeList = new List<WeaponStatsAtRange>();
                foreach (WeaponStatsAtRange range in diagRangeList.Items)
                {
                    tempDiagRangeList.Add(range);
                }
                weaponTypeBoundList[index] = new WeaponType(nameBox.Text, tempOrthoRangeList, tempDiagRangeList);
            }
            return true;
        }

        private void WeaponTypesTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveItem(weaponTypeList.SelectedIndex);
        }
    }
}
