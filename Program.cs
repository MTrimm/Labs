//Mathew Trimm
//mtrimm@stumail.northeaststate.edu



namespace Lab04



{
    internal class Program
    {
        static void Main(string[] args)
        {
            float velocity0 = 5.6f;
            float velocity1 = 10.5f;
            float time = 0.5f;

            float acceleration = (velocity1 - velocity0) / time;

            Console.WriteLine("acceleration: " + acceleration);




        }
    }
}