using System;
namespace MembersAndFinalizersDestructors1
{
    class Members
    {
        // Member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // Member - public field
        public int age;

        // Member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }

        }

        // Member - public method - can be called from other clases
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // Member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";

            Console.WriteLine("Object created");
        }

        // Member - finalizer - destructor
        ~Members()
        {
            // Cleanup statements
            Console.WriteLine("Deconstruction of Members object");
        }
    }
}
