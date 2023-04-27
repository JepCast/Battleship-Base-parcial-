using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;


try
{
    int[,] tablero;

    void bienvenido_es()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"


                                                                                                
                                                                      ██                                    
                                              ██                    ████                                    
                                            ████                  ▓▓░░██                      ██            
                                            ████                  ██  ██                    ████            
                                          ██░░██                  ██░░██                    ████            
                                          ██░░██                ██░░░░██                  ██░░██            
                                          ██░░██                ██░░░░██                  ██░░██            
                                        ▓▓░░░░██                ██░░░░██                ▓▓░░░░██            
                                        ██░░░░██              ▓▓▒▒░░░░██                ██░░░░██            
                                        ██░░░░██              ██░░░░░░██              ▓▓░░░░░░██            
                                      ██░░░░░░██              ██░░░░░░██              ██░░░░░░██            
                                      ██░░░░░░██            ██░░░░░░░░██            ██░░░░░░░░██            
                                      ██░░░░░░██            ██░░░░░░░░██            ██░░░░░░░░██            
                                    ▓▓░░░░░░░░██            ██░░░░░░░░██          ▓▓░░░░░░░░░░██            
                                    ██░░░░░░░░██          ██▒▒░░░░░░░░██          ██░░░░░░░░░░██            
                                    ██░░░░░░░░██          ██░░░░░░░░░░██        ██░░░░░░░░░░░░██            
                                  ▓▓░░░░░░░░░░██          ██░░░░░░░░░░██        ██░░░░░░░░░░░░██            
                                  ██░░░░░░░░░░██        ██░░░░░░░░░░░░██      ██░░░░░░░░░░░░░░██            
                                ██░░░░░░░░░░░░██        ██░░░░░░░░░░░░██      ██░░░░░░░░░░░░░░██            
                                ██░░░░░░░░░░░░██        ██░░░░░░░░░░░░██    ██░░░░░░░░░░░░░░░░██            
                              ██░░░░░░░░░░░░░░██      ██░░░░░░░░░░░░░░██    ██░░░░░░░░░░░░░░░░██            
                              ██░░░░░░░░░░░░░░██      ██░░░░░░░░░░░░░░██  ██████████░░░░░░░░░░██            
                            ██░░░░░░░░░░░░░░░░██    ██  ░░░░░░░░░░░░░░██        ░░░░████████████            
                            ██░░░░░░░░░░░░░░░░██    ██░░░░░░░░░░░░░░░░██            ░░░░  ░░  ██            
                          ██████████░░░░░░░░░░██  ██████████░░░░░░░░░░██                ░░░░  ██            
                                ░░░░██████████▓▓        ░░░░████████████                    ░░██            
            ▓▓▓▓▓▓                  ░░░░      ▓▓            ░░░░      ██                    ████▓▓██▓▓▓▓▓▓▓▓
            ██▒▒▒▒██████                ░░░░  ▓▓                ░░░░  ██    ████████████████░░░░░░░░░░░░░░██
              ████▒▒▒▒▒▒████████            ░░██                    ░░██  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒██
                  ████▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒████████▓▓▒▒▒▒▒▒▒▒▒▒▓▓██▒▒▓▓████████░░░░░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░██
                      ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
                          ████░░░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░▓▓░░██
                              ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██
                                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██  
                                  ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  
                ░░░░░░░░        ░░░░░░░░▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░░░░░░░██  
            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            ░░░░░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░
            ░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░


                            ¡Bienvenid@ al emocionante juego en 2D de batallas de barcos, 
                                    inspirado en los clásicos juegos de mesa!
                    En este juego, tendrás la oportunidad de experimentar la emoción y la estrategia
                                   de una batalla naval en un formato digital.                             
               ¡Prepárate para una emocionante aventura de juego de mesa llevada a la pantalla digital!


                                       Inserta tu nick o nombre por favor:
        ");
        Console.ResetColor();
    }

    void barco()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(@"
                            
                                       
                                       
                                            
                                ███╗   ███╗███████╗███╗   ██╗██╗   ██╗
                                ████╗ ████║██╔════╝████╗  ██║██║   ██║
                                ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
                                ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║
                                ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
                                ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 
                                      

");
        Console.ResetColor();
    }

    void win()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
                                            
                                        ▓▓▓▓▓▓▓▓▓▓▓▓                
                                      ██▒▒▒▒▒▒▒▒▒▒▒▒██              
                                    ██▒▒▒▒░░░░░░░░░░░░██            
                                  ▓▓██▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓██▓▓          
                              ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████      
                            ██▒▒▒▒████████████████████████░░░░██    
                          ▓▓▒▒▒▒░░████▓▓▓▓░░██░░██▓▓▓▓▓▓██░░░░▒▒▓▓▓▓
                          ██▒▒░░▓▓██▓▓▓▓▒▒░░▒▒░░▒▒▓▓▓▓▓▓██░░░░░░████
                            ██░░██▓▓▓▓░░██░░░░░░██░░▓▓▓▓██░░░░██    
                              ██████▓▓░░░░░░░░░░░░░░▓▓░░██████      
                              ░░░░██▒▒░░░░▓▓▓▓▒▒░░░░▒▒░░██░░░░      
                                  ██░░░░░░▒▒▒▒▓▓░░░░░░░░██          
                                  ██▓▓░░░░░░░░░░░░░░░░▒▒██          
                                  ░░░░▓▓▓▓▓▓▓▓▒▒▓▓████              
                                    ██▓▓▓▓░░░░░░▓▓▓▓░░██            
                                  ██░░██▓▓░░░░░░▓▓▓▓██░░██          
                                  ██░░██▓▓░░░░░░▓▓▓▓██░░██          
                                  ██░░██▓▓░░░░░░▓▓▓▓██░░██          
                                    ▓▓██▓▓▒▒▒▒▒▒▓▓▓▓██▓▓            
                                    ░░██░░▓▓▒▒▒▒░░░░██              
                                      ██░░░░████░░░░██              
                                      ██▓▓▓▓░░░░▓▓▓▓██              
                   
                 ██████╗  █████╗ ███╗   ██╗ █████╗ ███████╗████████╗███████╗
                ██╔════╝ ██╔══██╗████╗  ██║██╔══██╗██╔════╝╚══██╔══╝██╔════╝
                ██║  ███╗███████║██╔██╗ ██║███████║███████╗   ██║   █████╗  
                ██║   ██║██╔══██║██║╚██╗██║██╔══██║╚════██║   ██║   ██╔══╝  
                ╚██████╔╝██║  ██║██║ ╚████║██║  ██║███████║   ██║   ███████╗
                 ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝
                                                            

                                                      
 
                                                   
                                            
");
        Console.ResetColor();
    }

    void exit()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(@"

                           ███████████                ████████████                          
                                  ████░░░░░░░░░░░░░░░░████                        
                    ██████████████░░░░░░░░░░░░░░░░░░░░░░░░████████████            
                    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██            
                    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██            
                      ██▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓██              
                      ██▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓██              
                        ██▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓██                
                          ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██                  
                          ██░░░░░░████░░░░░░░░░░░░░░████░░░░░░██                  
                          ██░░░░██  ▒▒██░░░░░░░░░░██  ▒▒██░░░░██                  
                          ██░░░░██▒▒▒▒██░░░░░░░░░░██▒▒▒▒██░░░░██                  
                            ██░░░░████░░░░░░░░░░░░░░████░░░░██                    
                            ██░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░██                    
                        ▓▓▓▓▓▓██░░░░▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░██                      
                      ▓▓▒▒▒▒▒▒▓▓██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██                        
                      ▓▓▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▓▓██                      
                        ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓██                    
                      ▓▓▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▓▓░░░░██        ██████    
                      ▓▓▒▒▒▒▒▒▓▓  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░██        ██▓▓▓▓██  
                        ▓▓▓▓▓▓    ██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░░░██        ██▓▓▓▓██
                                  ██░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░██        ██▓▓▓▓██
                                    ██░░░░░░░░░░░░░░██░░░░░░░░░░██        ██░░▓▓██
                                    ██░░░░░░██░░░░░░██░░░░░░░░░░██      ██░░░░░░██
                                    ██░░░░░░██░░░░░░██░░░░░░░░░░██      ██░░░░██  
                                    ██░░░░░░██░░░░░░██░░░░░░░░░░██    ██░░░░░░██  
                                      ██░░░░██░░░░██░░░░░░░░░░░░██████░░░░░░██    
                                      ██░░░░██░░░░██░░░░░░░░░░░░░░░░░░░░████      
                                      ██░░░░██░░░░██░░░░░░░░░░░░████████          
                                        ████  ██████████████████                  

             ██████╗ ██████╗  █████╗  ██████╗██╗ █████╗ ███████╗    ██████╗  ██████╗ ██████╗ 
            ██╔════╝ ██╔══██╗██╔══██╗██╔════╝██║██╔══██╗██╔════╝    ██╔══██╗██╔═══██╗██╔══██╗
            ██║  ███╗██████╔╝███████║██║     ██║███████║███████╗    ██████╔╝██║   ██║██████╔╝
            ██║   ██║██╔══██╗██╔══██║██║     ██║██╔══██║╚════██║    ██╔═══╝ ██║   ██║██╔══██╗
            ╚██████╔╝██║  ██║██║  ██║╚██████╗██║██║  ██║███████║    ██║     ╚██████╔╝██║  ██║
             ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝╚═╝  ╚═╝╚══════╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝
                                 ██╗██╗   ██╗ ██████╗  █████╗ ██████╗ 
                                 ██║██║   ██║██╔════╝ ██╔══██╗██╔══██╗
                                 ██║██║   ██║██║  ███╗███████║██████╔╝
                            ██   ██║██║   ██║██║   ██║██╔══██║██╔══██╗
                            ╚█████╔╝╚██████╔╝╚██████╔╝██║  ██║██║  ██║
                             ╚════╝  ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝                                                                                                                                                 
");
        Console.ResetColor();
    }


    int tam = 0;

    void long_table()
    {

        do
        {

            Console.WriteLine("\nInserta el tamaño que deseas para el tablero cada dato:");

        } while (!int.TryParse(Console.ReadLine(), out tam) || (tam <= 0));

        tablero = new int[tam, tam];

    }


    void paso1_c(int[,] tablero)
    {


        for (int f = 0; f < tablero.GetLength(0); f++)
        {
            for (int c = 0; c < tablero.GetLength(1); c++)
            {
                tablero[f, c] = 0;
            }
        }
    }

    int cantidad_barcos = 0;

    void paso2_colocar_barcos(int[,] tablero)
    {

        int total_celdas = tablero.GetLength(0) * tablero.GetLength(1);
        cantidad_barcos = total_celdas / 3;

        Random rnd = new Random();

        for (int f = 0; f < cantidad_barcos; f++)
        {
            int x = 0;
            int y = 0;

            do
            {
                x = rnd.Next(tablero.GetLength(0));
                y = rnd.Next(tablero.GetLength(1));
            } while (tablero[x, y] == 1);

            tablero[x, y] = 1;
        }
    }

    void paso3()
    {
        string caracterA = "";
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int c = 0; c < tablero.GetLength(1); c++)
            {
                switch (tablero[i, c])
                {
                    case 0:
                        caracterA = "-";
                        break;
                    case 1:
                        caracterA = "-";
                        break;
                    case -1:
                        caracterA = "*";
                        break;
                    case -2:
                        caracterA = "X";
                        break;
                    default:
                        caracterA = "-";
                        break;
                }
                Console.Write(caracterA + " ");
            }
            Console.WriteLine();
        }
    }



    void paso4()
    {
        int golpes = 0, fail = 0;
        uint fila, columna = 0;
        bool gano = false;

        Console.Clear();
        do
        {

            paso3();

            do
            {
                Console.Write("\nIngresa la fila: ");
            } while (!uint.TryParse(Console.ReadLine(), out fila) || (fila > tablero.GetLength(0) - 1));

            do
            {
                Console.Write("\nIngresa la columna: ");
            } while (!uint.TryParse(Console.ReadLine(), out columna) || (columna > tablero.GetLength(1) - 1));


            if (tablero[fila, columna] == 1)
            {
                Console.Clear();
                Console.Beep();
                tablero[fila, columna] = -1;
                paso3();
                Console.WriteLine("\nHas golpedo un barco!");
                golpes++;
                Console.WriteLine("Has golpeado a " + golpes + " barcos");
                cantidad_barcos -= 1;

            }
            else
            {
                Console.Clear();
                tablero[fila, columna] = -2;
                paso3();
                fail++;
                Console.WriteLine("Has fallado " + fail + " golpes");
            }

            if (cantidad_barcos == 0)
            {
                Console.Clear();
                win();
                gano = true;
            }
            CleanC();
        } while (!gano);
    }


    static void CleanC()
    {
        Console.ReadKey();
        Console.Clear();
    }


    void menu()
    {
        Console.Clear();
        bienvenido_es();
        string nick;
        Console.WriteLine("");
        nick = Console.ReadLine();
        Console.Clear();

        int op;
        do
        {
            barco();
            Console.WriteLine($"Hola " + nick + ", a continuación selecciona una opción insertando el numero correspondiente a la opción que deseas.");
            Console.WriteLine("\n1) Jugar");
            Console.WriteLine("2) Salir");
            Console.WriteLine();
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //Un switch para ir variando entre las diferentes opciones, del "1" al "3" y "4" para salir del programa y/o terminar el proceso.
            switch (op)
            {
                case 1:
                    long_table();
                    paso1_c(tablero);
                    paso2_colocar_barcos(tablero);
                    paso3();
                    paso4();
                    CleanC();
                    break;

                case 2:
                    exit();
                    CleanC();
                    break;

                default:
                    Console.WriteLine("\nEl dato insertado no es valido.");
                    break;
            }
        } while (op != 2);
    }

    menu();
} catch { Console.WriteLine("Haz insertado un dato incorrecto."); }