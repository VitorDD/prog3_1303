using Arquivos.Views;


int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Veterinários");
    Console.WriteLine("4 - Clinica");

    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1 :
            Console.WriteLine("Opção Clientes");
            ClientView clientView = new ClientView();
        break;
        case 2 :
            Console.WriteLine("Opção Animais");
            AnimalView animalView = new AnimalView();
        break;
         case 3 :
            Console.WriteLine("Opção Veterinarios");
            VeteView veteView = new VeteView();
        break;
         case 4 :
            Console.WriteLine("Opção Clinica");
            ClinicView clinicView = new ClinicView();
        break;
    }

}while( option > 0 );


















