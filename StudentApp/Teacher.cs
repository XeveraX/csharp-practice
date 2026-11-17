
namespace StudentSystem
{
    class Teacher : Person
    {
        public string Subject { get; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"Я веду предмет {Subject}");
        }
        public override string GetRole() => "teacher";
    }
}