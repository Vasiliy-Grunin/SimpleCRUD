using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departament.Data.Entitys.Departament
{
    interface IStaff
    {
        int Id { get; set; }
        string FullName { get; set; }

        string Position { get; set; }

        DateTime Birthday { get; set; }

        string Message { get; set; }

        bool Decret { get; set; }
    }
}
