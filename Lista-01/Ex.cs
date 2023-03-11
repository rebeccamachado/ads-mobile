using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01
{
    internal class Ex
    {
        public static void Executar01()
        {
            int convNoivo = 600;
            int convNoiva = 300;
            int convPresentesNoivo = 400;
            int convPresentesNoiva = 300;

            if (convNoiva > convNoivo)
            {
                Console.WriteLine("O número de convidados da noiva é maior que do noivo.");
            }
            else if (convNoivo > convNoiva)
            {
                Console.WriteLine("O número de convidados da noiva é maior que do noivo.");
            }
            else
            {
                Console.WriteLine("O número de convidados da noiva é igual a do noivo.");
            }

            int convTotal = convNoiva + convNoivo;
            int presentes = convPresentesNoivo + convPresentesNoiva;

            if (presentes > convTotal)
            {
                Console.WriteLine("Existem penetras pois o número convidados presentes é maior que o número de convidados.");
            }
            else
            {
                Console.WriteLine("Não existem penetras no casamento.");
            }


        }

        public static void Executar02()
        {
            Console.WriteLine("\nExecutando a parte A...\n");

            string[] convidados = { "Julia", "Ana", "Bia", "José", "Pedro", "Athos", "Rebecca" };
            Console.WriteLine("Lista de Convidados armazenados em um array:\n");
            for (int i = 0; i < convidados.Length; i++)
            {
                Console.WriteLine(convidados[i]);
            }


            Console.WriteLine("\nExecutando a parte B...\n");

            List<string> convidadosList = new List<string>();
            convidadosList.Add("Julia");
            convidadosList.Add("José");
            convidadosList.Add("Pedro");
            convidadosList.Add("Rebecca");
            convidadosList.Add("Athos");
            convidadosList.Add("Ana");

            Console.WriteLine("Lista de Convidados armazenados em uma Lista:\n");
            for (int j = 0; j < convidadosList.Count; j++)
            {
                Console.WriteLine(convidadosList[j]);
            }
        }

        public static void Executar03()
        {
            string entrada = "banana, laranja, uva, Banana, Abacaxi, Laranja, uva, maçã";
            
            List<string> frutasMin = new List<string>(entrada.ToLower().Split(", "));
            
            HashSet<string> frutasUnicas = new HashSet<string>(frutasMin, StringComparer.OrdinalIgnoreCase);
            
            List<string> frutas = new List<string>();
            foreach (string fruta in frutasUnicas)
            {
                string primeiraLetraMaiuscula = fruta.Substring(0, 1).ToUpper() + fruta.Substring(1);
                frutas.Add(primeiraLetraMaiuscula);
            }
            // Imprimir as frutas
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}
