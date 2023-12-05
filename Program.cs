// using LearningC_.models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Pedro";
// pessoa1.Idade = 21;
// pessoa1.Apresentar();

// pessoa1.
// int a =Convert.ToInt32("5");
// Console.WriteLine(a);

// calculadora
// using LearningC_.models;

// Calculadora calc = new Calculadora();

// calc.Somar(6,8);
// calc.Multiplicar(2,6);
// calc.Dividir(8,2);
// calc.Potencia(3,3);




int[] arrayInteiros = new int[4];
arrayInteiros[0] = 72;
arrayInteiros[1]=64;
arrayInteiros[2]=50;
arrayInteiros[3]=1;

for(int i=0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posicao{i}-{arrayInteiros[i]}");

}
// percorrendo array com FOREACH
foreach(int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}

