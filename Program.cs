using System;



namespace ConsoleConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите выражение которое необходимо сравнить в формате\n 1 RUB > 2 EUR");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Money a = new Money(Convert.ToDecimal(words[0]), words[1]);
                Money b = new Money(Convert.ToDecimal(words[3]), words[4]);
                string operation = words[2];
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"{(a + b).finalValue} {a.m_currency}");
                        break;
                    case "-":
                        Console.WriteLine($"{(a - b).finalValue} {a.m_currency}");
                        break;
                    case "*":
                        Console.WriteLine($"{(a * b).finalValue} {a.m_currency}");
                        break;
                    case "/":
                        Console.WriteLine($"{(a / b).finalValue} {a.m_currency}");
                        break;
                    case ">":
                        Console.WriteLine($"{a > b}");
                        break;
                    case "<":
                        Console.WriteLine($"{a < b}");
                        break;
                    case "=":
                        Console.WriteLine($"{a == b}");
                        break;
                    case ">=":
                        Console.WriteLine($"{a >= b}");
                        break;
                    case "<=":
                        Console.WriteLine($"{a <= b}");
                        break;
                    default:
                        Console.WriteLine("Вам доступны операции: +-*/ и ><= >=<=");
                        break;

                }
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Выражение необходимо вводить по маске: 1 EUR + 5 USD");
                Console.ReadLine();
            }
            

        }
    }
   
   
}
