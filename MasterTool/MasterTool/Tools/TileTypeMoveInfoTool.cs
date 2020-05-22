using System.Collections.Generic;
using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class TileTypeMoveInfoTool : Form
    {
        public MovementTypeTileInfo returnEffect;

        public TileTypeMoveInfoTool(MovementTypeTileInfo tileInfo)
        {
            InitializeComponent();
            onFromUp.Checked = tileInfo.canMoveInFrom[MoveDirection.Up];
            onFromDown.Checked = tileInfo.canMoveInFrom[MoveDirection.Down];
            onFromLeft.Checked = tileInfo.canMoveInFrom[MoveDirection.Left];
            onFromRight.Checked = tileInfo.canMoveInFrom[MoveDirection.Right];
            offThroughUp.Checked = tileInfo.canMoveOutThrough[MoveDirection.Up];
            offThroughDown.Checked = tileInfo.canMoveOutThrough[MoveDirection.Down];
            offThroughLeft.Checked = tileInfo.canMoveOutThrough[MoveDirection.Left];
            offThroughRight.Checked = tileInfo.canMoveOutThrough[MoveDirection.Right];
            limitedMovement.Checked = tileInfo.limitedMovement;
            moveDifficulty.Value = tileInfo.moveDifficulty;
        }

        private void TileTypeMoveInfoTool_FormClosing(object sender, FormClosingEventArgs e)
        {

            returnEffect = new MovementTypeTileInfo(
                new Dictionary<MoveDirection, bool>()
                {
                    { MoveDirection.Up, onFromUp.Checked },
                    { MoveDirection.Down, onFromDown.Checked },
                    { MoveDirection.Left, onFromLeft.Checked },
                    { MoveDirection.Right, onFromRight.Checked }
                },
                new Dictionary<MoveDirection, bool>()
                {
                    { MoveDirection.Up, offThroughUp.Checked },
                    { MoveDirection.Down, offThroughDown.Checked },
                    { MoveDirection.Left, offThroughLeft.Checked },
                    { MoveDirection.Right, offThroughRight.Checked }
                },
                limitedMovement.Checked,
                (int)moveDifficulty.Value
                );
        }
    }
}
