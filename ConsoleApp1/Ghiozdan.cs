using Proiect_Relevance.Articole_Inventar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Relevance.Articole_Inventar
{
    internal class Ghiozdan
    {
        //atributele sunt de tip readonly, pentru ca acestea sa nu poata fi modificate dupa instantiere
        private readonly int nrMaxArticole;
        private readonly float gMax;
        private readonly float vMax;

        //declararea listei care urmeaza sa fie populata de articole
        public List<ArticolInventar> articolInventar { get; set; }

        //constructor cu parametri
        public Ghiozdan(int nr, float g_max, float v_max)
        {
            this.nrMaxArticole = nr;
            this.gMax = g_max;
            this.vMax = v_max;
            this.articolInventar = new List<ArticolInventar>();
        }

        //metoda ce returneaza numarul actual de articole din ghiozdan
        public int NumarArticole()
        {
            return this.articolInventar.Count;
        }

        //metoda ce returneaza greutatea actuala a articolelor din ghiozdan
        public float GreutateArticole()
        {
            return this.articolInventar.Select(x => x.greutate).Sum();
        }

        //metoda ce returneaza volumul actual al articolelor din ghiozdan
        public float VolumArticole()
        {
            return this.articolInventar.Select(x => x.volum).Sum();
        }

        public bool Adauga(ArticolInventar articol)
        {
            //calculam numarul total al articolelor dupa adaugarea inca unuia si il comparam cu numarul maxim de articole care incap in ghiozdan
            var nr_articole = NumarArticole();
            if(nr_articole + 1 > this.nrMaxArticole) return false;

            //calculam greutatea totala dupa adaugarea articolului si o comparam cu greutatea maxima a ghiozdanului
            var greutateTotala = GreutateArticole();
            if(greutateTotala + articol.greutate > this.gMax) return false;

            //calculam volumul total dupa adaugarea articolului si il comparam cu volumul maxim al ghiozdanului
            var volumTotal = VolumArticole();
            if(volumTotal + articol.volum > this.vMax) return false;

            this.articolInventar.Add(articol);

            return true;

        }

        //metoda care permite raportarea referitoare la numarul articolelor, greutate si volum, plus limitele fiecareia
        public void StatusGhiozdan()
        {
            Console.WriteLine($"\nIn ghiozdan exista {NumarArticole()}/{this.nrMaxArticole} articole.");
            Console.WriteLine($"Ghiozdanul tine o greutate de {GreutateArticole()}/{this.gMax}.");
            Console.WriteLine($"Ghiozdanul are ocupat volumul {VolumArticole()}/{this.vMax}.\n");
        }
    }
}
    