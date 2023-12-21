namespace ConsoleApp3.Models;

public class Pessoa
{
    public Pessoa(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Name}, e tenho {Age} anos.");
    }
}