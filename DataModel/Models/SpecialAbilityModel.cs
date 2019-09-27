using DataModel.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Models
{
    public class SpecialAbilityModel
    {
        public int? Id { get; private set; }
        public string Effect_1 { get; set; }
        public string Effect_2 { get; set; }
        public string Effect_3 { get; set; }
        public string Effect_4 { get; set; }
        public string Effect_5 { get; set; }
        public string Effect_6 { get; set; }

        public SpecialAbilityModel() { }

        public List<SpecialAbilityModel> GetSpecialAbilities(DatabaseContext context)
        {
            return context.SpecialAbilities.ToList();
        }

        public SpecialAbilityModel GetSpecialAbility(DatabaseContext context, int id)
        {
            return context.SpecialAbilities.FirstOrDefault(x => x.Id == id);
        }

        public SpecialAbilityModel CreateOrUpdate(DatabaseContext context, SpecialAbilityModel data)
        {
            if (data.Id != null)
            {
                var result = context.SpecialAbilities.Update(data);
                return result.Entity;
            }
            else
            {
                var result = context.SpecialAbilities.Add(data);
                return result.Entity;
            }
        }
    }
}
