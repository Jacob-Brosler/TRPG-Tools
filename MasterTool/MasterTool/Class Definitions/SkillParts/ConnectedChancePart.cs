using System.Collections.Generic;

class ConnectedChancePart : SkillPartBase
{
    public List<ConnectedChanceEffect> effects = new List<ConnectedChanceEffect>();
    //What counts as a 100% chance for this weighting
    public int chanceOutOf;

    public ConnectedChancePart() { }

    public ConnectedChancePart(TargettingType target, List<ConnectedChanceEffect> effects, int chanceOutOf, int chance = 100) : base(target, chance)
    {
        this.effects = effects;
        this.chanceOutOf = chanceOutOf;
    }
}