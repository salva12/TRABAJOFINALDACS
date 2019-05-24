using CapaAccesoAntecedentes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaAccesoAntecedentes
{
    class Crud
    {
        //CREATE un elemento de antecedente a evaluar

        public void CreateEAE()
        {

            Console.WriteLine("Introduzca un nombre para el nuevo elemento de antecedente a evaluar");
            string unNombreEAE;
            unNombreEAE = Console.ReadLine();

            Console.WriteLine("Introduzca el estado para el nuevo elemento de antecedente a evaluar");
            string unEstadoEAE;
            unEstadoEAE = Console.ReadLine();
            bool EstadoEAE = bool.Parse(unEstadoEAE);

            Console.WriteLine("Introduzca una observacion para el nuevo elemento de antecedente a evaluar");
            string unObservacionEAE;
            unObservacionEAE = Console.ReadLine();

            using (var context = new AntContext())
            {
                var eae = new EltoAntEvaluar()
                {
                    NombreEltoEvaluar = unNombreEAE,
                    EstadoEltoEvaluar = EstadoEAE,
                    Observacion = unObservacionEAE,
                };
                context.EltoAntEvaluars.Add(eae);
                context.SaveChanges();
            }

        }

        //UPDATE un elemento de antecedente a evaluar

        public void UpdateEAE()
        {
            Console.WriteLine("Introduzca el ID del 'elemento de antecedente a evaluar' que desea actualizar");
            string unIdEAE;
            unIdEAE = Console.ReadLine();
            int IdEAE = int.Parse(unIdEAE);

            var eae = new EltoAntEvaluar() { IdEltoAntEvaluar = IdEAE };


            Console.WriteLine("Introduzca un nuevo nombre para el 'elemento de antecedente a evaluar'");
            string unNombreEAE;
            unNombreEAE = Console.ReadLine();

            Console.WriteLine("Introduzca el nuevo estado para el 'elemento de antecedente a evaluar'");
            string unEstadoEAE;
            unEstadoEAE = Console.ReadLine();

            Console.WriteLine("Introduzca una nueva observacion para 'el nuevo elemento de antecedente a evaluar'");
            string unObservacionEAE;
            unObservacionEAE = Console.ReadLine();

            if (unNombreEAE != "") { eae.NombreEltoEvaluar = unNombreEAE; }
            if (unEstadoEAE != "") { eae.EstadoEltoEvaluar = bool.Parse(unEstadoEAE); }
            if (unObservacionEAE != "") { eae.Observacion = unObservacionEAE; }


            using (var context = new AntContext())
            {
                context.Update<EltoAntEvaluar>(eae);

                context.SaveChanges();
            }


        }

        //DELETE un elemento de antecedente a evaluar

        public void DeleteEAE()
        {
            Console.WriteLine("Introduzca el ID del 'elemento de antecedente a evaluar' que desea eliminar");
            string unIdEAE;
            unIdEAE = Console.ReadLine();
            int IdEAE = int.Parse(unIdEAE);

            var eae = new EltoAntEvaluar()
            {
                IdEltoAntEvaluar = IdEAE
            };

            using (var context = new AntContext())
            {

                context.Remove<EltoAntEvaluar>(eae);

                context.SaveChanges();
            }
        }

        /*
        public void ReadEAE()
        {
            Console.WriteLine("Introduzca el nombre del 'elemento de antecedente a evaluar' que desea buscar");
            string unNombreEAE;
            unNombreEAE = Console.ReadLine();

            using (var context = new AntContext())
            {
                var eltoAntEvaluars = context.EltoAntEvaluars
                    .Where(eltoAntEvaluar => eltoAntEvaluar.NombreEltoEvaluar.Contains(unNombreEAE))
                    .ToList();
            }
        }
        */


        //CREATE un tipo de antecedente

        public void CreateTA()
        {

            Console.WriteLine("Introduzca un nombre para el nuevo tipo de antecedente");
            string unNombreTA;
            unNombreTA = Console.ReadLine();
            using (var context = new AntContext())
            {
                var ta = new TipoAntecedente()
                {
                    NomTipoAnt = unNombreTA,
                };
                context.TipoAntecedentes.Add(ta);
                context.SaveChanges();
            }

        }

        //UPDATE un tipo de antecedente 

        public void UpdateTA()
        {
            Console.WriteLine("Introduzca el ID del tipo de antecedente que desea actualizar");
            string unIdTA;
            unIdTA = Console.ReadLine();
            int IdTA = int.Parse(unIdTA);
            var ta = new TipoAntecedente() { IdTipoAnt = IdTA };


            Console.WriteLine("Introduzca el nuevo nombre del tipo de antecedente para actualizarlo");
            string unNombreTA;
            unNombreTA = Console.ReadLine();

            ta.NomTipoAnt = unNombreTA;

            using (var context = new AntContext())
            {
                context.Update<TipoAntecedente>(ta);

                context.SaveChanges();
            }


        }

        //DELETE un tipo de antecedente

        public void DeleteTA()
        {
            Console.WriteLine("Introduzca el ID del tipo de antecedente que desea eliminar");
            string unIdTA;
            unIdTA = Console.ReadLine();
            int IdTA = int.Parse(unIdTA);

            var ta = new TipoAntecedente()
            {
                IdTipoAnt = IdTA
            };

            using (var context = new AntContext())
            {

                context.Remove<TipoAntecedente>(ta);

                context.SaveChanges();
            }
        }
    }
}
