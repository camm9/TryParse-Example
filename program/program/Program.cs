
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            enterName();
        }

        public static void enterName()
        {
            string name;
            do
            {

                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                if (name.ToLower().Equals("exit"))
                {
                    return;
                }

                if (name.ToLower() == "jaspreet kaur sahiwal")
                {
                    Console.WriteLine(name + " - Instructor");
                }
                
                else
                {
                    Console.WriteLine(name + " - Student");
                }

                if (name.ToLower() != "jaspreet kaur sahiwal")
                {

                    Console.WriteLine("Enter your age: ");
                    string inputAge = Console.ReadLine();
                    bool isValidAge = int.TryParse(inputAge, out int age);
                    if (!isValidAge)
                    {
                        return;
                    }



                    if (age < 21)
                    {
                        int years = 21 - age;
                        Console.WriteLine("You must wait " + years + " years to enroll in this course");
                    }
                    else
                    {
                        Console.WriteLine("You are enrolled.");
                    }
                }
            } while (name != "exit");




        }

    }
}

