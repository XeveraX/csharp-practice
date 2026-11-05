

namespace StudentSystem
{
    class Student
    {
        public string Name { get; }

        public List<int> Marks { get; }

        public Student(string name)
        {
            Name = name;
            Marks = new List<int>();
        }

        public void AddMark(int number)
        {
            if (number < 0 || number > 10) throw new Exception("Оценка должна быть от 0 до 10");
            Marks.Add(number);
        }

        public double GetAverage() // вася смотри, что возращаещь
        {
            double sum = 0.0;
            for (int i = 0; i < Marks.Count; i++)
            {
                sum += Marks[i];
            }

            return sum / Marks.Count;
        }
        // локальные переменные с маленькой букввы бож
        public int GetMax()
        {
            if (Marks.Count == 0) throw new Exception("Cписок пуст");

            int maxMark = Marks[0];
            for (int i = 1; i < Marks.Count; i++)
            {
                if (Marks[i] > maxMark) maxMark = Marks[i];
            }

            return maxMark;
        }

    }
}
