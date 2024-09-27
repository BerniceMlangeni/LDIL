namespace Assignment1
{
    //created MilkSong class
    public class MilkSong
    {
        //declared method Sing
        public void Sing(int Bottles)
        {
            //created a for loop to loop through the milk bottles until we reach the last bottle
            for (int i = Bottles; i > 0; i--)
            {
                if (i > 1)
                {
                    Console.WriteLine($"{i} bottles of milk on the wall, {i} bottles of milk.");
                    Console.WriteLine($"Take one down and pass it around.");
                }
                else
                {
                    Console.WriteLine("1 bottle of milk on the wall, 1 bottle of milk.");
                    Console.WriteLine("Take one down and pass it around.");
                }
                Console.WriteLine(); // adds a new line for spacing in between the song verses
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object- instance of MilkSong
            MilkSong milkSong = new MilkSong();
            //calling the method Sing so the bottles start from 99
            milkSong.Sing(99);  
        }
    }
}
