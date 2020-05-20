namespace MasterTool.Tools
{
    class TileType
    {
        public string name { get; set; }
        public string flavorText;
        public bool blocksMeleeAttacks;
        public bool blocksRangedAttacks;
        public SkillPartBase startOfTurn;
        public SkillPartBase passOver;
        public SkillPartBase stopOnTile;
        public SkillPartBase endOfTurn;

        public TileType(string name, string flavorText)
        {
            this.name = name;
            this.flavorText = flavorText;
        }
    }
}
