using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTool.Tools
{
    public class SpellTree
    {
        public string Name
        {
            get
            {
                return name;
            }
        }
        
        public string name;
        public List<Skill> spells;

        public SpellTree(string name, List<Skill> spells)
        {
            this.name = name;
            this.spells = spells;
        }
    }
}
