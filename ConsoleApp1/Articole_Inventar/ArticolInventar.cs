using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Relevance.Articole_Inventar
{
    //clasa de baza din care sunt derivate celelate articole
    internal class ArticolInventar
    {
        public float greutate;
        public float volum;

        //constructor cu parametri
        public ArticolInventar(float greutate, float volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
