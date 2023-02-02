using System.Globalization;

namespace FuncionarioAumento;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Funcionario> lista = new List<Funcionario>();
        Console.Write("Quantos funcionarios vai registrar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Empregado {i + 1}: ");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            lista.Add(new Funcionario(id, nome, salario));
        }

        Console.Write("Digite o id do funcionario que vai receber aumento: ");
        int encontrarId = int.Parse(Console.ReadLine());
        Funcionario func = lista.Find(x => x._id == encontrarId);
        if(func != null)
        {
            Console.Write("Qual a porcentagem do aumento? ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.aumentoSalario(porc);
        }
        Console.WriteLine();
        Console.WriteLine("Lista de funcionarios atualizada: ");
        foreach(Funcionario itens in lista)
        {
            Console.WriteLine(itens);
        }
    }
}
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       












       /* List<Funcionario> lista = new List<Funcionario>(); //declaro a lista do tipo funcionario
        Console.Write("Quantos empregados deseja registrar? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) //percorro a lista para adicionar os elementos
        {
            Console.WriteLine($"Empregado {i + 1}");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            lista.Add(new Funcionario(id, nome, salario)); //adiciono os elemtnos na lista
        }

        Console.Write("Digite o id do funcionario que vai receber aumento: ");
        int encontrarId = int.Parse(Console.ReadLine());
        Funcionario func = lista.Find(x => x._id == encontrarId);//procura o id lido, pra ver se consta na lista
        if(func != null) //se o id que foi lido existir, chama o método que aumenta o salário
        {
            Console.Write("Digite a porcentagem: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.aumentoSalario(porc);
        }
        else 
        {
            Console.WriteLine("Funcionario inexistente");
        }
        Console.WriteLine("Atualização da lista dos funcionarios:");
        foreach(Funcionario itens in lista)
        {
            Console.WriteLine(itens);
        }
        */
