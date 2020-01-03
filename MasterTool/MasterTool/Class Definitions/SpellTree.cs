using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTool.Tools
{
    public class SpellTree
    {
        public string name { get; set; }

        public BindingList<Skill> spells;

        public SpellTree(string name, BindingList<Skill> spells)
        {
            this.name = name;
            this.spells = spells;
        }
    }
}
