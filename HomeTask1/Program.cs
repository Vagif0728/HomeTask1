//--------------------------------Task 1(1)---------------------------

//Console.WriteLine("Dordreqemli ededi daxil edin:");

//int num = int.Parse(Console.ReadLine());

//if ((num / 1000 >= 1 || num / 1000 <= -1) && (num/1000<10 || num / 1000 >- 10)) 
//{
//    int cem = 0;
//    int qaliq = 0;


//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    qaliq = num / 10;
//    cem = qaliq + cem;

//    Console.WriteLine(cem);
//}
//else
//{
//    Console.WriteLine("Eded duzgun deyil.Zehmet olmasa 4 reqemli eded daxil edin");
//}

//-----------------------------------Task1(2)--------------------------------------

//Console.WriteLine("Dordreqemli ededi daxil edin:");

//int num = int.Parse(Console.ReadLine());

//if ((num / 1000 >= 1) && num / 1000 < 10)
//{
//    int cem = 0;
//    int qaliq = 0;


//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    qaliq = num / 10;
//    cem = qaliq + cem;

//    Console.WriteLine(cem);
//}
//else
//{
//    Console.WriteLine("Eded duzgun deyil.Zehmet olmasa 4 reqemli eded daxil edin");
//}


////--------------------------------------Task4------------------------------
Console.WriteLine("Yawinizi daxil edin :");
int age = int.Parse(Console.ReadLine());



if (age < 0)
{
    Console.WriteLine("Bele Yaw yoxdur. Zehmete olmasa yawinizi duzgun daxil edin...");
}
else if (age <= 12 || age >= 60)
{
    Console.WriteLine("Bilet 5 manat");
}
else if (age >= 13 || age <= 59)
{
    Console.WriteLine("Telebe kartiniz varmi Yes or No");
    string card = Console.ReadLine();

    if (card == "Yes")
    {
        Console.WriteLine("7.5 manat");
    }
    else if (card == "No")
    {
        Console.WriteLine("10 manat");
    }
    else
    {
        Console.WriteLine("Melumati duzgin daxil edin...");
    }

}

