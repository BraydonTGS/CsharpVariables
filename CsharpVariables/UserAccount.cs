using System;
namespace CsharpVariables
{
    public class UserAccount
    {
        private string firstName;
        private string lastName;
        private char middleI;
        private int userAge;
        private string email;

        public UserAccount(string fName, string lName, char mName, int age, string email)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.middleI = mName;
            this.userAge = age;
            this.email = email;
            Console.Write("Your Account Has Been Created");
            Console.ReadLine();

        }
    }
}