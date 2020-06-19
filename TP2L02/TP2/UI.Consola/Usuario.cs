using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;
using System.Security.Cryptography.X509Certificates;

namespace UI.Consola
{
    public class Usuarios
    {
        private Business.Logic.UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio { get => _UsuarioNegocio; set => _UsuarioNegocio = value; }
        public Usuarios()
        {
            UsuarioNegocio = new Business.Logic.UsuarioLogic();
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void MostrarDatos(Usuario usr)
        {

            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.EMail);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();


        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.getOne(ID));
            }

            catch (FormatException fe)
            {
                Console.Write("El ID debe ser un entero ");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();

            }
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese un ID a modificar: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.getOne(ID);
                Console.Write("Ingrese el nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese el apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nombre de usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese mail: ");
                usuario.EMail = Console.ReadLine();
                Console.Write("Ingrese habilitacion de Usuario (1-si 2-no): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);

            }
            catch (FormatException e)
            {
                Console.WriteLine();
                Console.WriteLine("La ID debe ser un numero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }
        public void Agregar()
        {
            Usuario usuario = new Usuario();
            Console.Clear();
            Console.Write("Ingrese nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese nombre de usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese la clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese el mail: ");
            usuario.EMail = Console.ReadLine();
            Console.Write("Ingrese habilitacion de usuario (1-si/2-no): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: ", usuario.ID);
        }
        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese ID del usuario a eliminar: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException e)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();

            }
        }

        public void Menu()
        {
            int op = 0;
            while (op != 6)
            {
                Console.WriteLine("1– Listado General");
                Console.WriteLine("2– Consulta");
                Console.WriteLine("3– Agregar");
                Console.WriteLine("4 - Modificar");
                Console.WriteLine("5 - Eliminar");
                Console.WriteLine("6 - Salir");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        ListadoGeneral();
                        break;

                    case 2:

                        Consultar();
                        break;

                    case 3:

                        Agregar();
                        break;

                    case 4:

                        Modificar();
                        break;

                    case 5:

                        Eliminar();
                        break;

                }

            }





        }


    }
}
