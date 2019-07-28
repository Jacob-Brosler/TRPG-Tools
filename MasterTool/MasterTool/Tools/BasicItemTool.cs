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
    public partial class BasicItemTool : Form
    {
        int previousSelectedIndex = -1;
        BindingList<ItemBase> itemBoundList = new BindingList<ItemBase>();

        public BasicItemTool()
        {
            InitializeComponent();
            foreach(ItemBase item in DataStorage.BaseItemRegistry)
            {
                itemBoundList.Add(item);
            }
            itemList.DataSource = itemBoundList;
            itemList.DisplayMember = "Name";
            if (itemBoundList.Count > 0)
            {
                itemList.SelectedIndex = 0;
                listBox1_SelectedIndexChanged(null, null);
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string name = "Item";
            int append = 0;
            bool validName;
            do
            {
                append++;
                validName = true;
                foreach(ItemBase item in itemBoundList)
                {
                    if(item.name == name + append)
                        validName = false;
                }
            } while (!validName);
            itemBoundList.Add(new ItemBase(name + append, 1, 1, ""));
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex != -1 && MessageBox.Show(this, "Are you sure you want to delete this item? This cannot be undone.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                previousSelectedIndex = -1;
                itemBoundList.RemoveAt(itemList.SelectedIndex);
                itemList.SelectedIndex = (itemBoundList.Count == 0 ? -1 : 0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(itemList.SelectedIndex != previousSelectedIndex)
            {
                if (previousSelectedIndex != -1)
                {
                    for (int i = 0; i < itemBoundList.Count; i++)
                    {
                        if (i == previousSelectedIndex)
                            continue;
                        //If the name they want is already in use
                        if ((itemBoundList[i]).name == nameBox.Text)
                        {
                            MessageBox.Show("The name of the item needs to be unique. This name is already in use, please choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            itemList.SelectedIndex = previousSelectedIndex;
                            return;
                        }
                    }
                    //Stores the changed item values
                    itemBoundList[previousSelectedIndex] = new ItemBase(nameBox.Text, (int)maxStackCount.Value, (int)sellPriceCount.Value, flavorTextBox.Text);
                }
                //Displays the values for the newly selected item
                ItemBase displayItem = itemBoundList[itemList.SelectedIndex];
                nameBox.Text = displayItem.name;
                maxStackCount.Value = displayItem.maxStack;
                sellPriceCount.Value = displayItem.sellAmount;
                flavorTextBox.Text = displayItem.flavorText;
                previousSelectedIndex = itemList.SelectedIndex;
            }
        }
    }
}
