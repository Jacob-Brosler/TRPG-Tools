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

public class Vector2Int
{
    public int x;
    public int y;

    public Vector2Int(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class MovePart : SkillPartBase
{
    public MoveDirection direction;
    public int amount;
    //False if this movement was made by the pawn/from the same team
    public bool forced;

    public MovePart(TargettingType target, MoveDirection direction, int distance, bool forced = false, int chance = 100) : base(target, chance)
    {
        this.direction = direction;
        amount = distance;
        this.forced = forced;
    }
}
