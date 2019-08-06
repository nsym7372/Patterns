using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Model;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Repository())
            {
                var p = db.FindBy<People>(r => r.Name == "山田太郎").FirstOrDefault();
                foreach (var d in p.Devices)
                {
                    Console.WriteLine(string.Format(@"{0}:{1}",p.Name, d.Name));
                }
            }
        }
    }
}
