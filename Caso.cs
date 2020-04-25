// -------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
// Copyright IPCA-EST. All rights reserved.
// </copyright>
// <summary>
//	trabalhoLP2_18855_Fase1
// </summary>
// <desc>
// Define pessoas infetada
// </desc>
//<author>Diogo Rocha</author>

//-------------------------------------------------

using System;

namespace Dgs
{
    class Caso
    {
        #region Atributos
        string regiao;
        int idades;
        string genero;
        const int MAX = 3;
        Caso[] aCaso = new Caso[MAX];



        #endregion

        #region Construtor


        public Caso()
        {


        }


        /// <summary>
        /// Construtor com dados do exterior
        /// </summary>
        /// <param name="rRegiao"></param>
        /// <param name="iIdade"></param>
        /// <param name="gGenero"></param>
        public Caso(string rRegiao, int iIdade, string gGenero)
        {
            regiao = rRegiao;
            idades = iIdade;
            genero = gGenero;
            aCaso = new Caso[MAX];

        }
   
        #endregion

        #region Propriedades
            /// <summary>
            /// Manipula atributo "regiao"
            /// int regiao;
            /// </summary>
        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        /// <summary>
        /// Manipula atributo "idade"
        /// int idades;
        /// </summary>
        public int Idades
        {
            get { return idades; }
            set { if (value > 0 && value < 115) idades = value; }
        }

        /// <summary>
        /// Manipula atributo "genero"
        /// int genero;
        /// </summary>
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        /// <summary>
        /// Indexador de posição
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Caso this[int i]
        {
            get { return aCaso[i]; }
            set { aCaso[i] = value; }
        }

        #endregion

        #region Métodos


        /// <summary>
        /// Insere os objetos no array
        /// </summary>
        public void Insere()
        {
            ///*Objetos criados para classe Caso */
            aCaso[0] = new Caso("Sul", 25, "Masculino");
            aCaso[1] = new Caso("Centro", 20, "Feminino");
            aCaso[2] = new Caso("Sul", 25, "Masculino");

        }

        /// <summary>
        /// Imprime a lista de casos registado em Portugal Continental
        /// </summary>
        public void Lista()
        {
            Console.WriteLine("Lista de casos registados em Portugal Continental: ");
            for (int i = 0; i < aCaso.Length; i++)
            {
                Console.WriteLine("Região: " + aCaso[i].Regiao + " Idade: " + aCaso[i].Idades + " Genero:" + aCaso[i].Genero);
            }
        }
        /// <summary>
        ///Verifica os registos para regiao .
        ///Caso verdade apresenta o nº de casos na regiao centro.
        /// </summary>
        /// <param name="aCaso"></param>
        public void VerificaRegiao()
        {
            int nRegiao = 0;
            bool aux = false;
            while (aux == false)
            {

                string pRegiao = "Centro";
                for (int i = 0; i < aCaso.Length; i++)
                {
                    if (aCaso[i].Regiao == pRegiao)
                    {    
                        aux = true;
                        nRegiao++;

                    }
                }

                if(aux== true)
                {
                    Console.WriteLine("Nº de casos na região " + pRegiao + " : " + nRegiao);
                }

                if (aux == false)
                {
                    Console.WriteLine("Não existe dados para essa região!");

                }


            }
        }

        /// <summary>
        /// Verifica os registos para a idade de 25 anos.
        /// Caso verdade apresenta o nº de casos por idades
        /// </summary>
        /// <param name="aCaso"></param>
        public void VerificaIdade()
        {
            int nIdades = 0;
            bool aux = false;
            while (aux == false)
            {
                int pIdade = 25;

                //Verificar se  existe a idade e conta o nº de casos pela idade de consulta

                for (int i = 0; i < aCaso.Length; i++)
                {
                    if (aCaso[i].Idades == pIdade)
                    {
                        //Console.WriteLine("existe");
                        aux = true;
                        nIdades++;

                        //codigo


                    }
                    //else
                    //{
                    //    Console.WriteLine("Nao existe");
                    //}

                }
                if (aux == true)
                {
                    Console.WriteLine("Nº de casos com idade de " + pIdade + " : " + nIdades);
                }

                if (aux == false)
                {
                    Console.WriteLine("Não existe registos para essa idade!");

                }


            }
        }

        /// <summary>
        /// Verifica os registos para o genero Masculino.
        /// Caso verdade apresenta o nº de casos por genero
        /// </summary>
        /// <param name="aCaso"></param>
        public void VerificaGenero()
        {
            int nGenero = 0;
            bool aux = false;
            while (aux == false)
            {
                string pGenero = "Masculino";

                //Verificar se o genero existe e conta o nº de casos por genero

                for (int i = 0; i < aCaso.Length; i++)
                {
                    if (aCaso[i].Genero == pGenero)
                    {
                        //Console.WriteLine("existe");
                        aux = true;
                        nGenero++;

                        //codigo


                    }
                    //else
                    //{
                    //    Console.WriteLine("Nao existe");
                    //}

                }

                if(aux == true)
                {
                    Console.WriteLine("Nº de casos com genero " + pGenero + " : " + nGenero);
                }

                if (aux == false)
                {
                    Console.WriteLine("Não existe registos para esse genero!.");

                }


            }
        }

        /// <summary>
        /// Verifica o caso com maior idade.
        /// </summary>
        /// <param name="aCaso"></param>
        public void MaiorIdade()
        {
            int maior = 0;
            
                for (int i = 0; i < aCaso.Length; i++)
                {
                    if (maior < aCaso[i].idades)
                    {
                        maior = aCaso[i].Idades;
                    }
                }
            Console.WriteLine("O caso com maior idade é: " + maior);
                       
        }

        /// <summary>
        /// Faz a média de idade
        /// </summary>
        /// <param name="aCaso"></param>
        public void MediaIdades()
        {
            int soma = 0;
            int media = 0;

            for (int i = 0; i < aCaso.Length; i++)
            {
                soma += aCaso[i].Idades;
            }
            media = soma / aCaso.Length;

            Console.WriteLine("A idade média de casos é de : " + media);
        }

        /// <summary>
        /// Faz a percentagem de casos por genero.
        /// </summary>
        /// <param name="aCaso"></param>
        public void PercentagemGenero()
        {

            float percentagemM;
            float percentagemF;

            int contaM = 0;
            int contaF = 0;
            string pMasculino = "Masculino";
            string pFeminino = "Feminino";
            for (int i = 0; i < aCaso.Length; i++)
            {
                if(aCaso[i].Genero == pMasculino)
                {
                    contaM++;
                }
                if(aCaso[i].Genero == pFeminino)
                {
                    contaF++;
                }
         
            }

            percentagemM = (float)contaM  / aCaso.Length;
            percentagemF = (float)contaF / aCaso.Length;

            Console.WriteLine("Percentagem de obitos por genero : ");
            Console.WriteLine("Masculino :" + percentagemM + "%");
            Console.WriteLine("Feminino :" + percentagemF + "%");
        }
        #endregion

    }
}