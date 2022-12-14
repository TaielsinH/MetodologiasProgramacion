
using System;
using System.Collections.Generic;
//no deberíamos modificar una interface
namespace MetodologíasDeProgramaciónI
{

    public interface Comparable
    {
        bool sosIgual(Comparable c);
        bool sosMenor(Comparable c);
        bool sosMayor(Comparable c);

    }
    public interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene(Comparable c);
    }
    public interface IAlumno
    {
        int getLegajo();
        int getCalificacion();
        string mostrarCalificacion();
        string getNombre();
    }



}
