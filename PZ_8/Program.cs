using System;

namespace PZ_8
{

    class Program
    {
        static void Main(string[] args)
        {
            var _student = ContactDataFactory.CreateContactData("Students") as Students;
            _student.Name = "Petrov Ivan";
            _student.PhoneNumber = "345863986534";
            _student.Email = "sdfsdf@gmail.com";

            var _spec = ContactDataFactory.CreateContactData("Specialization") as Specialization;
            _spec.Name = "Ivan Nekrovot";
            _spec.PhoneNumber = "6456456456546";
            _spec.Email = "gdfgdfg@mail.com";

            var _college = ContactDataFactory.CreateContactData("College") as College;
            _college.Name = "sharaga";
            _college.PhoneNumber = "323-675-124";
            _college.Address = "Chkalova, 11";

            var AllContacts = new List<IContact> { _student, _spec, _college };

            foreach (var contact in AllContacts)
            {
                Console.WriteLine("\nName: " + contact.Name);
                Console.WriteLine("Phone number: " + contact.PhoneNumber);
            }
        }
    }
}