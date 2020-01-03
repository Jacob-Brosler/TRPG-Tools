using System.Collections;
using System.Collections.Generic;

public enum MoveDirection
{
    Up,
    Right,
    Down,
    Left,
    Random,
    FromCenter
}

public class MovePart : SkillPartBase
{
    public MoveDirection direction;
    public int amount;
    //False if this movement was made by the pawn/from the same team
    public bool forced;

    public MovePart() { }

    public MovePart(TargettingType target, MoveDirection direction, int distance, bool forced = false, int chance = 100) : base(target, chance)
    {
        this.direction = direction;
        amount = distance;
        this.forced = forced;
    }
}
