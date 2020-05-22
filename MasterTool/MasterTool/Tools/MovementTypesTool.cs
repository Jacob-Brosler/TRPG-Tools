using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class MovementTypesTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<MovementType> itemBoundList = new BindingList<MovementType>();
        List<MovementTypeTileInfo> tileInfos = new List<MovementTypeTileInfo>();

        public MovementTypesTool()
        {
            InitializeComponent();
            itemBoundList = DataStorage.MovementRegistry;
            moveTypeList.DataSource = itemBoundList;
            moveTypeList.DisplayMember = "name";
            tileDataList.DataSource = DataStorage.TileEffectsRegistry;
            tileDataList.DisplayMember = "name";
            if (itemBoundList.Count > 0)
            {
                moveTypeList.SelectedIndex = 0;
                moveTypeList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void moveTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moveTypeList.SelectedIndex != previousSelectedIndex)
            {
                if (SaveItem(previousSelectedIndex))
                {
                    if (moveTypeList.SelectedIndex != -1)
                    {
                        backPanel.Visible = true;
                        backPanel.Enabled = true;
                        //Displays the values for the newly selected item
                        MovementType displayItem = itemBoundList[moveTypeList.SelectedIndex];
                        nameBox.Text = displayItem.name;
                        moveSpeed.Value = displayItem.moveSpeed;
                        tileInfos = new List<MovementTypeTileInfo>();
                        tileInfos.AddRange(displayItem.tileTypeInfo.Values);
                    }
                    else
                    {
                        backPanel.Visible = false;
                        backPanel.Enabled = false;
                    }
                    previousSelectedIndex = moveTypeList.SelectedIndex;
                }
            }
        }

        private void addMoveType_Click(object sender, EventArgs e)
        {
            string name = "MoveType";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach (MovementType item in itemBoundList)
                {
                    if (item.name == name + append)
                        validName = false;
                }
            } while (!validName);

            Dictionary<int, MovementTypeTileInfo> tempInfo = new Dictionary<int, MovementTypeTileInfo>();
            for (int i = 0; i < DataStorage.TileEffectsRegistry.Count; i++)
            {
                tempInfo.Add(i, new MovementTypeTileInfo());
            }
            itemBoundList.Add(new MovementType(name + append, tempInfo, 1));

            if (itemBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                moveTypeList.SelectedIndex = 0;
                moveTypeList_SelectedIndexChanged(null, null);
            }
        }

        private void removeMoveType_Click(object sender, EventArgs e)
        {
            if (moveTypeList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this move type? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(moveTypeList.SelectedIndex);
                moveTypeList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
                if (moveTypeList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    moveTypeList_SelectedIndexChanged(null, null);
            }
        }

        private void tileDataList_DoubleClick(object sender, EventArgs e)
        {
            if (tileDataList.SelectedIndex != -1)
            {
                using (TileTypeMoveInfoTool newEffect = new TileTypeMoveInfoTool(tileInfos[tileDataList.SelectedIndex]))
                {
                    newEffect.ShowDialog(this);
                    tileInfos[tileDataList.SelectedIndex] = newEffect.returnEffect;
                }
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
                    moveTypeList.SelectedIndex = index;
                    return false;
                }

                for (int i = 0; i < itemBoundList.Count; i++)
                {
                    if (i == index)
                        continue;
                    //If the name they want is already in use
                    if (itemBoundList[i].name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the item needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        moveTypeList.SelectedIndex = index;
                        return false;
                    }
                }

                Dictionary<int, MovementTypeTileInfo> moveInfo = new Dictionary<int, MovementTypeTileInfo>();
                for (int i = 0; i < tileInfos.Count; i++)
                {
                    moveInfo.Add(i, tileInfos[i]);
                }
                //Stores the changed item values
                itemBoundList[index] = new MovementType(nameBox.Text, moveInfo, (int)moveSpeed.Value);
            }
            return true;
        }

        private void MovementTypesTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveItem(moveTypeList.SelectedIndex);
        }
    }
}
