
namespace StudentSystem
{
 abstract class Person
 {
    public string Name {get; }
    public int Age{get; }

    protected Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract string GetRole(); // не реализован, лишь обещатет реализовать
    public virtual void Introduce()
        {
            Console.WriteLine($"Меня зовут {Name}, мне знаете сколько лет, мне аж {Age}, а также я {GetRole()}");
        }
 }
}