using System;
using System.Collections.Generic;

namespace PruebaTec02LLVG.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int DeptNo { get; set; }
        public string Dnombre { get; set; } = null!;
        public string Loc { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
