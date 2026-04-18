using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithGenericRepository.Entity
{
    public abstract partial  class BaseEntity 
    {
        public int  Id { get; set; }
    }
}
