using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Model
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Developer { get; set; }

        public virtual ICollection<People> Peoples { get; set; }
    }
}
