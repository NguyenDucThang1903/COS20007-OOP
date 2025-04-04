namespace Mid_sem_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] B = new int[4] { A[6], A[4], A[7], A[3] };

            FileSystem my_file_system = new FileSystem();

            
            for(int i=0; i < B[0]; i++)
            {
                if(i<10)
                {
                    my_file_system.Add(new File("104776473-0" + $"{i}", ".txt", 473));
                }
                else
                {
                    my_file_system.Add(new File("104776473-" + $"{i}", ".txt", 473));
                }
                
            }

            Folder my_folder_1 = new Folder("Folder have files part c");
            for(int i=0; i < B[1]; i++)
            {
                if (i < 10)
                {
                    my_folder_1.Add(new File("104776473-0" + $"{i}", ".txt", 473));
                }
                else
                {
                    my_folder_1.Add(new File("104776473-" + $"{i}", ".txt", 473));
                }
            }
            my_file_system.Add(my_folder_1);

            Folder my_folder_2 = new Folder("Folder have folder contains files");
            Folder my_folder_3 = new Folder("Folder have files part d");
            for (int i = 0; i < B[2]; i++)
            {
                if (i < 10)
                {
                    my_folder_3.Add(new File("104776473-0" + $"{i}", ".txt", 473));
                }
                else
                {
                    my_folder_3.Add(new File("104776473-" + $"{i}", ".txt", 473));
                }
            }
            my_folder_2.Add(my_folder_3);
            my_file_system.Add(my_folder_2);

            for (int i = 0; i < B[3]; i++)
            {
                my_file_system.Add(new Folder("Empty folder"));
            }

            my_file_system.PrintContents();
        }
    }
}
