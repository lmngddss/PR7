using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class TeachingDiscipline : IComparable
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public int Hours { get; set; }

        public int CompareTo(object obj)
        {
            TeachingDiscipline other = obj as TeachingDiscipline;
            if (other == null) return 1;

            // Выбираю способ сравнения
            // Подумал и решил сравнивать по часам
            return this.Hours.CompareTo(other.Hours);
        }
    }

    public class Program
    {
        public static void Main()
        {
            TeachingDiscipline[] m = new TeachingDiscipline[5];
            m[0] = new TeachingDiscipline { Name = "Математика", TeacherName = "Василий Пупкин", Hours = 120 };
            m[1] = new TeachingDiscipline { Name = "Английский", TeacherName = "Мария Михайловна", Hours = 80 };
            m[2] = new TeachingDiscipline { Name = "История", TeacherName = "Давид Лиханов", Hours = 90 };
            m[3] = new TeachingDiscipline { Name = "Химия", TeacherName = "Екатерина Гусева", Hours = 100 };
            m[4] = new TeachingDiscipline { Name = "Физика", TeacherName = "Ярослав Вячеславович", Hours = 110 };

            Array.Sort(m);

            foreach (TeachingDiscipline td in m)
            {
                Console.WriteLine("{0}, Преподается учителем: {1}, {2} часов", td.Name, td.TeacherName, td.Hours);
                Console.ReadKey();
            }
        }
    }
}


