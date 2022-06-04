using System;

namespace Examen
{
    class estudiantes: datos
    {
        public String nombres { set; get; }
        public estudiantes(String nombres; String apellidos; String institucion; int cedula):base(nombres ,apellidos ,institucion ,cedula )
        {
            this.nombres = nombres;
        }


        public void imprimir()
        {
            Console.Write("Nombres" +nombre)
            Console.Write("Apellidos" +apellidos)
            Console.Write("Nombre de la Institucion" +institucion)
            Console.Write("Cedula de Identificacion" +cedula)
        }
    }
}