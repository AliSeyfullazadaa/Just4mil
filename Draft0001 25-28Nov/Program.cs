namespace Draft0001_25_28Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();

            Console.Write("Group Limit : ");
            group.Limit = int.Parse(Console.ReadLine());

            Console.WriteLine("1 - Add student.");
            Console.WriteLine("0 - Close.");
            string value = Console.ReadLine();

            while(value=="1")
            {
                
                Console.Write("Name daxil et : ");
                string name=Console.ReadLine();
                
                Console.Write("Surname daxil et : ");
                string surname=Console.ReadLine();

                Student student = new(name,surname);
                
                bool status = group.AddStudent(student);

                CheckStatus(status);
                Console.WriteLine("2 - Show arr.");
                Console.WriteLine("1 - Add student.");
                Console.WriteLine("0 - Close.");
                value = Console.ReadLine();
                if(value=="2")
                {
                    group.GetStudents();
                    Console.WriteLine("1 - Add student.");
                    Console.WriteLine("0 - Close.");
                    value = Console.ReadLine();
                }

                

            }

            static void CheckStatus(bool status)
            {
                if (status)
                    Console.WriteLine("Elave olundu.  (+) ");
                else
                    Console.WriteLine("Elave olunmadi.  (-)  ");
            }


        }
    }
}