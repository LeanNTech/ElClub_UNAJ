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
using System.Collections.Generic;

namespace elclub
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Club club = new Club("Power Club");

			MostrarMenu(club);
		}

		public static void MostrarMenu(Club club)
		{
            bool termina = false;
            string opcion = "";
            

            while (!termina)
			{
				ImprimirMenu(club);

				Console.Write("Seleccione una opción para continuar: ");
				opcion = Console.ReadLine().ToUpper();
				

				switch (opcion)
				{
					case "A":
						
						break;
					case "B":
                        Console.WriteLine("CASO B");
						Console.ReadKey();
                        break;
					case "C":
                        Console.WriteLine("CASO C");
                        break;
					case "D":
                        Console.WriteLine("CASO D");
                        break;
					case "E":
                        Console.WriteLine("CASO E");
                        break;
					case "F":
						ListadosInscriptos(club);
						break;
					case "G":
						Console.WriteLine("CASO G");
						break;
					case "H":
						AgregarDeporte(club);
						break;
					case "I":
						EliminarDeporte(club);
						break;
					case "0":
						Console.WriteLine("Saliendo del programa...");
						termina = true;
						break;
					default:
						Console.WriteLine("Por favor, seleccione la opcion correcta.");
						Console.ReadKey();
						break;
				}
			}
            Console.ReadKey(true);
        }
        public static void ImprimirMenu(Club club)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al menú de ¡" + club.NombreClub + "!");
            Console.WriteLine(" ");
            Console.WriteLine("A. Dar de alta a un entrenador.");
            Console.WriteLine("B. Dar de baja a un entrenador.");
            Console.WriteLine("C. Dar de alta a un niño/socio en un deporte.");
            Console.WriteLine("D. Dar de baja a un niño/socio en un deporte.");
            Console.WriteLine("E. Simular el pago de una cuota.");
            Console.WriteLine("F. Listado de inscriptos.");
            Console.WriteLine("G. Listado de deudores.");
            Console.WriteLine("H. Agregar un deporte.");
            Console.WriteLine("I. Eliminar un deporte.");
            Console.WriteLine("0. Salir del programa.");
            Console.WriteLine(" ");
        }

        public static void AltaSocio(Club c)
        {
            string nombre, apellido, deporte, categoria;
            bool continua = false, otraVez = true;
            int edad = 0, dni = 0, op2 = 0;
            Categoria cx = null;
            Deporte dx = null;
            do
            {
                Console.WriteLine("\nPor favor, ingrese los datos de la persona que se dará de alta.");
                Console.Write("Deporte deseado: ");
                deporte = Console.ReadLine();
                Console.Write("Categoría: ");
                categoria = Console.ReadLine();
                for (int i = 0; i < c.Deportes.Count; i++)
                {
                    dx = (Deporte)c.Deportes[i];
                    if (dx.NombreDepo == deporte)
                    {
                        for (int i2 = 0; i2 < dx.Categorias.Count; i2++)
                        {
                            cx = (Categoria)dx.Categorias[i2];
                            if (cx.NombreCategoria == categoria)
                            {
                                if (dx.CantInscriptos < cx.CupoCat)
                                {
                                    continua = true;
                                    otraVez = false; break;
                                }
                                else
                                {
                                    Console.WriteLine("\nYa no existen cupos disponibles para el deporte deseado.\n");
                                }
                            }
                            if (i2 == (dx.Categorias.Count - 1) && (cx.NombreCategoria != categoria))
                            {
                                Console.WriteLine("\nLA CATEGORÍA DESEA NO EXISTE.\n");
                            }
                        }
                    }
                    if ((i == (c.Deportes.Count - 1)) && (dx.NombreDepo != deporte))
                    {
                        Console.WriteLine("\nDEPORTE NO EXISTENTE\n");
                    }
                }
                if (continua != true)
                {
                    Console.WriteLine("\nSi desea buscar otro deporte o categoría oprima 'S', para salir oprima cualquier cosa: ");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "s": otraVez = true; break;
                        case "S": otraVez = true; break;
                        default: otraVez = false; break;
                    }
                }
            } while (otraVez != false);
            if (continua == true)
            {
                Console.Write("\nComplete con los datos del niño/socio.");
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                apellido = Console.ReadLine();
                try
                {
                    Console.Write("DNI(sin puntos): ");
                    dni = int.Parse(Console.ReadLine());
                    Console.WriteLine("Edad: ");
                    edad = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPARA EL DNI Y LA EDAD INGRESE SOLO NÚMEROS.\n");
                }
                Console.WriteLine("\n¿Desea hacerse socio del club?");
                try
                {
                    Console.WriteLine(" 1.Aceptar.\n2.En otro momento.");
                    op2 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese solo un número(1 o 2).");
                }
                switch (op2)
                {
                    case 1:
                        Socio nSocio = new Socio(nombre, apellido, dni);
                        nSocio.Edad = edad;
                        c.AgregarNinio(nSocio);
                        dx.CantInscriptos = dx.CantInscriptos + 1; break;
                    case 2:
                        Ninio nNinio = new Ninio(nombre, apellido, dni);
                        nNinio.Edad = edad;
                        c.AgregarNinio(nNinio);
                        dx.CantInscriptos = dx.CantInscriptos + 1; break;
                }
            }
        }

        public static void BajaSocio(Club c)
        {
            string nombre, apellido, categoria, deporte;
            int dni = 0;
            Console.WriteLine("A continuación ingrese los datos de niño/socio que desea dar de baja.");

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Dni(sin puntos): ");
            dni = int.Parse(Console.ReadLine());

            Console.Write("Deporte: ");
            deporte = Console.ReadLine();

            Console.Write("Categoria: ");
            categoria = Console.ReadLine();
            for (int i = 0; i < c.Ninios.Count; i++)
            {
                if (c.Ninios[i] is Ninio)
                {
                    Ninio xn = (Ninio)c.Ninios[i];
                    if ((xn.Nombre == nombre) && (xn.Apellido == apellido) && (xn.Dni == dni))
                    {
                        c.EliminarNinio(xn);
                        Console.WriteLine("\nNiño/Socio dado de baja.");
                        for (int i2 = 0; i < c.Deportes.Count; i++)
                        {
                            Deporte dx = (Deporte)c.Deportes[i2];
                            if (dx.NombreDepo == deporte)
                            {
                                // Console.WriteLine("encontro el deporte.");
                                for (int i3 = 0; i3 < dx.Categorias.Count; i3++)
                                {
                                    Categoria cx = (Categoria)dx.Categorias[i3];
                                    if (cx.NombreCategoria == categoria)
                                    {
                                        // Console.WriteLine("encontro la categoria.");
                                        dx.CantInscriptos = (dx.CantInscriptos - 1); break;
                                    }
                                    if ((i3 == (dx.Categorias.Count - 1)) && (cx.NombreCategoria != categoria))
                                    {
                                        Console.WriteLine("\nCATEGORÍA NO ENCONTRADA.\n");
                                    }
                                }
                            }
                            if ((i2 == (c.Deportes.Count - 1)) && (dx.NombreDepo != deporte))
                            {
                                Console.WriteLine("\nDEPORTE NO ENCONTRADO.\n");
                            }
                        }
                        break;
                    }
                    if (i == (c.Ninios.Count - 1) && (xn.Nombre != nombre) || (xn.Apellido != apellido)
                    || (xn.Dni != dni))
                    {
                        Console.WriteLine("\nNIÑO/SOCIO NO ENCONTRADO.\n");
                    }
                }
            }
        }

        public static void SubMenuInscriptos()
		{
			Console.Clear();
			Console.WriteLine("a. Listado por deporte.");
            Console.WriteLine("b. Listado por deporte y categoría.");
            Console.WriteLine("c. Listado total.");
            Console.WriteLine(" ");
        }

		public static void ListadosInscriptos(Club club)
		{
			SubMenuInscriptos();

			bool repite = true;

			while (repite)
			{
				Console.WriteLine("Seleccione una opcion: ");
				string opcion = Console.ReadLine().ToUpper();

				switch (opcion)
				{
					case "A":
						ListadoPorDeporte();
						break;
					case "B":
						ListadoPorDeporteYCategoria();
						break;
					case "C":
						ListadoTotal();
						break;
					default:
						Console.WriteLine("La opcion ingresada es incorrecta, intente nuevamente.");
						repite = true;
						break;
				}
				Console.WriteLine("¿Desea volver al menú principal? (S/N): ");
				string volver = Console.ReadLine().ToUpper();

				if (volver == "S")
				{
					MostrarMenu(club);
					break;
				}
				else
				{
					repite = true;
				}
			}			
		}

		public static void ListadoPorDeporte()
		{

		}

		public static void ListadoPorDeporteYCategoria()
		{

		}

		public static void ListadoTotal()
		{

		}

        public static void AgregarDeporte(Club club)
		{
			string nombreDepo;			
			string nombreEntrenador;
			string apellidoEntrenador;
			int dniEntrenador;
			string categoria;
			int cupoCat;
            List<string> diasYHorarios = new List<string>();
            int costoCuota;
						
			bool continua = true;

			while (continua)
			{
				try
				{
					bool sigueDiaHorario = true;

					Console.Write("Ingrese el nombre del deporte: ");
					nombreDepo = Console.ReadLine();

					Console.Write("Ingrese la edad de la categoría: ");
					categoria = Console.ReadLine();

					bool deporteExiste = false;

					foreach (Deporte elem in club.listaDeportes)
					{
						if (elem.NombreDepo == nombreDepo && elem.NombreCategoria == categoria)
						{
							Console.WriteLine("El deporte ingresado y su respectiva categoría ya existe, intente nuevamente con otro deporte y categoría.");
							deporteExiste = true;
							break;
						}
					}

					if (!deporteExiste)
					{
						Console.Write("Ingrese el cupo máximo de la categoría: ");
						cupoCat = int.Parse(Console.ReadLine());

						Console.Write("Ingrese el nombre del entrenador: ");
						nombreEntrenador = Console.ReadLine();

						Console.Write("Ingrese el apellido del entrenador: ");
						apellidoEntrenador = Console.ReadLine();

						Console.Write("Ingrese el DNI del entrenador: ");
						dniEntrenador = int.Parse(Console.ReadLine());

						bool entrenadorExiste = true;

						foreach(Entrenador elem in club.listaEntrenadores)
						{
							if(elem.Dni != dniEntrenador)
							{
								Console.WriteLine("El entrenador que intenta asignar NO EXISTE dentro del Club. Por favor intente nuevamente.");
								entrenadorExiste = false;
								break;
							}
						}

						if (entrenadorExiste)
						{
							while (sigueDiaHorario)
							{
								Console.Write("Ingrese el día de entrenamiento (ej: martes): ");
								string dia = Console.ReadLine();

								Console.Write("Ingrese el horario de entrenamiento (ej: 15:00): ");
								string horario = Console.ReadLine();

								diasYHorarios.Add(dia + " " + horario);

								Console.Write("¿Desea agregar otro dia y horario de entrenamiento? (S/N): ");
								string opcion = Console.ReadLine().ToUpper();

								if (opcion == "S")
								{
									sigueDiaHorario = true;
								}
								else
								{
									sigueDiaHorario = false;
								}
							}

							Console.Write("Ingrese el costo de la cuota del deporte: ");
							costoCuota = int.Parse(Console.ReadLine());

							Deporte nuevoDeporte = new Deporte(nombreDepo, categoria, cupoCat, nombreEntrenador, apellidoEntrenador, dniEntrenador, diasYHorarios, costoCuota);
							club.AgregarDeporte(nuevoDeporte);

							Console.WriteLine(" ");

							Console.WriteLine("Deporte agregado correctamente!");

							Console.WriteLine("");

							Console.Write("¿Desea agregar otro deporte? (S/N): ");
							string agregarDepo = Console.ReadLine().ToUpper();

							if (agregarDepo == "S")
							{
								continua = true;
							}
							else
							{
								continua = false;
								Console.WriteLine("Volviendo al menú...");
								Console.ReadKey();
							}
						}
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("El último dato fue ingresado incorrectamente, por favor ingrese nuevamente lo que corresponda.");
					Console.WriteLine(" ");
					continua = true;
				}				
			}
		}

		public static void EliminarDeporte(Club club)
		{
			string nombreEliminar;
			string categoriaEliminar;

			bool repite = true;

			while (repite)
			{
				Console.Write("Ingrese el nombre del deporte: ");
				nombreEliminar = Console.ReadLine().ToUpper();

				Console.Write("Ingrese la categoría del deporte: ");
				categoriaEliminar = Console.ReadLine().ToUpper();

				Deporte deporteAEliminar = null;
				foreach (Deporte elem in club.listaDeportes)
				{
					if (elem.NombreDepo.ToUpper() == nombreEliminar && elem.NombreCategoria.ToUpper() == categoriaEliminar)
					{
						deporteAEliminar = elem;
						break;
					}
				}

				if (deporteAEliminar != null)
				{
					club.EliminarDeporte(deporteAEliminar);
					Console.WriteLine("Deporte eliminado exitosamente!");
				}
				else
				{
					Console.WriteLine("No se encontró el deporte ingresado. Por favor intente nuevamente con un deporte existente.");
					Console.WriteLine(" ");					
					continue;
				}

				Console.WriteLine("¿Desea eliminar otro deporte? (S/N): ");
				string opcion = Console.ReadLine();

				if(opcion.ToUpper() == "S")
				{
					repite = true;
				}
				else
				{
					repite = false;
					Console.WriteLine("Volviendo al menú...");
					Console.ReadKey();
				}
			}
		}
	}
}