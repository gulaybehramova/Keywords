using System;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.
            //Console.WriteLine("Metn daxil edin: ");
            //string metn = Console.ReadLine();
            //Text(metn);
            ////3.
            //int[] digit = new int[] { 23, 48, 55, 82 };
            //Console.WriteLine("Value daxil edin: ");
            //int element = Convert.ToInt32(Console.ReadLine());
            //Sirala(digit, element);
            ////4.
            //Console.WriteLine("Sozler daxil edin: ");
            //string text = Console.ReadLine();
            //Soz(text);


            ////1.Verilmis string variable-in deyerini icerisinde her soz arasinda bir bosluq gelecek vezyete salan metod.
            ////Misalcun bu metoda deyeri " salam,      Dunya" olan string variable gondersek hemin metod
            ////bu variable -in deyerini deyisidib "salam, Dunya" vezyetine salmalidir.
            ////Yəni göndırilən string-de sözlər arasında birdən çox boşluq ola bilər,
            ////onu hər söz arasında bir boşluq olan vezyete salan metod yazırsınız.Metod geriyə dəyər qaytarmır!

            //static void Text(string input)
            //{
            //    var collection = input.Trim().Split(' ');
            //    foreach (var yazi in collection)
            //    {
            //        if (yazi == "")
            //        {
            //            continue;
            //        }
            //        Console.Write($"{yazi}");
            //    }
            //}



            ////2.Gonderilmis string deyerinin asagidaki sertleri odeyib odemediyini qaytaran metod
            ////ALINMADI(((


            //3.Parameter olaraq integer array variable-i(reference) ve bir integer value
            //    qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.

            //static void Sirala(int[] IntArr, int element)
            //{
            //    Array.Resize(ref IntArr, IntArr.Length + 1);
            //    IntArr[IntArr.Length - 1] = element;
            //    foreach (var item in IntArr)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}



            //4.Gonderilmis string deyerinideki sözlərdən ibaret array qaytaran metod
            //static string[] Soz(string sozler)
            //{
            //    string[] SozSayTap = sozler.Trim().Split(' ');
            //    foreach (var item in SozSayTap)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    return SozSayTap;
            //}


            ////5.Göndərilmiş string dəyərindəki son sözlərdən ibarrət array qaytaran metod
            ////ALINMADI(((


        }
    }
}
