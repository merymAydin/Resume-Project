using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class About : BaseEntity
    {
        public string Description { get; set; }
        public byte Order { get; set; }

    }


}
