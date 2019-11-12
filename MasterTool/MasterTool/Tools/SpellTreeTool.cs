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
    public partial class SpellTreeTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<SpellTree> itemBoundList = new BindingList<SpellTree>();

        public SpellTreeTool()
        {
            InitializeComponent();
            itemBoundList = DataStorage.spellTreeRegistry;
            spellTreeList.DataSource = itemBoundList;
            spellTreeList.DisplayMember = "Name";
            if (itemBoundList.Count > 0)
            {
                spellTreeList.SelectedIndex = 0;
                spellTreeList_SelectedIndexChanged(null, null);
            }
            else
            {
                backPanel.Visible = false;
                backPanel.Enabled = false;
            }
        }

        private void spellTreeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spellTreeList.SelectedIndex != previousSelectedIndex)
            {
                if (SaveItem(previousSelectedIndex))
                {
                    if (spellTreeList.SelectedIndex != -1)
                    {
                        backPanel.Visible = true;
                        backPanel.Enabled = true;
                        nameBox.Text = itemBoundList[spellTreeList.SelectedIndex].name;
                    }
                    else
                    {
                        backPanel.Visible = false;
                        backPanel.Enabled = false;
                    }
                    previousSelectedIndex = spellTreeList.SelectedIndex;
                }
            }
        }

        private void addTree_Click(object sender, EventArgs e)
        {
            string name = "SpellTree";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach (SpellTree item in itemBoundList)
                {
                    if (item.name == name + append)
                        validName = false;
                }
            } while (!validName);
            itemBoundList.Add(new SpellTree(name + append, new BindingList<Skill>()));

            if (itemBoundList.Count == 1)
            {
                backPanel.Visible = true;
                backPanel.Enabled = true;
                spellTreeList.SelectedIndex = 0;
                spellTreeList_SelectedIndexChanged(null, null);
            }
        }

        private void removeTree_Click(object sender, EventArgs e)
        {
            if (spellTreeList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this spell tree? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(spellTreeList.SelectedIndex);
                spellTreeList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
                if (spellTreeList.SelectedIndex == -1)
                {
                    backPanel.Visible = false;
                    backPanel.Enabled = false;
                }
                else
                    spellTreeList_SelectedIndexChanged(null, null);
            }
        }

        private void editSpells_Click(object sender, EventArgs e)
        {
            SpellTool spellScreen = new SpellTool(itemBoundList[spellTreeList.SelectedIndex]);

            if(!spellScreen.IsDisposed)
                spellScreen.ShowDialog(this);
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
                    MessageBox.Show("The name of the spell tree cannot be empty or only whitespace. Please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    spellTreeList.SelectedIndex = index;
                    return false;
                }

                for (int i = 0; i < itemBoundList.Count; i++)
                {
                    if (i == index)
                        continue;
                    //If the name they want is already in use
                    if ((itemBoundList[i]).name == nameBox.Text)
                    {
                        MessageBox.Show("The name of the spell tree needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        spellTreeList.SelectedIndex = index;
                        return false;
                    }
                }
                itemBoundList[index].name = nameBox.Text;
            }
            return true;
        }

        private void SpellTreeTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SaveItem(spellTreeList.SelectedIndex);
        }
    }
}
