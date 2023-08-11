using System;

namespace MaiorMenor {

    class Program {

        static void Main(string[] args) {
            
            Console.WriteLine("-- WELLCOME TO BIGGER/SMALLER TESTER --");
            
            Menu();
            

        }

        static void Menu(){
            
            Console.Clear();
            Console.WriteLine("---- Menu ---");
            Console.WriteLine("1 - Inserir Valores");
            Console.WriteLine("0 - Sair");

            short select = short.Parse(Console.ReadLine());

            switch(select){

                case 1: PreEnterValue(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        static void PreEnterValue(){
            Console.Clear();
            int val1 = EnterValue("First");
            int val2 = EnterValue("Second");
            int val3 = EnterValue("Third");

            BiggerSmaller(val1, val2, val3);

        }

        static int EnterValue(string word){

            Console.WriteLine($"Enter the {word} value: ");
            int value = int.Parse(Console.ReadLine());

            return value;

        }

        static void BiggerSmaller(int value1, int value2, int value3) {
            Console.Clear();
            if(value1 > value2 && value1 > value3) {
                Console.WriteLine($"O maior entre {value1}, {value2} e {value3} é {value1}");
            } else if(value2 > value1 && value2 > value3){
                Console.WriteLine($"O maior entre {value1}, {value2} e {value3} é {value2}");
            } else {
                Console.WriteLine($"O maior entre {value1}, {value2} e {value3} é {value3}");
            }

            if(value1 < value2 && value1 < value3) {
                Console.WriteLine($"O menor entre {value1}, {value2} e {value3} é {value1}");
            } else if(value2 < value1 && value2 < value3){
                Console.WriteLine($"O menor entre {value1}, {value2} e {value3} é {value2}");
            } else {
                Console.WriteLine($"O menor entre {value1}, {value2} e {value3} é {value3}");
            }

            Console.ReadKey();
            
            Menu();

        }



    }



}
