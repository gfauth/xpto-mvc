using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Models
{
    public class MountProcateModel
    {
        public int Id { get; private set; }
        public int Name { get; set; }
        public int Duration { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public decimal Rate { get; set; }
        public HitTypeModel HitType { get; set; }
    }
}
