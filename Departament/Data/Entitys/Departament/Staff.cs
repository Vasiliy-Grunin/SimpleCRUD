using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departament.Data.Entitys.Departament
{
    public class Staff : IStaff
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public DateTime Birthday { get; set; }
        public string Message { get; set; }
        public bool Decret { get; set; }
    }
}
