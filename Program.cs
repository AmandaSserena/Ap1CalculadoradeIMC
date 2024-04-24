string nome;
int idade;
double altura, peso, imc;
string categoriaIMC, faixaEtaria;
string continuar;

do
{
    Console.WriteLine("Informe o seu nome:");
    nome = Console.ReadLine()!;

    Console.WriteLine("Informe a sua idade:");
    idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe a sua altura:");
    altura = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe o seu peso:");
    peso = double.Parse(Console.ReadLine()!);

    imc = peso / (altura * altura);

    if (imc < 18.5)
    {
        categoriaIMC = "Abaixo do Peso";
    }
    else if (imc < 24.9)
    {
        categoriaIMC = "Peso Normal";
    }
    else if (imc < 29.9)
    {
        categoriaIMC = "Sobrepeso";
    }
    else if (imc < 34.9)
    {
        categoriaIMC = "Obesidade Grau I";
    }
    else if (imc < 39.9)
    {
        categoriaIMC = "Obesidade Grau II";
    }
    else
    {
        categoriaIMC = "Obesidade Grau III";
    }

    if (idade < 20)
    {
        faixaEtaria = "Jovem";
    }
    else if (idade < 40)
    {
        faixaEtaria = "Adulto";
    }
    else if (idade < 60)
    {
        faixaEtaria = "Meia-Idade";
    }
    else
    {
        faixaEtaria = "Idoso";
    }

    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"IMC: {imc}");
    Console.WriteLine($"Categoria IMC: {categoriaIMC}");
    Console.WriteLine($"Faixa Etária: {faixaEtaria}");

    Console.WriteLine("Deseja continuar? (S/N)");
    continuar = Console.ReadLine()!;
} while (continuar.ToUpper() == "S");


