using Eduardo_M_Taller1.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduardo_M_Taller1.Clases
{
    public class Cliente
    {
        private int id;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string mail;
        private string celular;
        private DateTime fecha_nacimiento;
        private int edad;
        private string nombres_completos;

        public Cliente(string par_cedula, string par_nombres, string par_apellidos, string par_direccion, string par_mail, string par_celular, DateTime par_fecha_nacimiento)
        {
            this.id = BaseDeDatos.BaseCliente.Count + 1;
            this.cedula = par_cedula;
            this.nombres = par_nombres;
            this.apellidos = par_apellidos;
            this.direccion = par_direccion;
            this.mail = par_mail;
            this.celular = par_celular;
            this.fecha_nacimiento = par_fecha_nacimiento;
            this.edad = DateTime.Now.Year - this.fecha_nacimiento.Year;
            this.nombres_completos = this.nombres + " " + this.apellidos;
            BaseDeDatos.BaseCliente.Add(this);
        }

        public string getCedula()
        {
            return this.cedula;
        }
        public void Imprimir()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Id: " + this.id.ToString());
            Console.WriteLine("Cédula: " + this.cedula);
            Console.WriteLine("Nombres: " + this.nombres);
            Console.WriteLine("Apellidos: " + this.apellidos);
            Console.WriteLine("Nombres Completos: " + this.nombres_completos);
            Console.WriteLine("Mail: " + this.mail);
            Console.WriteLine("Direccion: " + this.direccion);
            Console.WriteLine("Celular: " + this.celular);
            Console.WriteLine("Fecha Nacimiento: " + this.fecha_nacimiento.ToLongDateString());
            Console.WriteLine("Edad: " + this.edad.ToString());
        }
    }
}
