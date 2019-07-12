using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum MoveTriggers
{
    StartOfTurn,
    PassOver,
    StopOnTile,
    EndOfTurn
}

public class TileEffects
{
    public Dictionary<MoveTriggers, SkillPartBase> effects;

    public TileEffects(Dictionary<MoveTriggers, SkillPartBase> effects)
    {
        this.effects = effects;
    }
}