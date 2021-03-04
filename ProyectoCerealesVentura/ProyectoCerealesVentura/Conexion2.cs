using System;
using System.Data;

namespace ProyectoCerealesVentura
{
    class Conexion2
    {
        Conexion1 conec = new Conexion1();
        public void Login()
        {
           DataRow[] dat= conec.readQuery("Select * from Usuario", "Tabla1",true);
        if (dat.Length == 1)
            {
                Console.WriteLine("El usuario existe");
            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }
        }

        public void Registro()
        {
            bool set = conec.setData(string.Format("Insert into Tabla1 (Usuario,Contraseña,Correo,Telefono), values('{0}','{1}','{2}','{3}')", "Miguel", "Miguel123", "MiguelMarcos@hotmail.com"));

            if (set)
            {
                Console.WriteLine("Existe Usuario");
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
    }

}