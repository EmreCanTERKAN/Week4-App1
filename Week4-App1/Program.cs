using System;


namespace MyNamespace
{

	class Program
	{

		public static void Main(string[] args)
		{

			Person student1 = new Person()
			{
				Name = "Emre Can",
				LastName = "TERKAN",
				DogumYılı = "30.03.1995"
			};
            Console.WriteLine($"Ögrencinin Adı {student1.Name} Soyadı {student1.LastName} Yaşı {student1.DogumYılı}");
            Person student2 = new Person()
            {
                Name = "Burak",
                LastName = "Kırıcı",
                DogumYılı = "20.06.1995"
            };
            Console.WriteLine($"Ögrencinin Adı {student2.Name} Soyadı {student2.LastName} Yaşı {student2.DogumYılı}");
            Person teacher = new Person()
            {
                Name = "Sertan",
                LastName = "Bozkus",
                DogumYılı = "14.09.1992"
            };
            Console.WriteLine($"Öğretmenin Adı {teacher.Name} Soyadı {teacher.LastName} Yaşı {teacher.DogumYılı}");

        }



	}




}

class Person
{

    public string Name { get; set; }
    public string LastName { get; set; }
    public string DogumYılı { get; set; }

}
