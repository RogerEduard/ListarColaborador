using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCF_AsignacionPCs.Errores
{
    public class Valida
    {
        [DataMember]
        public string Cod { get; set; }
        [DataMember]
        public string Des { get; set; }
    }
}