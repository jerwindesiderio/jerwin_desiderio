using System;
class HelloWorld {
  static void Main() {
    
           Console.WriteLine("Goverment Certificate Issuance System");
           
           string FullName = "Jerwin T Desiderio";
           string age = "20";
           string birthDate = "August 12 2000";
           string Address = "B23 L5 P1 Southville 5a Langkiwa binan Laguna";
           string EmailAddress="jerwindesiderio@gmail.com";
           string contact = "09224624264";
           
          
           
           
           Console.Write("Enter Fullname:");
           string firstNameInput = Console.ReadLine();
           
           
           if(firstNameInput == FullName)
           {
           	Console.WriteLine("Personal Information");
           	Console.WriteLine("EmailAddress: " + EmailAddress);
            Console.WriteLine("Age: " + age);
           	Console.WriteLine("birthDate: " + birthDate);
           	Console.WriteLine("Address" + Address);
           	Console.WriteLine("Contact No.: " + contact);
           	}else
           {
           	Console.WriteLine("Invalid Password.");
           }
        }     
    }
