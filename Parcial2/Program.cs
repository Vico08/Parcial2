public class Program
{
    private static void Main(string[] args)
    {
       Random random = new Random();
        int numAleatorio = 0;
        int numJugadores = 0;
        bool playAgain  = true;

        while (playAgain)
        {
            Console.Clear();
            Console.WriteLine("Bienvenidos al Juego Adivina el nùmero");
            Console.WriteLine("Ingrese el numero de jugadores (2-4):");
            
            do
            {
                numJugadores = int.Parse(Console.ReadLine());
                if (numJugadores < 2 || numJugadores > 4)
                {
                    Console.WriteLine("Número de jugadores inválido. Por favor, ingrese un número entre 2 y 4:");
                }
                while (numJugadores < 2 || numJugadores > 4);

            switch (numJugadores)
                {
                    case 2:
                        numAleatorio = random.Next(0, 51);
                        break;
                    case 3:
                        numAleatorio = random.Next(0, 101);
                        break;
                    case 4:
                        numAleatorio = random.Next(0, 201);
                        break;
                }

                