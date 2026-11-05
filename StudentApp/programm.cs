
using StudentSystem;

namespace TaskDay2
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Введети имя студента №1");
                string nameStudent = Console.ReadLine() ?? "Васек"; // если нихуя не ввел то можно написать такую защиту
                // + ЕСЛИ ТЫ ПРОПИСЫВЕШЬ В КОНЦЕ ТО ПРО ? после стринг можно забыть, бо а кому не пох
                Student student1 = new Student(nameStudent);

                Console.Write("Введети число оценок");
                int NumberOfMarks = ReadNumber();

                for (int i = 0; i < NumberOfMarks; i++)
                {
                    student1.AddMark(ReadNumber());
                }

                Console.Write("Среднее значение всех оценок ");
                Console.WriteLine(student1.GetAverage());

                Console.Write("Максимальное значение среди оценок ");
                Console.WriteLine(student1.GetMax());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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