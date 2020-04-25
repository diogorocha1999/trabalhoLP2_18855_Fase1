// -------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
// Copyright IPCA-EST. All rights reserved.
// </copyright>
//<Date>24-04-2020</Date>
// <summary>
//	trabalhoLP2_18855_Fase1
// </summary>
// <desc>
// Os objetos são criados no main
// As funções são chamadas no main
// </desc>
//<author>Diogo Rocha</author>
//-------------------------------------------------
using System;

namespace Dgs
{
    class Program
    {

        static void Main(string[] args)
        {
            Caso c = new Caso();
            Obitos x = new Obitos();
            

            /* Chama as funções para o Main para testes*/
            c.Insere();
            c.Lista();
            c.VerificaRegiao();
            c.VerificaIdade();
            c.VerificaGenero();
            c.MaiorIdade();
            c.MediaIdades();
            c.PercentagemGenero();
            x.InsereObitos();
            x.ImprimeObitos();
            x.ImprimeObitos();
            x.VerificaCausa();
            x.PercentObitosGenero();

            Console.ReadKey();
        
        }
    }
}
