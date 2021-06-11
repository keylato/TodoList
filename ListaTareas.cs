using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace TodoList
{
    public class StackTareas
    {
        //hacer lista <>

       public List<tareas> listaTareas; 
       
       public int Count
       {
           get => this.listaTareas.Count;
       }

       public void PrintStack()
       {
           for (int i = 0; i< listaTareas.Count; i++);    
       }
       public StackTareas()
       {
           listaTareas = new List<tareas>();
       }

       public void Push(string descripcion, string fecha )
       {
           this.listaTareas.Add(new tareas (descripcion, fecha));
       }
       public tareas hacerTarea()
        {
           if (this.listaTareas.Count == 0)
           {
               Console.WriteLine("Ya no hay mpas tareas que hacer");
               return null;
           } 
           else 
           {
               return this.listaTareas[this.listaTareas.Count -1];
           }
        }       
        public void mostarTerminados()
        {
            for (int i = this.listaTareas.Count -1; i>=0; i--)
            {
                Console.WriteLine(listaTareas[i].descripcion + "✓");
            }
            
        
        }

        
    }

    }
