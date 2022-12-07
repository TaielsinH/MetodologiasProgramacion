
using System;

namespace MetodologíasDeProgramaciónI
{


    public class Alumno : Persona, IAlumno
    {
        private int legajo;
        private float promedio;
        private static string opcion = "promedio";
        private int calificacion;
        public Alumno(string n, int d, int legajo, float promedio) : base(n, d)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }
        public static string Opcion
        {
            get { return opcion; }
            set { opcion = value; }
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            Random random = new Random();
            int num = random.Next(1, 3);
            return num;

        }
        public string mostrarCalificacion()
        {
            return nombre + "      " + calificacion.ToString();
        }
        public int getLegajo()
        {
            return legajo;
        }
        public int setCalificacion{set { calificacion = value; }}
        public int getCalificacion()
        {
            return calificacion;
        }
        public float getPromedio { get { return promedio; } }

        public override bool sosIgual(Comparable c)
        {
            if (opcion == "legajo")
                return legajo == ((Alumno)c).getLegajo();
            else
                return promedio == ((Alumno)c).getPromedio;
        }
        public override bool sosMenor(Comparable c)
        {
            if (opcion == "legajo")
                return legajo < ((Alumno)c).getLegajo();
            else
                return promedio < ((Alumno)c).getPromedio;
        }
        public override bool sosMayor(Comparable c)
        {
            if (opcion == "legajo")
                return legajo > ((Alumno)c).getLegajo();
            else
                return promedio > ((Alumno)c).getLegajo();
        }
        public override string ToString()
        {
            return nombre + " dni: " + dni.ToString() + "  legajo: " + legajo.ToString() + "  promedio: " + promedio.ToString();
        }

    }
}

