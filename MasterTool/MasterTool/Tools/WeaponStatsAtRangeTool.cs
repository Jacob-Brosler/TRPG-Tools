using System.Windows.Forms;

namespace MasterTool.Tools
{
    public partial class WeaponStatsAtRangeTool : Form
    {
        public WeaponStatsAtRangeTool(WeaponStatsAtRange stats)
        {
            InitializeComponent();
            damageType.SelectedIndex = (int)stats.damageType;
            range.Value = stats.atDistance;
            canDamage.Checked = stats.damages;
            ranged.Checked = stats.ranged;
            damageMod.Value = (decimal)stats.damageMult;
            canHeal.Checked = stats.heals;
        }

        public WeaponStatsAtRange GetStats()
        {
            return new WeaponStatsAtRange(decimal.ToInt32(range.Value), ranged.Checked,
                (DamageType)damageType.SelectedIndex, canDamage.Checked, canHeal.Checked,
                (float)damageMod.Value);
        }
    }
}
