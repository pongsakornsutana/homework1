using System;

namespace Week1
{
    class Program
    /////////นับสระ
    /*{ 
        static bool isVowel(char input) 
        {
            return input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u';
        }
        static void Main(string[] args)
        {
            int counter = 0;

            Console.Write("input name: ");
            string name = Console.ReadLine();
            string lowerString = name.ToLower();


            foreach (char value in lowerString.ToCharArray()) {
                if (isVowel(value)) {
                    counter++;
                }
            }
            Console.WriteLine(counter);
             
        }
    }*/

    /*{
        ////////แปลงหน่วย
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(100));
        }
        static int FeetToInches(int feet) {
            int inches = feet * 12;

            return inches;
        }
    }*/

    ///////////เปลี่ยนตัวอักษรให้เป็นตัวใหญ่
    /*{
        static void Main(string[] args)
        {
            string message = "Hello World";
            string upperMessage = message.ToUpper();

            Console.WriteLine(upperMessage);
        }
    }*/
    //////////อักษรมาต่อกัน
    /*{
        static void Main(string[] args) 
        {

           
            string word = "Hello World";
            int Num = 2021;
            word = word + Num.ToString();
            Console.WriteLine(word);
        }
    }*/

    /*{ 
    class UnitConverter {

        int ratio;
        public UnitConverter(int unitRatio) 
            {

            ratio = unitRatio;        
        }

        public int Convert(int unit) {
            return unit * ratio;
        }
    }
    
        static void Main(string[] args) {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milestoFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(milestoFeetConverter.Convert(1)));
        }


    }*/
    { 
    
    }
}
