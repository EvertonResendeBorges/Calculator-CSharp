double n1, n2;
int option;

try{

    do{ 

        Console.Clear();

        Console.WriteLine("------------");
        Console.WriteLine("Calculations");
        Console.WriteLine("------------");
        Console.WriteLine();

        Console.WriteLine("Choose an option:");
        Console.WriteLine("0- Exit");
        Console.WriteLine("1- Add");
        Console.WriteLine("2- Subtract");
        Console.WriteLine("3- Multiply");
        Console.WriteLine("4- Divide");

        Console.WriteLine();

        option = int.Parse(Console.ReadLine());

         switch(option){

            case 0: 

            break;

            case 1:
                Console.WriteLine("Add");

                Console.WriteLine("Enter a first value");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a second value");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine(n1+" + "+n2+" = "+(n1 + n2));

                Console.WriteLine();
                
            break;

            case 2:
                Console.WriteLine("Subtract");

                Console.WriteLine("Enter a first value");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a second value");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine(n1+" - "+n2+" = "+(n1 - n2));

                Console.WriteLine();
                
            break;

            case 3:
                Console.WriteLine("Multiply");

                Console.WriteLine("Enter a first value");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a second value");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine(n1+" x "+n2+" = "+(n1 * n2));

                Console.WriteLine();
                
            break;

            case 4:
                Console.WriteLine("Divide");

                Console.WriteLine("Enter a first value");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a second value");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine(n1+" / "+n2+" = "+(n1 / n2));

                Console.WriteLine();
                
            break;

            default:
                Console.WriteLine("Invalid option");
            break;

        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);

    } while(option != 0);

} catch(Exception e){

    Console.WriteLine("Error: Invalid values.");

} finally {

    Console.WriteLine("Closed Program");

}