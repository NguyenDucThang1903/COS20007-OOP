namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message myMessage= new Message("Hello, World! Greetings from Message Object.");

            myMessage.Print();

            Message[] messages= new Message[5];
            messages[0] = new Message("Hi Minh, how are you?");
            messages[1] = new Message("Hi An, how are you?");
            messages[2] = new Message("Hi Shinab, how are you?");
            messages[3] = new Message("Welcome Admin");
            messages[4] = new Message("Welcome, nice to meet you.");

            while(true)
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                if (name.ToLower() == "minh")
                {
                    messages[0].Print();
                }
                else if(name.ToLower() == "an")
                {
                    messages[1].Print();
                }
                else if(name.ToLower() == "shinab")
                {
                    messages[2].Print();
                }
                else if(name.ToLower() == "thang")
                {
                    messages[3].Print();
                }
                else if(name=="Exit")
                {
                    break;
                }
                else
                {
                    messages[4].Print();
                }
            }
        }
    }
}

