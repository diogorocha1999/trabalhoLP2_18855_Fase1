// -------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
// Copyright IPCA-EST. All rights reserved.
// </copyright>
// <summary>
//	trabalhoLP2_18855_Fase1
// </summary>
// <desc>
// Define obitos.
// </desc>
//-------------------------------------------------
using System;

namespace Dgs
{
    class Obitos: Caso
    {
        #region Atributos
        string causaMorte;
        const int MAX = 3;
        Obitos[] aObitos = new Obitos[MAX];
        #endregion

        #region Construtor
        public Obitos()
        {

        }

        /// <summary>
        /// Construtor com dados do exterior
        /// </summary>
        /// <param name="rRegiao"></param>
        /// <param name="iIdade"></param>
        /// <param name="gGenero"></param>
        /// <param name="cMorte"></param>
        public Obitos(string rRegiao, int iIdade, string gGenero, string cMorte) : base (rRegiao, iIdade, gGenero)
        {
            causaMorte = cMorte;
            aObitos = new Obitos[MAX];
        }
        #endregion


        #region Propriedades
        /// <summary>
        /// Manipula atributo causaMorte
        /// </summary>
        public string CausaMorte
        {
            get { return causaMorte; }
            set { causaMorte = value; }
        }

        /// <summary>
        /// Indexador de posição
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Obitos this[int i]
        {
            get { return aObitos[i]; }
            set { aObitos[i] = value; }
        }



        #endregion

        #region Metodos

        /// <summary>
        /// Insere os objetos no array
        /// </summary>
        public void InsereObitos()
        {
            aObitos[0] = new Obitos("Norte", 23, "Feminino", "Covid-19");
            aObitos[1] = new Obitos("Norte", 55, "Masculino", "Causas Naturais");
            aObitos[2] = new Obitos("Centro", 44, "Feminino", "Covid-19");
        }
        
        public void ImprimeObitos()
        { 
                Console.WriteLine("Lista de obitos registados em Portugal Continental: ");
                for (int i = 0; i < aObitos.Length; i++)
                {
                    Console.WriteLine("Região: " + aObitos[i].Regiao + " Idade: " + aObitos[i].Idades + " Genero:" + aObitos[i].Genero);
                }            
        }

        /// <summary>
        /// Verifica as causas de morte e da o nº de casos para Covid-19
        /// </summary>
        /// <param name="aObitos"></param>
        public void VerificaCausa()
        {
            int nCausas = 0;
            bool aux = false;
            while (aux == false)
            {
                string pCausas = "Covid-19";


                for (int i = 0; i < aObitos.Length; i++)
                {
                    if (aObitos[i].CausaMorte == pCausas)
                    {
                        aux = true;
                        nCausas++;

                        //codigo
                    }
                }

                if (aux == true)
                {
                    Console.WriteLine("Nº de casos com obito de " + pCausas + " : " + nCausas);
                }

                if (aux == false)
                {
                    Console.WriteLine("Não existe registos para essa causa de morte!");

                }
            }
        }
        /// <summary>
        /// Faz a percentagem de obitos por genero.
        /// </summary>
        /// <param name="aCaso"></param>
        public void PercentObitosGenero()
        {

            float percentagemM;
            float percentagemF;

            int contaM = 0;
            int contaF = 0;
            string pMasculino = "Masculino";
            string pFeminino = "Feminino";
            for (int i = 0; i < aObitos.Length; i++)
            {
                if (aObitos[i].Genero == pMasculino)
                {
                    contaM++;
                }
                if (aObitos[i].Genero == pFeminino)
                {
                    contaF++;
                }

            }

            percentagemM = (float)contaM / aObitos.Length;
            percentagemF = (float)contaF / aObitos.Length;

            Console.WriteLine("Percentagem de casos por genero : ");
            Console.WriteLine("Masculino :" + percentagemM + "%");
            Console.WriteLine("Feminino :" + percentagemF + "%");
        }
        #endregion
    }
}
