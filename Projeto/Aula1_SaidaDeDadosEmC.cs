// Print - Line com quebra de linha
/*
using System;
namespace primeiro {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Olá, mundo!");
        }
    }
}
*/
// Utilizando variável e limitando a QTD de caracteres no Double

// Importando namespaces para lidar com entrada/saída, manipulação de strings e informações culturais.
using System;
using System.Globalization;

// Aqui é declarado um namespace chamado "Curso".
// Namespaces são usados para organizar o código em conjuntos lógicos, evitando conflitos de nomes entre diferentes partes do código
namespace Curso
{
    // Classe principal onde o código do programa é escrito.
    class Program
    {
        // Ponto de entrada do programa.
        // static: Método pertence à classe e não precisa ser instanciado.
        // void: Não retorna nenhum valor.
        // string[] args: Argumentos passados para o programa da linha de comando.

        static void Main(string[] args)
        {
            // Variável double.
            double x = 10.35784;
            int y = 23;
            string z = "Tainara";
            char w = 'F';

            // Mostra o valor de x no console.
            Console.WriteLine(x);

            // Formata x como um número de ponto flutuante com duas casas decimais.
            Console.WriteLine(x.ToString("F2"));
            // Formata x como um número de ponto flutuante com quatro casas decimais.
            Console.WriteLine(x.ToString("F4"));

            // Formata x com duas casas decimais usando ponto como separador decimal.
            // Para usálo tem que importar a biblioteca: System.Globalization 
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            // Concatenação
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("Traga somente 2 décimos e o separe por ponto: " + x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do troco é: " + x + "Reais. Ops, " + x.ToString("F2", CultureInfo.InvariantCulture) + "Reais");

            // Demais Variáveis
            Console.WriteLine("Meu nome é: " + z + ", minha idade é: " + y + ", meu gênero é: " + w + ". Tenho: " + x + " Reais.");

            // Aguarda a entrada do usuário antes de encerrar.
            Console.ReadLine();
        }
    }
}

