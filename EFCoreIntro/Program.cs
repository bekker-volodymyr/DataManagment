using EFCoreIntro.Entities;

namespace EFCoreIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Ініціалізація контексту
            AppDbContext db = new AppDbContext();

            // Створення об'єктів сутностей
            Student student = new Student() { FirstName = "Антон", LastName = "Степанюк", Age = 17 };

            // Додавання до БД
            db.Students.Add(student);

            // Збереження доданих записів
            db.SaveChanges();

            // Читання даних
            var students = db.Students.ToList();
            foreach (var s in students)
            {
                Console.WriteLine($"Ім'я: {s.LastName} {s.FirstName}\nВік: {s.Age}");
            }
        }
    }
}
