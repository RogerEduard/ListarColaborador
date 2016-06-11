using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_AsignacionPCs.Persistencia
{
    public class Util
    {
        public string CadenaConexión { get; set; }
        public Util()
        {
            CadenaConexión = @"Data Source=(local); Initial Catalog=COLABORADOR; Integrated Security=SSPI";
        }
    }
}