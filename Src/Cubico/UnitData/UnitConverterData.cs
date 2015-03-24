using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubico.UnitData
{
    internal class UnitConverterData
    {       
        public Modifiers Modifiers { get; set; }
        public UnitModifiers UnitModifiers { get; set; }

        public Symbols Symbols { get; set; }
        public Units Units { get; set; }
        public UnitTypes UnitTypes { get; set; }
    }
}
