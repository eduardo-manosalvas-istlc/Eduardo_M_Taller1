using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduardo_M_Taller1.Clases
{
    public class Plato
    {
        private int id;
        private string codigo;
        private string nombre;
        private decimal precio;
        private string descripcion;
        private string ingredientes;
        private decimal costo;
        private int meta_diaria;
        private Boolean disponible;
        private Boolean aplica_promocion;
        private decimal ganancia;

        public Plato(string par_nombre, decimal par_precio, string par_descripcion, string par_ingredientes, decimal par_costo, int par_meta_diaria, bool par_disponible, bool par_aplica_promocion)
        {
            this.id = BaseDatos.BaseDeDatos.BasePlatos.Count + 1;
            this.nombre = par_nombre;
            this.precio = par_precio;
            this.descripcion = par_descripcion;
            this.ingredientes = par_ingredientes;
            this.costo = par_costo;
            this.meta_diaria = par_meta_diaria;
            this.disponible = par_disponible;
            this.aplica_promocion = par_aplica_promocion;
            this.ganancia=this.precio-this.ganancia;
            this.codigo = this.nombre.Substring(0, 2) +" -"+ this.id.ToString();
            BaseDatos.BaseDeDatos.BasePlatos.Add(this);
        }

        public void Imprimir()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Id: " + this.id.ToString());
            Console.WriteLine("Código: " + this.codigo);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Precio: $" + this.precio.ToString("F2"));
            Console.WriteLine("Costo: $" + this.costo.ToString("F2"));
            Console.WriteLine("Ganancia: $" + this.ganancia.ToString("F2"));
            Console.WriteLine("Descripcion: " + this.descripcion);
            Console.WriteLine("Ingredientes: " + this.ingredientes);
            Console.WriteLine("Meta Diaria: " + this.meta_diaria.ToString());
            Console.WriteLine("Disponible: " + (this.disponible ? "S" : "N"));
            Console.WriteLine("Aplica Promoción: " + (this.aplica_promocion ? "S" : "N"));
        }

        public string getCodigo()
        { 
            return this.codigo;
        }
        public int getId()
        {
            return this.id;
        }

        public void setDescripcion(string par_descripcion)
        {
            this.descripcion = par_descripcion;
        }


    }
}
