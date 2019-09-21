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
    public partial class TileTypesTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<TileType> itemBoundList = new BindingList<TileType>();
        SkillPartBase defaultPart = new AddTriggerPart(TargettingType.Self, new TriggeredEffect(EffectTriggers.FallBelow25Percent));

        public TileTypesTool()
        {
            InitializeComponent();
            itemBoundList = DataStorage.tileEffectsRegistry;
            tileList.DataSource = itemBoundList;
            tileList.DisplayMember = "Name";
            if (itemBoundList.Count > 0)
            {
                tileList.SelectedIndex = 0;
                TileList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void AddTileType_Click(object sender, EventArgs e)
        {
            string name = "TileType";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach (TileType item in itemBoundList)
                {
                    if (item.name == name + append)
                        validName = false;
                }
            } while (!validName);
            itemBoundList.Add(new TileType(name + append, ""));

            if (itemBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                tileList.SelectedIndex = 0;
                TileList_SelectedIndexChanged(null, null);
            }
        }

        private void RemoveTileType_Click(object sender, EventArgs e)
        {
            if (tileList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this spell tree? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(tileList.SelectedIndex);
                tileList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
                if (tileList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    TileList_SelectedIndexChanged(null, null);
            }
        }

        private void TileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (previousSelectedIndex != -1)
            {
                if (string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    MessageBox.Show("The name of the tile cannot be empty or only whitespace. Please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tileList.SelectedIndex = previousSelectedIndex;
                    return;
                }

                for (int i = 0; i < itemBoundList.Count; i++)
                {
                    if (i == previousSelectedIndex)
                        continue;
                    //If the name they want is already in use
                    if (itemBoundList[i].name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the tile needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tileList.SelectedIndex = previousSelectedIndex;
                        return;
                    }
                }
                //Stores the changed item values
                itemBoundList[previousSelectedIndex] = new TileType(nameBox.Text, flavorTextBox.Text)
                {
                    startOfTurn = startOfTurn.Checked ? itemBoundList[previousSelectedIndex].startOfTurn : null,
                    passOver = passOver.Checked ? itemBoundList[previousSelectedIndex].passOver : null,
                    stopOnTile = stopOnTile.Checked ? itemBoundList[previousSelectedIndex].stopOnTile : null,
                    endOfTurn = endOfTurn.Checked ? itemBoundList[previousSelectedIndex].endOfTurn : null,
                };
            }
            if (tileList.SelectedIndex != -1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                nameBox.Text = itemBoundList[tileList.SelectedIndex].name;
                flavorTextBox.Text = itemBoundList[tileList.SelectedIndex].flavorText;
                startOfTurnButton.Enabled = startOfTurn.Checked = itemBoundList[tileList.SelectedIndex].startOfTurn != null;
                passOverButton.Enabled = passOver.Checked = itemBoundList[tileList.SelectedIndex].passOver != null;
                stopOnTileButton.Enabled = stopOnTile.Checked = itemBoundList[tileList.SelectedIndex].stopOnTile != null;
                endOfTurnButton.Enabled = endOfTurn.Checked = itemBoundList[tileList.SelectedIndex].endOfTurn != null;
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
            previousSelectedIndex = tileList.SelectedIndex;
        }

        private void StartOfTurn_CheckedChanged(object sender, EventArgs e)
        {
            startOfTurnButton.Enabled = startOfTurn.Checked;
            if (startOfTurn.Checked && itemBoundList[tileList.SelectedIndex].startOfTurn == null)
                itemBoundList[tileList.SelectedIndex].startOfTurn = defaultPart;
        }

        private void PassOver_CheckedChanged(object sender, EventArgs e)
        {
            passOverButton.Enabled = passOver.Checked;
            if (passOver.Checked && itemBoundList[tileList.SelectedIndex].passOver == null)
                itemBoundList[tileList.SelectedIndex].passOver = defaultPart;
        }

        private void StopOnTile_CheckedChanged(object sender, EventArgs e)
        {
            stopOnTileButton.Enabled = stopOnTile.Checked;
            if (stopOnTile.Checked && itemBoundList[tileList.SelectedIndex].stopOnTile == null)
                itemBoundList[tileList.SelectedIndex].stopOnTile = defaultPart;
        }

        private void EndOfTurn_CheckedChanged(object sender, EventArgs e)
        {
            endOfTurnButton.Enabled = endOfTurn.Checked;
            if (endOfTurn.Checked && itemBoundList[tileList.SelectedIndex].endOfTurn == null)
                itemBoundList[tileList.SelectedIndex].endOfTurn = defaultPart;
        }

        private void StartOfTurnButton_Click(object sender, EventArgs e)
        {
            using (SkillPartTool skillScreen = new SkillPartTool(itemBoundList[tileList.SelectedIndex].startOfTurn ?? defaultPart))
            {
                skillScreen.ShowDialog(this);

                itemBoundList[tileList.SelectedIndex].startOfTurn = skillScreen.returnEffect;
            }
        }

        private void PassOverButton_Click(object sender, EventArgs e)
        {
            using (SkillPartTool skillScreen = new SkillPartTool(itemBoundList[tileList.SelectedIndex].passOver ?? defaultPart))
            {
                skillScreen.ShowDialog(this);

                itemBoundList[tileList.SelectedIndex].passOver = skillScreen.returnEffect;
            }
        }

        private void StopOnTileButton_Click(object sender, EventArgs e)
        {
            using (SkillPartTool skillScreen = new SkillPartTool(itemBoundList[tileList.SelectedIndex].stopOnTile ?? defaultPart))
            {
                skillScreen.ShowDialog(this);

                itemBoundList[tileList.SelectedIndex].stopOnTile = skillScreen.returnEffect;
            }
        }

        private void EndOfTurnButton_Click(object sender, EventArgs e)
        {
            using (SkillPartTool skillScreen = new SkillPartTool(itemBoundList[tileList.SelectedIndex].endOfTurn ?? defaultPart))
            {
                skillScreen.ShowDialog(this);

                itemBoundList[tileList.SelectedIndex].endOfTurn = skillScreen.returnEffect;
            }
        }
    }
}
