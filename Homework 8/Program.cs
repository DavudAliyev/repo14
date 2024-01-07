using System;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "Skolad, Sud, Tort, Corek, Lavas" };          
            string opt;

            do
            {
                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Secilmis mehsula bax");
                Console.WriteLine("3. Yeni mehsul elave et");
                Console.WriteLine("4. Mehsulun adini deyis");
                Console.WriteLine("5. Secilmis mehsulu sil");
                Console.WriteLine("0. Cix");

                Console.WriteLine("Emeliyyati secin: ");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        ShowAllProducts(products);
                        break;
                    case "2":
                        Console.WriteLine("Indexi daxil edin: ");
                        string indexStr = Console.ReadLine();
                        try
                        {
                            int index = Convert.ToInt32(indexStr);
                            Console.WriteLine($"product: {products[index]}");
                        }
                        catch
                        {
                            Console.WriteLine("Xeta bas verdi!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Yeni mehsulun adi: ");
                        string productname=Console.ReadLine();
                        AddProduct(ref products, productname);
                        break;              
                    case "4":
                        bool hasProblem;
                        ShowAllProducts(products);
                        do
                        {
                            hasProblem = false;
                            try
                            {
                                EditProduct(products);
                            }
                            catch
                            {
                                Console.WriteLine("Xeta bas verdi!");
                                hasProblem = true;
                            }
                        }
                        while (hasProblem);
                        break;

                }

            }
            while (opt != "0");


        }

        static void ShowAllProducts(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        static void EditProduct(string[] products)
        {
            Console.WriteLine("Mehsulu secin: ");
            string indexStr=Console.ReadLine() ;
            int index= Convert.ToInt32(indexStr);

            Console.WriteLine("Adi duzelis edin: ");
            products[index] = Console.ReadLine();
        }
        static void AddProduct(ref string[] arr, string elem)
        {
            string[] newArr=new string[arr.Length+1];
            for (int i = 0;i < arr.Length;i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length-1] = elem;
            arr= newArr;
        }
    }
}