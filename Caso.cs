using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dgs
{
    class Caso
    {
        #region Estado
        string regiao;
        int idades;
        string genero;
        int nCasos = 0;

        #endregion

        #region Constructor

        //public Caso()
        //{
        //    regiao = "";
        //    idades = 0;
        //}
        
        public Caso(string rRegiao, int iIdade, string gGenero)
        {
            regiao = rRegiao;
            idades = iIdade;
            genero = gGenero;
            nCasos++;
        }


        #endregion

        #region Properties
        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        public int Idades
        {
            get { return idades; }
            set { if (value > 0 && value < 115) idades = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        #endregion


    }
}