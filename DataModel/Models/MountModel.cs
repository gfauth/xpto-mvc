using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Models
{
    public class MountModel
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Nivel { get; set; }
        public int Speed { get; set; }
        public int AttackPowerMin { get; set; }
        public int AttackPowerMax { get; set; }
        public int Defense { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Vitality { get; set; }
        public int CriticalRate { get; set; }
        public int MagicLevel { get; set; }
        public int MagicDefense { get; set; }
        public int ActionPower { get; set; }
        public int MultiHit { get; set; }
        public SpecialAbilityModel SpecialAbility { get; set; }
        public MountProcateModel Procate { get; set; }
    }
}
