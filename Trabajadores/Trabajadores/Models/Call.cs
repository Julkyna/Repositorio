using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Trabajadores.Models
{
    public class Call
    {
        List<Tabla> traList;
        public Call(string dbPath)
        {


            traList = new List<Tabla>();


            var reader = new StreamReader(
                File.OpenRead(dbPath));


            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();


                var valores = line.Split(',');
                traList.Add(
                    new Tabla
                    {
                        NumTrabajador = valores[0],
                        Nombre = valores[1],
                        Puesto = valores[2],
                        Salario = valores[3],
                        Antiguedad = valores[4],
                        Photo = valores[5]
                    }
                  );

            }


        }


        public Tabla GetEmployeeById(string NumTrabajador)
        {
            var trabajador = traList.Find(e => e.NumTrabajador == NumTrabajador);
            return trabajador;

        }
    }
}