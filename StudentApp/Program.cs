
using StudentSystem;

namespace TaskDay2
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Student pasha = new Student("pasha", 14);

                Student vasya = new Student("vasya", 13);

                Teacher pedagog = new Teacher("Nikolai Petrovich", 55, "math");

                pasha.AddMark(5);
                pasha.AddMark(8);

                vasya.AddMark(2);

                var people = new List<Person>
                {
                    vasya, pasha, pedagog
                };

                foreach (Person person in people)
                {
                    person.Introduce();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int ReadNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Вы ввели некоректное число");
                Console.WriteLine("Попробуйте еще раз");
            }

            return number;
        }
    }
}