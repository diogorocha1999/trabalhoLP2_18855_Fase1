using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dgs
{
    class Program
    {
    
        static void Main(string[] args)
        {
            const int MAX = 3;
            Caso[] aCaso = new Caso[MAX];

            aCaso[0] = new Caso("Braga", 25, "Masculino");
            aCaso[1] = new Caso("Porto", 20, "Feminino");
            aCaso[2] = new Caso("Braga", 23, "Masculino");

            //for (int i = 0; i < MAX; i++)
            //{
            //    aCaso[i] = new Caso();
            //    Console.WriteLine("Regiao: ");
            //    Console.WriteLine("------------------------------------");
            //    aCaso[i].Regiao = Console.ReadLine();
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine("Idade: ");
            //    Console.WriteLine("------------------------------------");
            //    aCaso[i].Idades = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("------------------------------------");
            //}

            Console.WriteLine("Lista de casos em Portugal Continental: ");
            for (int i = 0; i < aCaso.Length; i++)
            {
                Console.WriteLine("Região: " + aCaso[i].Regiao + " Idade: " + aCaso[i].Idades + " Sexo: " + aCaso[i].Genero);
            }
            Console.WriteLine("Nº de casos em Portugal: " + aCaso.Length);

            #region Consulta por região
            Console.WriteLine("Insira a região para consultar!");
            string pRegiao = Console.ReadLine();
            int conta = 0;
            bool aux = true;
            for (int i = 0; i < aCaso.Length; i++)
            {
                if(pRegiao == aCaso[i].Regiao)
                {
                    aux = true;
                    Console.WriteLine("Regiao: " + aCaso[i].Regiao + " Idade : " + aCaso[i].Idades);
                    conta++;
                }
            }
            
            int auxI = 0;
            if (aux == true)
            {
                Console.WriteLine("Regiao: " + aCaso[auxI].Regiao + " Idade : " + aCaso[auxI].Idades);
                Console.WriteLine("Nº:" + conta);

            }
            else
            {
                Console.WriteLine("Região não encontrada!");
            }
            #endregion

            #region Consulta por Idade
            Console.WriteLine("Insira a idade para consultar!");
            int pIdades = Convert.ToInt32(Console.ReadLine());

            bool auxIdades = false;
            for (int i = 0; i < aCaso.Length; i++)
            {
                if (pIdades == aCaso[i].Idades)
                {
                    auxIdades = true;
    
                    //Console.WriteLine("Regiao: " + aCaso[i].Regiao + " Idade : " + aCaso[i].Idades);
                }
            }

            
            if (auxIdades == true)
            {
                Console.WriteLine(" Idade : " + aCaso[auxI].Idades + "Regiao: " + aCaso[auxI].Regiao);
                Console.WriteLine("Nº: " + conta);
            }
            else
            {
                Console.WriteLine("Idade não encontrada!");
            }
            #endregion

            #region Consulta por genero
            Console.WriteLine("Insira o genero a consultar:");
            string pGenero = Console.ReadLine();

            bool auxGenero = false;
            for (int i = 0; i < aCaso.Length; i++)
            {
                if (pGenero == aCaso[i].Genero)
                {
                    auxGenero = true;
                    break;
                    //Console.WriteLine("Regiao: " + aCaso[i].Regiao + " Idade : " + aCaso[i].Idades);
                }
            }


            if (auxGenero == true)
            {
                Console.WriteLine("Regiao: " + aCaso[auxI].Regiao + " Idade : " + aCaso[auxI].Idades);

            }
            else
            {
                Console.WriteLine("Idade não encontrada!");
            }
            #endregion


            Console.ReadKey();

            
            
        }
    }
}
