using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LearningC_.models
{
    public class Pessoa
    {
        public string Nome { get; set; }  
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu {Nome} e tenho {Idade}anos");
        }
    }
}

