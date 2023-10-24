using System.Diagnostics.Metrics;

// Başlangıç Ve Bitiş Değeri Belli Olmayan Değer Aralığındaki Asal Sayıları Bulma

//Console.WriteLine("Başlangıç Değeri : ");
//int startNumber = int.Parse(Console.ReadLine());
//Console.WriteLine("Bitiş Değeri : ");
//int endNumber = Convert.ToInt32(Console.ReadLine());

//for (int i = startNumber; i <= endNumber; i++)
//{
//    int sayac = 0;
//    for (int j = 2; j <= i / 2; j++)    // Bir sayının kendisinin yarısından büyük böleni yoktur bu yüzden yapılacak işlem yükünü baya azaltmış oluruz.
//    {
//        if (i % j == 0)
//        {
//            sayac++;
//            break;
//        }
//    }

//    if (sayac == 0 && i != 1)
//    {
//        Console.Write(i + " ");
//    }


//}

//Console.ReadKey();


// Alternatif Yol

//int j;

//for (int i = 2; i <= 100; i++)
//{
//    j = 2;
//    while ( j < i)
//    {
//        if (i % j == 0)
//        {
//            break;
//        }
//        j++;
//    }
//    if(j == i)
//    {
//        Console.Write(i + " ");
//    }
//}

//Console.ReadKey();

