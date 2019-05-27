using CapaAccesoAntecedentes.Models;
using System;
using CapaAccesoAntecedentes.Servicios;



namespace CapaAccesoAntecedentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestor CRUD para tipos de antecedentes y elementos de antecedentes a evaluar");
            Console.WriteLine("-----------------------------version 1.0------------------------------------");

            /*
          
            ServicioTipoAnt ta = new ServicioTipoAnt();
            TipoAntecedente a = new TipoAntecedente();

            a.NomTipoAnt = "otra cosa";
            ta.Add(a);
            Console.WriteLine(ta);
            Console.ReadLine();     
            
            ---------------ADD de un NUEVO ELEMENTO DE ANTECEDENTE A EVALUAR
            ServicioEltoAntEval eae = new ServicioEltoAntEval();
            EltoAntEvaluar e = new EltoAntEvaluar();
            EltoAntEvaluar e1 = new EltoAntEvaluar();

            e.NombreEltoEvaluar = "Diabetes";
            e.IdInternacion = 5;
            e.Observacion = "lo tuvo el abuelo";
            e.EstadoEltoEvaluar = true;    

            --------UPDATE de un TIPO DE ANTECEDENTE
            ServicioTipoAnt ta = new ServicioTipoAnt();
            TipoAntecedente t = new TipoAntecedente();
            t.IdTipoAnt = 6;
            t.NomTipoAnt = "otra cosa";
            ta.Edit(t);             
            */

            /*
            //-------DELETE un TIPO DE ANTECEDENTE----
             ServicioTipoAnt ta = new ServicioTipoAnt();
            TipoAntecedente t = new TipoAntecedente();
            t.IdTipoAnt = 4;    
            ta.Delete(t);     */

            ServicioInternacPaciente ip = new ServicioInternacPaciente();
            internac_paciente i = new internac_paciente();
            i.Id_personal = 2608;
            i.Imp_diagnostica = "bueno";
            i.Fecha_ingreso = DateTime.Now;
            i.Tratamiento = "PARACETAMOL 500Mg";
         //otro comentario más para ver si me funka git

        }
    }
}
