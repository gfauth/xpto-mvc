using DataModel.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Models
{
    public class HitTypeModel
    {
        public int? Id { get; private set; }
        public string Description { get; set; }

        public HitTypeModel() { }
        public HitTypeModel(int? id, string descsription)
        {
            Id = id;
            Description = descsription;
        }

        public List<HitTypeModel> GetHitTypes(DatabaseContext context)
        {
            return context.HitTypes.ToList();
        }

        public HitTypeModel GetHitType(DatabaseContext context, int id)
        {
            return context.HitTypes.FirstOrDefault(x => x.Id == id);
        }

        public HitTypeModel CreateOrUpdate(DatabaseContext context, HitTypeModel data)
        {
            if (data.Id != null)
            {
                var result = context.HitTypes.Update(data);
                return result.Entity;
            }
            else
            {
                var result = context.HitTypes.Add(data);
                return result.Entity;
            }
        }
    }
}
