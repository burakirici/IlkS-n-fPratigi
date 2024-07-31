using IlkSınıfPratigi;

Person student1 = new Person();
student1.Name = "Burak";
student1.surname = "Kırıcı";
student1.birthday = DateTime.Now;

Person student2 = new Person();
student2.name = "EmreCan";
student2.surname = "Terkan";
student2.birthday = DateTime.Today;

Person teacher1 = new Person();
teacher1.name = "Burak";
teacher1.surname = "Kırmaz";
teacher1.birthday = DateTime.Today;

Person teacher2 = new Person();
teacher2.name = "CanEmre";
teacher2.surname = "Terken";
teacher2.birthday = DateTime.Today;


Console.WriteLine("Student informations: ");
student1.WriteInfo();
student2.WriteInfo();

Console.WriteLine("Teacher informations: ");
teacher2.WriteInfo();
teacher1.WriteInfo();