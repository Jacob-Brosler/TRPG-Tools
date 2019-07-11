using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovementTypes
{
    public class MovementType
    {
        public string name;
        /// <summary>
        /// For each passable tile, say if it is limited movement.
        /// Limited movement means you cannot move into and over a tile of that type in the same move.
        /// </summary>
        public Dictionary<int, bool> passableTiles;
        public int moveSpeed;

        public MovementType(string name, Dictionary<int, bool> passableTiles, int moveSpeed)
        {
            this.name = name;
            this.passableTiles = passableTiles;
            this.moveSpeed = moveSpeed;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void movementTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
