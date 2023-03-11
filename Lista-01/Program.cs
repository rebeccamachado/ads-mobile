using System.Security.Cryptography.X509Certificates;
using Lista_01;

Console.WriteLine("Digite o número do exercício que deseja executar (1,2 ou 3): ");
int ex = Convert.ToInt16(Console.ReadLine());

switch (ex)
{
    case 1:
        //Console.WriteLine("vai implementar o 01");
        Ex Exercicio01 = new Ex();
        Ex.Executar01();
        break;
    case 2:
        Console.WriteLine("vai implementar o 02");
        Ex Exercicio02 = new Ex();
        Ex.Executar02();
        break;
    case 3: 
        Console.WriteLine("vai implementar o 03");
        Ex Exercicio03 = new Ex();
        Ex.Executar03();
        break;
    default: 
        Console.WriteLine("Não existe um exercício cadastrado com esse número, tente novamente.");
    break;
}

