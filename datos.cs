using System;

namespace Examen
{
    class datos
    {
        public String nombres { set; get; }
        public String apellidos { set; get; }
        public String institucion { set; get; }
        public int cedula { set; get; }

        public datos(String nombres, String apellidos, String institucion, int cedula)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.institucion = institucion;
            this.cedula = cedula;
        }
    }
}