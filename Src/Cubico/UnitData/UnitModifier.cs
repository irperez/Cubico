using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubico.UnitData
{
    internal class UnitModifier
    {
        public string ID { get; set; }
        public string Value { get; set; }
        public string Order { get; set; }
        public string ModifierID { get; set; }
        public string UnitSourceID { get; set; }
        public string UnitTargetID { get; set; }
        public string Precision { get; set; }
    }
}
