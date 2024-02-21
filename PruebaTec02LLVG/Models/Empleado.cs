using System;
using System.Collections.Generic;

namespace PruebaTec02LLVG.Models
{
    public partial class Empleado
    {
        public int EmpNo { get; set; }
        public string? Apellido { get; set; }
        public string? Oficio { get; set; }
        public short? Dir { get; set; }
        public DateTime? FechaAlt { get; set; }
        public decimal? Salario { get; set; }
        public decimal? Comision { get; set; }
        public int DeptNo { get; set; }
        public byte[]? Imagen { get; set; }

        public virtual Departamento DeptNoNavigation { get; set; } = null!;
    }
}
