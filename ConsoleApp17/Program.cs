using System;

namespace ConsoleApp17 {
    class Program {
        static void Main(string[] args) {
            var person = new Contacts.AddressBookTypes.Person("Bob", "Smith");

            // This line will not compile. Can not get this any visibility on the "FullName" member from C#
            //var s = person.FullName;

            Console.WriteLine("Hello World!");

        }
    }
}
