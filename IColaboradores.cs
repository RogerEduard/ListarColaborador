using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_AsignacionPCs.Dominio;
using WCF_AsignacionPCs.Errores;

namespace WCF_AsignacionPCs
{
    [ServiceContract]
    public interface IColaboradores
    {
        [FaultContract(typeof(RepetidoExcepcion))]
        [FaultContract(typeof(RepetidoExcepcion2))]
        [OperationContract]
        Colaborador CrearColaborador(Colaborador colaboradorCrear);

        [OperationContract]
        Colaborador ObtenerColaborador(int codigo);

        [OperationContract]
        Colaborador ModificarColaborador(Colaborador colaboradorModificar);

        [OperationContract]
        void EliminarColaborador(int codigo);

        [OperationContract]
        List<Colaborador> ListarColaborador();

        //[OperationContract]
        //public static bool Existe(int id);
    }
}
