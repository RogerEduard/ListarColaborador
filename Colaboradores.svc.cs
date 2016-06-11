using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_AsignacionPCs.Dominio;
using WCF_AsignacionPCs.Errores;
using WCF_AsignacionPCs.Persistencia;

namespace WCF_AsignacionPCs
{
    public class Colaboradores : IColaboradores
    {
        private ColaboradorDAO colaboradorDAO = new ColaboradorDAO();

        public Colaborador CrearColaborador(Colaborador colaboradorCrear)
        {

            if (colaboradorDAO.obtener(colaboradorCrear.codigo) != null)
            {
                throw new FaultException<RepetidoExcepcion>
                (
                new RepetidoExcepcion()
                {
                    Codigo = "101",
                    Descripcion = "El colaborador ya existe"
                },
                new FaultReason("Error al crear"));
            }
            //if (colaboradorDAO.obtener(Convert.ToInt32(colaboradorCrear.dni)) != null)
            //{
            //    throw new FaultException<RepetidoExcepcion2>
            //    (
            //    new RepetidoExcepcion2()
            //    {
            //        Codigo = "102",
            //        Descripcion = "El DNI ya existe"
            //    },
            //    new FaultReason("Error al crear"));
            //}

            //Colaborador unidad_valida = new Colaborador();
            //unidad_valida = colaboradorDAO.obtener(Convert.ToInt32(colaboradorCrear.dni));
            //if (unidad_valida != null)
            //{
            //    throw new FaultException<RepetidoExcepcion2>
            //    (
            //    new RepetidoExcepcion2()
            //    {
            //        Codigo2 = "102",
            //        Descripcion2 = "El DNI ya existe"
            //    },
            //    new FaultReason("Error al crear"));
            //}

            return colaboradorDAO.Crear(colaboradorCrear);
            
        }

        public Colaborador ModificarColaborador(Colaborador colaboradorModificar)
        {
            return colaboradorDAO.Modificar(colaboradorModificar);
        }

        public void EliminarColaborador(int codigo)
        {
            colaboradorDAO.eliminar(codigo);
        }

        public Colaborador ObtenerColaborador(int codigo)
        {
            return colaboradorDAO.obtener(codigo);
        }

        public List<Dominio.Colaborador> ListarColaborador()
        {
            return colaboradorDAO.listar();
        }

        //public static bool Existe(int id)
        //{
        //    return ColaboradorDAO.Existe(id);
        //}

    }
}
