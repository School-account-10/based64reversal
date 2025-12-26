
using System.Text;
using static OpenCvSharp.ML.DTrees;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {


        class base64conv
        {


            public string runner()
            {
                Console.Write("give me anything to turn to base64: ");
                String userin = Console.ReadLine();
                string userinlower = userin.ToLower();
                String based64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(userinlower));
                    Console.WriteLine(" ");
                Console.WriteLine("non reversed: " + based64 + " ");
                return based64;
            }



        }

        class reversebase64

        {
            public string runner2()
            {
                base64conv conv = new base64conv();
                String encd = conv.runner();

                StringBuilder STB = new StringBuilder();

                // weird bullshit to reverse the base64 string by chunks but does not work properly
                string chunk = encd;


                for (int i = chunk.Length - 1; i > -1; i--)
                {

                    STB.Append(chunk[i]);
                    STB.Append("");
                }
                string all = STB.ToString();
                Console.WriteLine("reversed: " + STB);
                return all;
            }

        }

        class unreverse
        {
            public string runner3()
            {
                reversebase64 rev = new reversebase64();

                String unrevs = rev.runner2();

                
                StringBuilder STB2 = new StringBuilder();
                string chunk2 = unrevs;

                for (int i = chunk2.Length - 1; i > -1; i--)
                {
                    STB2.Append(unrevs[i]);
                    STB2.Append("");
                }
                
                string all2 = STB2.ToString();
                Console.WriteLine("unreversed: " + STB2);
                return all2;


            }




        }





        static void Main(string[] args)
        {


            unreverse unrev = new unreverse();
            unrev.runner3();



        }
    }

}


