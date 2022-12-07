using System;
using System.Xml.Linq;

namespace MetodologíasDeProgramaciónI
{
	public class StudentAdapter : Student
	{
		private Alumno al;
		public StudentAdapter(Alumno al)
		{
			this.al = al;
		}
		public string getName()
		{
			return al.getNombre();
		}
		public int yourAnswerIs(int question)
		{
			return al.ResponderPregunta(question);
		}
		public void setScore(int score)
		{
			al.setCalificacion = score;
		}
		public string showResult()
		{
            AlumnoDecoratorLegajo elementoDecorado = new AlumnoDecoratorLegajo((Alumno)al);
            AlumnoDecoratorLetras elementoLetras = new AlumnoDecoratorLetras((IAlumno)elementoDecorado);
            AlumnoDecoratorCasos elementoCaso = new AlumnoDecoratorCasos((IAlumno)elementoLetras);
            AlumnoDecoratorRecuadro elementoRecuadro = new AlumnoDecoratorRecuadro((IAlumno)elementoCaso);
			return elementoRecuadro.mostrarCalificacion();
        }
		public bool equals(Student student)
		{
			return al.sosIgual(((StudentAdapter)student).al);
		}
		public bool lessThan(Student student)
		{
			return al.sosMenor(((StudentAdapter)student).al);
		}
		public bool greaterThan(Student student)
		{
			return al.sosMayor(((StudentAdapter)student).al);
		}
	}
}
