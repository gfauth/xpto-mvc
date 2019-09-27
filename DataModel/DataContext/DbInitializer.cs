using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.DataContext
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Users.Any())
                context.Users.Add(new UserModel(null, "Luan Fauth", "luan@fillet.com.br", "VkBqcmFraWxhaWEx"));

            if (context.SpecialAbilities.Any())
            {
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in TBS battle(Mercenaries included)", Effect_2 = "Attack Power increases by 10% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 15% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 15% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 5% in TBS battle(Mercenaries included)",Effect_2 = "Attack Power increases by 10% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 10% in normal battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 5% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in normal battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 10% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Max Auto-Battles +10"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Max Auto-Battles +20"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 20% in normal battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in TBS battle(Mercenaries included)",Effect_2 = "Def increases by 15% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Rest Exp increased by 300%",Effect_2 = "Food use effects increase by 20%",Effect_3 = "Potion use effects increase by 20%",Effect_4 = "Scroll use effects increase by 20%"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in normal battles(Mercenaries included)",Effect_2 = "Def increases by 15% in normal battles(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Rest Exp increased by 300%"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Rest Exp increased by 200%"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in normal battles(Mercenaries included)",Effect_2 = "Attack Power increases by 10% in TBS battles(Mercenaries included)",Effect_3 = "Transforms the Search Robot into a mount"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 15% in normal battles(Mercenaries included)",Effect_2 = "Attack Power increases by 15% in TBS battles(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in normal battles(Mercenaries included)",Effect_2 = "Def increases by 15% in normal battles(Mercenaries included)",Effect_3 = "Transforms the Search Robot into a mount"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Food use effects increase by 20%",Effect_2 = "Potion use effects increase by 20%",Effect_3 = "Scroll use effects increase by 20%"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 15% in normal battles(Mercenaries included)",Effect_2 = "Attack Power increases by 15% in TBS battles(Mercenaries included)",Effect_3 = "Max Auto-Battles +20"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 20% in TBS battle(Mercenaries included)",Effect_2 = "Def increases by 10% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 5% in normal battles(Mercenaries included)",Effect_2 = "Attack Power increases by 5% in TBS battles(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Grants a chance to revive when near death(50% health, stun, once per battle)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Food use effects increase by 25%",Effect_2 = "Potion use effects increase by 25%",Effect_3 = "Scroll use effects increase by 25%"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in TBS battles(Mercenaries included)",Effect_2 = "Def increases by 5% in TBS battles(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 10% in normal battles(Mercenaries included)",Effect_2 = "Def increases by 5% in normal battles(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Use 1 more mercenary per turn(VS monsters only)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in TBS battle(Mercenaries included)",Effect_2 = "Attack Power increases by 15% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 15% in normal battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Atk increases by 5% in normal battle(Mercenaries included)",Effect_2 = "Max Auto-Battles +10"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Atk increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Max Auto-Battles +20"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 15% in normal battle(Mercenaries included)",Effect_3 = "Grants a chance to revive when near death(50% health, stun, once per battle)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 15% in normal battles(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 15% in normal battles(Mercenaries included)",Effect_2 = "Attack Power increases by 10% in TBS battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Attack Power increases by 20% in TBS battle(Mercenaries included)",Effect_2 = "Attack Power increases by 20% in normal battle(Mercenaries included)",Effect_3 = "Max Auto-Battles +20"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 20% in normal battle(Mercenaries included)"});
                context.SpecialAbilities.Add(new SpecialAbilityModel() { Effect_1 = "Def increases by 10% in normal battle(Mercenaries included)",Effect_2 = "Attack Power increases by 20% in normal battle(Mercenaries included)",Effect_3 = "Max Auto-Battles +20"});
            }

            if (!context.HitTypes.Any())
            {
                context.HitTypes.Add(new HitTypeModel(null, "Self"));
                context.HitTypes.Add(new HitTypeModel(null, "Friendly Column"));
                context.HitTypes.Add(new HitTypeModel(null, "Friendly Row"));
                context.HitTypes.Add(new HitTypeModel(null, "Single Enemy"));
                context.HitTypes.Add(new HitTypeModel(null, "First two in Enemy Column"));
                context.HitTypes.Add(new HitTypeModel(null, "Enemy Column"));
                context.HitTypes.Add(new HitTypeModel(null, "Enemy Row"));
                context.HitTypes.Add(new HitTypeModel(null, "Enemy Formation"));
                context.HitTypes.Add(new HitTypeModel(null, "Nothing"));
            }

            context.SaveChanges();
        }
    }
}


















































































































