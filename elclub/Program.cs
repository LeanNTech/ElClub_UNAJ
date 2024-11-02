/*
 * Created by SharpDevelop.
 * User: Brian
 * Date: 27/10/2024
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using elclub.Clases;

namespace elclub
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Club club = new Club("Power Club");
			int opcion = 0;
			bool continua = true;

			do
			{
				Console.Clear();

				Console.WriteLine("Bienvenido al menú del Club!");
				Console.WriteLine(" ");
				Console.WriteLine("1. Dar de alta a un entrenador.");
                Console.WriteLine("2. Dar de baja a un entrenador.");
                Console.WriteLine("3. Dar de alta a un niño/socio en un deporte.");
                Console.WriteLine("4. Dar de baja a un niño/socio en un deporte.");
                Console.WriteLine("5. Simular el pago de una cuota.");
                Console.WriteLine("6. Listado de inscriptos.");
                Console.WriteLine("7. Listado de deudores.");
                Console.WriteLine("8. Agregar un deporte.");
                Console.WriteLine("9. Eliminar un deporte.");
                Console.WriteLine("0. Salir del programa.");
                Console.Write("Seleccione una opción para continuar");

				do
				{
					try
					{
						opcion = int.Parse(Console.ReadLine());						
					}
					catch (FormatException)
					{
						Console.WriteLine("Por favor, ingrese un número correcto como opción");
						continua = false;
					}
				} while (!continua);

				switch(opcion)
				{
					case 1:
                        string nombre = "";
                        string apellido = "";
                        int edad = 0;
                        int dni = 0;
                        bool sigue = true;

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el nombre del entrenador: ");
                                nombre = Console.ReadLine();

                                Console.Write("Ingrese el apellido del entrenador: ");
                                apellido = Console.ReadLine();

                                Console.Write("Ingrese la edad del entrenador: ");
                                edad = int.Parse(Console.ReadLine());

                                Console.Write("Ingrese el DNI del entrenador: ");
                                dni = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("El formato del dato es incorrecto, por favor ingrese los datos nuevamente.");
                                sigue = false;
                            }
                            foreach (Entrenador elem in club.listaEntrenadores)
                            {
                                if (elem.Dni == dni)
                                {
                                    Console.WriteLine("El entrenador ingresado ya existe, intente nuevamente con otro entrenador.");
                                    sigue = false;
                                    break;
                                }
                                else
                                {
                                    Entrenador entrenador = new Entrenador(nombre, apellido, dni);
									club.AgregarEntrenador(entrenador);
                                }
                            }
                        } while (!sigue);
						

                    case 2:
						bool sigue = true;
						string nombreEntrenadorEliminar = "";
						string apellidoEntrenadorEliminar = "";
						int dniEntrenadorEliminar = 0;

						do
						{
							try
							{
                                Console.Write("Ingrese el nombre del entrenador: ");
                                nombreEntrenadorEliminar = Console.ReadLine();
                                nombreEntrenadorEliminar.ToUpper();

                                Console.Write("Ingrese el apellido del entrenador: ");
                                apellidoEntrenadorEliminar = Console.ReadLine();
                                apellidoEntrenadorEliminar.ToUpper();

                                Console.Write("Ingrese el DNI del entrenador a eliminar: ");
								dniEntrenadorEliminar = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Por favor, ingrese el formato correcto, para nombre y apellido solo ultilize letras, y para DNI números");
								sigue2 = false;
							}
						}while (!sigue2);

						Entrenador entrenadorEliminar = new Entrenador(nombreEntrenadorEliminar, apellidoEntrenadorEliminar, dniEntrenadorEliminar);
						club.EliminarEntrenador(entrenadorEliminar);
						Console.WriteLine("Entrenador dado de BAJA exitosamente!");
						break;

					case 3:
                        bool sigue3 = true;
                        string nombreNinio = "";
                        string apellidoNinio = "";
                        int dniNinio = 0;
						string seraSocio = "";

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el nombre del entrenador: ");
                                nombreNinio = Console.ReadLine();
                                nombreNinio.ToUpper();

                                Console.Write("Ingrese el apellido del entrenador: ");
                                apellidoNinio = Console.ReadLine();
                                apellidoNinio.ToUpper();

                                Console.Write("Ingrese el DNI del entrenador a eliminar: ");
                                dniNinio = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Por favor, ingrese el formato correcto, para nombre y apellido solo ultilize letras, y para DNI números");
                                sigue3 = false;
                            }
                        } while (!sigue3);

						do
						{
							try
							{
								Console.WriteLine("¿Desea que el niño sea socio? Ingrese SI o NO: ");
								seraSocio = Console.ReadLine();
							}
							catch (FormatException)
							{
								Console.WriteLine("Por favor, ingrese solo SI o NO");
								sigue3 = false;
							}
						} while (!sigue3);

						if(seraSocio.ToUpper() == "SI")
						{
							Socio ninioSocioAgregar = new Socio(nombreNinio, apellidoNinio, dniNinio);
							club.AgregarNinio(ninioSocioAgregar);
						}
						if(seraSocio.ToUpper() == "NO")
						{
							Ninio ninioAgregar = new Ninio(nombreNinio, apellidoNinio, dniNinio);
							club.AgregarNinio(ninioAgregar);
						}

                        Console.WriteLine("Niño dado de ALTA exitosamente!");
                        break;

                    case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					default:
				}

            } while (opcion != 0);
			
			Console.ReadKey(true);
		}
	}
}