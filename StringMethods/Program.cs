namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Apothicary Code";            
            String phoneNumber = "123-456-7890";
            String userName = fullName.Insert(0, "@");      // Adds an @ symbol at the beginning of fullName string to create username
            String firstName = fullName.Substring(0,10);    // Using Substring method use an index to separate a String and create a new String
            String lastName = fullName.Substring(11,4);

            fullName = fullName.ToUpper();                  // Converts fullName String to uppercase 
            fullName = fullName.ToLower();                  // Converts fullName String to lowercase 
            Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-","/");     // Replaces the - with a / in the phone number using Replace function
            Console.WriteLine(phoneNumber);
            Console.WriteLine(userName);
            Console.WriteLine(fullName.Length);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}
