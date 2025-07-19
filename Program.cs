using Eduardo_M_Taller1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduardo_M_Taller1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║                RUKITO SYSTEM               ║");
                Console.WriteLine("╠════════════════════════════════════════════╣");
                Console.WriteLine("║                  MENÚ PRINCIPAL            ║");
                Console.WriteLine("╠════════════════════════════════════════════╣");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("║  1. Crear Plato                            ║");
                Console.WriteLine("║  2. Listar los Platos                      ║");
                Console.WriteLine("║  3. Consultar Plato                        ║");
                Console.WriteLine("║  4. Modificar Plato                        ║");
                Console.WriteLine("║  5. Eliminar Plato                         ║");
                Console.WriteLine("║  6. Crear Cliente                          ║");
                Console.WriteLine("║  7. Listar los Clientes                    ║");
                Console.WriteLine("║  8. Consultar Cliente                      ║");
                Console.WriteLine("║  9. Modificar Cliente                      ║");
                Console.WriteLine("║ 10. Eliminar Cliente                       ║");
                Console.WriteLine("║ 11. Salir                                  ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.ResetColor();
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        crearPlato();
                        break;
                    case "2":
                        ListarPlatos();
                        break;
                    case "3":
                        ConsultarPlato();
                        break;
                    case "4":
                        ModificarPlato();
                        break;
                    case "5":
                        EliminarPlato();
                        break;
                    case "6":
                        crearCliente();
                        break;
                    case "7":
                        ListarClientes();
                        break;
                    case "8":
                        ConsultarCliente();
                        break;
                    case "9":
                        ModificarCliente();
                        break;
                    case "10":
                        EliminarCliente();
                        break;
                    case "11":
                        Console.WriteLine("Saliendo del Sistema");
                        Console.ReadLine();
                        return;
                        break;
                    default:
                        Console.WriteLine("Escoja una opción valida");
                        break;
                }


            }
        }

        private static void EliminarCliente()
        {
            Console.Clear();
            Console.Write("Ingrese la cédula del cliente:");
            string cedula = Console.ReadLine();
            Cliente objClienteConsultado = BaseDatos.BaseDeDatos.GetClienteXCedula(cedula);

            if (objClienteConsultado == null)
            {
                Console.WriteLine("No se encontró el código buscado");
            }
            else
            {
                Console.WriteLine("¿Está seguro que desea eliminar el cliente? (S/N)");
                string respuesta = Console.ReadLine();
                if (respuesta == "S")
                {
                    BaseDatos.BaseDeDatos.BaseCliente.Remove(objClienteConsultado);
                    Console.WriteLine("Cliente eliminado con éxito!");
                }
            }
            Console.ReadLine();
        }

        private static void ModificarCliente()
        {
            Console.Clear();
            Console.ReadLine();
        }

        private static void ConsultarCliente()
        {
            Console.Clear();
            Console.Write("Ingrese la cédula del cliente:");
            string cedula = Console.ReadLine();

            Cliente objClienteConsultado = BaseDatos.BaseDeDatos.GetClienteXCedula(cedula);

            if (objClienteConsultado == null)
            {
                Console.WriteLine("No se encontró la cédula buscada");
            }
            else
            {
                objClienteConsultado.Imprimir();
            }
            Console.ReadLine();
        }

        private static void ListarClientes()
        {
            Console.Clear();
            BaseDatos.BaseDeDatos.ListarClientes();
            Console.ReadLine();
        }

        private static void crearCliente()
        {
            Console.Clear();
            string par_cedula; 
            string par_nombres; 
            string par_apellidos;
            string par_direccion;
            string par_mail;
            string par_celular;
            DateTime par_fecha_nacimiento;

            Console.Write("Ingrese la Cédula del Cliente: ");
            par_cedula = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese los Nombres del Cliente: ");
            par_nombres = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese los Apellidos del Cliente: ");
            par_apellidos = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese la Dirección del Cliente: ");
            par_direccion = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el mail del Cliente: ");
            par_mail = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el Celular del Cliente: ");
            par_celular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese la Fecha Nacimiento del Cliente: ");
            par_fecha_nacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Cliente obj = new Cliente(par_cedula, par_nombres, par_apellidos, par_direccion, par_mail, par_celular, par_fecha_nacimiento);
            Console.WriteLine("Cliente creado con éxito!");

            Console.ReadLine();
        }

        private static void EliminarPlato()
        {
            Console.Clear();
            Console.Write("Ingrese el código del plato:");
            string codigo = Console.ReadLine();
            Plato objPlatoConsultado = BaseDatos.BaseDeDatos.GetPlatoXCodigo(codigo);

            if (objPlatoConsultado == null)
            {
                Console.WriteLine("No se encontró el código buscado");
            }
            else
            {
                Console.WriteLine("¿Está seguro que desea eliminar el plato? (S/N)");
                string respuesta=Console.ReadLine();
                if (respuesta == "S")
                {
                    BaseDatos.BaseDeDatos.BasePlatos.Remove(objPlatoConsultado);
                    Console.WriteLine("Plato eliminado con éxito!");
                }
            }          
            Console.ReadLine();
        }

        private static void ModificarPlato()
        {
            Console.Clear();
            Console.ReadLine();
        }

        private static void ConsultarPlato()
        {
            Console.Clear();
            Console.Write("Ingrese el código del plato:");
            string codigo= Console.ReadLine();

            Plato objPlatoConsultado= BaseDatos.BaseDeDatos.GetPlatoXCodigo(codigo);

            if (objPlatoConsultado == null)
            {
                Console.WriteLine("No se encontró el código buscado");
            }
            else
            {
                objPlatoConsultado.Imprimir();
            }
            Console.ReadLine();
        }

        private static void ListarPlatos()
        {
            Console.Clear();
            BaseDatos.BaseDeDatos.ListarPlatos();
            Console.ReadLine();
        }

        private static void crearPlato()
        {
            Console.Clear();
            string par_nombre; 
            decimal par_precio; 
            string par_descripcion; 
            string par_ingredientes; 
            decimal par_costo; 
            int par_meta_diaria; 
            bool par_disponible; 
            bool par_aplica_promocion;

            Console.Write("Ingrese el Nombre del Plato: ");
            par_nombre = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese la Descripción del Plato: ");
            par_descripcion = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese los Ingredientes del Plato: ");
            par_ingredientes = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el Precio del Plato: ");
            par_precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Ingrese el Costo del Plato: ");
            par_costo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Ingrese la Meta Diaria del Plato: ");
            par_meta_diaria= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine();

            Console.Write("¿Está disponible el plato? (S/N) ");
            par_disponible = (Console.ReadLine() == "S" ? true : false);
            Console.WriteLine();

            Console.Write("¿Aplica promoción el plato? (S/N) ");
            par_aplica_promocion = (Console.ReadLine() == "S" ? true : false);
            Console.WriteLine();

            Plato objPlato = new Plato(par_nombre,par_precio, par_descripcion,par_ingredientes, par_costo,par_meta_diaria,par_disponible,par_aplica_promocion);
            Console.WriteLine("Plato agregado con éxito!");

            Console.ReadLine();
        }
    }
}
