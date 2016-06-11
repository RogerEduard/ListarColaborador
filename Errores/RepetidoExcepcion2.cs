using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCF_AsignacionPCs.Errores
{
    public class RepetidoExcepcion2
    {
        [DataMember]
        public string Codigo2 { get; set; }
        [DataMember]
        public string Descripcion2 { get; set; }
    }
}