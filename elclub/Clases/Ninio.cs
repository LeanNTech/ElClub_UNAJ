/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 2/11/2024
 * Hora: 16:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace elclub.Clases
{
    public class Ninio : Persona
{        
    protected DateTime ultimoMesPago;
    protected string deporte;
    protected int cat_;

    public Ninio()
    { }
    public Ninio(int dni, DateTime ultimoMesPago)
    {
        this.dni = dni;
        this.ultimoMesPago = ultimoMesPago;
    }
    public Ninio(string nombre, string apellido, int dni, string deporte, int cat_)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.deporte = deporte;
        this.cat_ = cat_;
    }
    public Ninio(string nombre, string apellido, int edad, int dni, DateTime ultimoMesPago)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.dni = dni;
        this.ultimoMesPago = ultimoMesPago;
    }
    public string Deporte
    {
        set { deporte = value; }
        get { return deporte; }
    }
    public DateTime UltimoMesPago
    {
        set { ultimoMesPago = value; }
        get { return ultimoMesPago; }
    }
    public int Cat_
    {
        set { cat_ = value; }
        get { return cat_; }
    }
}
}