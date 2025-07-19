using Eduardo_M_Taller1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduardo_M_Taller1.BaseDatos
{
    public static class BaseDeDatos
    {
        public static List<Plato> BasePlatos = new List<Plato>();
        public static List<Cliente> BaseCliente = new List<Cliente>();

        public static void ListarPlatos()
        {
            foreach (var item in BasePlatos)
            {
                item.Imprimir();
            }
        }

        public static Plato GetPlatoXCodigo(string codigo)
        {
            foreach (var item in BasePlatos)
            {
               if (item.getCodigo() == codigo)
                {
                    return item;
                }
            }

            return null;
        }


        public static void ListarClientes()
        {
            foreach (var item in BaseCliente)
            {
                item.Imprimir();
            }
        }

        public static Cliente GetClienteXCedula(string cedula)
        {
            foreach (var item in BaseCliente)
            {
                if (item.getCedula() == cedula)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
