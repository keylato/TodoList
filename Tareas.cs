using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace TodoList
{
    public class tareas
    {
        public string descripcion;
        public string fecha;

        public tareas(string descripcion, string fecha)
        {
            this.descripcion = descripcion;
            this.fecha = fecha;
        }
    }
}