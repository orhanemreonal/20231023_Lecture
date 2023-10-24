

// Value Types

// 1_Int ( Integer ) (32bit): Sınırlar -+2.147.483.648 değer aralığı

// Min Değer = -2.147.483.649
// Max Değer = +2.147.483.647
// Örn:
// int number1 = 2147483647;
// Console.WriteLine("Number1 is {0} ", number1);
// Console.ReadLine();

// ------------------------------------------------------------ //

// 2_Long (64bit) : Sınırlar int'ten daha geniştir. Daha çok yer tutar

// Değer aralığı min: -9223372036854775808, max:+ 9223372036854775807

// ------------------------------------------------------------ //

// 3_Short (16bit) 

// Değer Aralığı min: -32768, max: +32767

// ------------------------------------------------------------ //

// 04_Byte (8bit)

// Değer Aralığı min:0 , max:255

// ------------------------------------------------------------ //

// 05_Bool ( Boolean ) 

// True ve False Alır. 

// ------------------------------------------------------------ //

// 06_Char ( Character ) 

// Klavyedeki tüm karakterleri tutmanı sağlar
// ASCCII (American Standard Code for Information Interchange)
// Klavyendeki Tüm Harflerin integer karşılığı vardır.
// Örn: A = 65

// ------------------------------------------------------------ //

// 07_Double

// Integer bir değer atayabiliyorsun. Ama ondalık sayıları da yazdırabiliriz/okuyabiliriz.

// ------------------------------------------------------------ //

// 08_Decimal

// Integer için long neyse double için decimal odur.
// Virgülden sonra 27-28 adet değer tutabilir
// Decimalde virgülden sonra ondalık sayılar tutamıyorsunuz onun yerine
// decimal number = 10.4m (sonuna m ekleyerek) işlem yapabiliriz

// ------------------------------------------------------------ //

// 09_Enum

// enum Days
// {
//    Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
// }

// if (Days.Friday) şeklinde yazabiliriz if ("Friday") şekilde yazmak yerine.

// MagicString ile uğraşmak zorunda kalmıyoruz.

// Console.WriteLine((int)Days.Friday);  ---> 4 değerini döner

// Monday=1,Tuesday=20 gibi başlangıç değerini değiştiririz ama o değerden sonra ardışık
// saymaya devam eder.

// ------------------------------------------------------------ //

// 10_Var 

// Değişken değildir ama değişken tutmak için kullanılır.

// var number7 = 10 (10 int oldugu için artık var'ın tipi int oldu. Bu işlemden sonra
// integer bir değer atasak bile mesela (number7 = 'A') yazdırsak 65 değerini verir.
// (number7 = "A") yazamayız cünkü başta integer olarak tanımladım string değer veremeyiz.

// ------------------------------------------------------------ //

