using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize the array as 0
            int[] countArray = new int[256];
            String str = "from University of Nigeriannnn";
            char result = '\0';
            int maxValue = 0;
            //Console.WriteLine("The Character with Max Occurance is: " + str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                countArray[str[i]]++;

                if (countArray[str[i]] > maxValue)
                {
                    maxValue = countArray[str[i]];
                    result = str[i];
                }
            }

            Console.WriteLine("The Character with Max Occurance is: " + result);
            Console.ReadLine();

        }




        public static void Anagram()
        {
            //Anagram are words that have same constituent. Eg. POINTS = SPOINT, EDEM == DEEM
            string word1 = "EDEM";
            string word2 = "DEEM";

            char[] charWord1 = word1.ToCharArray();
            char[] charWord2 = word2.ToCharArray();

            Array.Sort(charWord1);
            Array.Sort(charWord2);

            string strWord1 = new string(charWord1);
            string strWord2 = new string(charWord2);

            bool res = strWord1.Equals(strWord2);
            if (res)
            {
                Console.WriteLine("The words are Anagram");
            }
            else
            {
                Console.WriteLine("The words are not Anagram");
            }
            Console.ReadLine();
        }


        public static void ReverseString()
        {
            string str = "I am god";
            str = str.Trim();
            int min = 0;
            int max = str.Length - 1;
            string result = "";

            for (int i = max; i >= 0; i--)
            {
                result += str[i];
            }

            Console.WriteLine("The new string is " + result);
            Console.ReadLine();
        }


        public static void CountWords()
        {
            string word = "My name is offiah. I am from Orumba South LGA ";
            word = word.Trim();
            int inc = 0;
            int cnt = 0;

            foreach (char cha in word)
            {
                if (cha == ' ')
                {
                    cnt++;
                }
                inc++;
            }
            cnt = cnt + 1;
            Console.WriteLine("The number of words is " + cnt);
            Console.ReadLine();
        }


        public static void CheckForPalindrome()
        {
            string word = "TENETa";
            string value = "";
            string result = "";
            int minInd = 0;
            int maxInd = word.Length - 1;

            while (true)
            {
                char a = word[minInd];
                char b = word[maxInd];
                if (minInd > maxInd)
                {
                    break;
                }
                if (a != b)
                {
                    result = "N";
                    break;
                }

                minInd++;
                maxInd--;
            }
            if (result == "N")
            {
                Console.WriteLine(word + " is not a Palindrome");
            }
            else
            {
                Console.WriteLine(word + " is a Palindrome");
            }
            Console.WriteLine(string.Join(" ", word));
            Console.ReadLine();
        }

        public static void RemoveDuplicate()
        {
            string duplicateLetter = "SAMSON";
            string value = "";
            string result = "";

            foreach (char letter in duplicateLetter)
            {
                if (value.IndexOf(letter) == -1)
                {
                    value += letter;
                    result += letter;
                }
            }

            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }



        public static void Fist_Word_UpperCase()
        {
            string name = "tochi offiah SanMUEL";
            name = name.ToLower();
            string splitedName = name.Replace(" ", ",");
            List<string> list = new List<string>();
            List<string> result = new List<string>();
            list = splitedName.Split(',').ToList();

            foreach (var str in list)
            {
                string newString = str.Substring(0, 1).ToUpper() + str.Substring(1);
                result.Add(newString);
            }
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }



        public static void OrderNumberDescending()
        {
            int[] arrayOfNumbers = { 1, 2, 2, 0, 4, 3 };
            List<string> res = new List<string>();
            int bigger;


            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[i] < arrayOfNumbers[j])
                    {
                        bigger = arrayOfNumbers[i];
                        arrayOfNumbers[i] = arrayOfNumbers[j];
                        arrayOfNumbers[j] = bigger;
                    }
                }
            }

            foreach (int item in arrayOfNumbers)
            {
                res.Add(item.ToString());
            }

            Console.WriteLine(string.Join(", ", res));
            Console.ReadLine();
        }


        public static void TurnFirstWordToUpper()
        {
            string name = "tochi offiah";
            string splitedName = name.Replace(" ", ",");
            List<string> list = new List<string>();
            List<string> result = new List<string>();
            list = splitedName.Split(',').ToList();
            
            foreach (var str in list)
            {
                string newString = str.Substring(0, 1).ToUpper() + str.Substring(1);
                result.Add(newString);
            }
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }

        public static void StringAssignAndPrint()
        {
            List<string> listOfStrings = new List<string>() { "Andrew", "Christian", "Solomon", "Loveth", "John", "Samuel" };
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                Console.WriteLine(listOfStrings[i]);
            }
            Console.ReadLine();
        }

        public static void ArrayReadAndPrint()
        {
            Console.WriteLine("Please Enter 4 Strings");

            string[] value = new string[4];
            int cnt = 0;
            for (int i = 0; i < value.Length; i++)
            {
                cnt = cnt + 1;
                value[i] = Console.ReadLine();
            }

            Console.WriteLine("The Strings are  " + string.Join(", ", value));
            Array.Reverse(value); //Array.Sort(value);
            int cnt_ = 0;
            for (int i = 0; i < value.Length; i++)
            {
                cnt_++;
                Console.WriteLine(cnt_ + ": " + value[i]);
            }
            Console.ReadLine();
        }

        public static void ArraysStuff()
        {
            string[] inputString_ = { "Andrew", "Christian", "Solomon", "Loveth", "John", "Samuel" };
            int cnt = 0;
            for (int i = 0; i < inputString_.Length; i++)
            {
                cnt = cnt + 1;
                Console.WriteLine(cnt + ": " + inputString_[i]);
            }

            string inputString = "OS IS ME";
            inputString = inputString.ToLower();
            int stringLength = inputString.Length;
            var letters = inputString.ToCharArray();
            //string positions = "";
            //string[] result = new string[stringLength];
            char[] chars = new char[inputString.Length];
            int[] charPos = new int[] { };
            var stringPos = new List<int>();
            int index = 0;
            foreach (var str in letters)
            {
                if (str == ' ')
                {
                    stringPos.Add((index + 1));
                }
                index = index + 1;
            }
            //Console.WriteLine("The Positions are: " + positions.Substring(1));
            Console.WriteLine("The charPos is: " + string.Join(", ", stringPos));

            string positions = string.Join(", ", stringPos);
            int location = 0;
            foreach (var pos in stringPos)
            {
                foreach (var item in inputString)
                {

                    if (location == pos)
                    {
                        char.ToUpper(item);
                    }
                    chars[location] = item;
                    location = location + 1;
                }
            }
            var res = new string(chars);
            Console.WriteLine("The Result is: " + res);
            //return sb.ToString();
            Console.ReadLine();
        }

        public static void TurnFirstLettersToUpperCase()
        {
            string s = "THIS IS MY TEXT RIGHT NOW";
            StringBuilder sb = new StringBuilder(s.Length);
            bool capitalize = true;
            foreach (char c in s)
            {
                sb.Append(capitalize ? Char.ToUpper(c) : Char.ToLower(c));
                capitalize = !Char.IsLetter(c);
            }
            //return sb.ToString();
            Console.WriteLine(string.Format("Result is: " + sb.ToString()));
            Console.ReadLine();
        }

        public static void TimeManipulation()
        {
            DateTime date = DateTime.Now;
            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = DateTime.Now;
            TimeSpan time = TimeSpan.Parse("03:00");
            TimeSpan time2 = TimeSpan.Parse(date.ToString("HH:mm"));

            long dateTimeTicks = DateTime.Now.Ticks;

            string dateTime = DateTime.Now.ToShortTimeString();
            int res = DateTime.Compare(dateTime1, dateTime2);

            Console.WriteLine(string.Format("The current dateTimeTicks is: " + dateTimeTicks));
            Console.WriteLine(string.Format("The current Datetime of dateTimeTicks is: " + new DateTime(dateTimeTicks)));
            Console.WriteLine(string.Format("The current time is: " + dateTime1));
            Console.WriteLine(string.Format("The 03:00 addedd to current time is: " + dateTime2.Add(time)));
            Console.WriteLine(string.Format("The 03:00 addedd to current step II is: " + date.Add(time2)));
            Console.WriteLine(string.Format("Compare Result is: " + res));

            Console.ReadLine();

        }

        public static void EqualPrincipaRepayment()
        {
        int n = 0;
        double r = 0.00;
        double rRaw = 0.00;
        double balRaw = 0.00;
        double Amount = 0.00;
        double AmtTotal = 0.00;
        double balance = 0.00;
        double intTotal = 0.00;
        double interest = 0.00;
        double principal = 0.00;

        rRaw = 25;          // Rate
            r = rRaw / 100;
            n = 12;             // Period in Month
            balRaw = 360000;
            balance = balRaw;
            principal = balance / n;

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("LOAN AMOUNT:  " + balance);
            Console.WriteLine("TOTAL PERIOD: " + n);
            Console.WriteLine("INTEREST RATE:" + rRaw);
            Console.WriteLine("------------------------- REPAYMENT SHEDULE ----------------------------");
            Console.WriteLine("REPAYMENT\t" + "AMOUNT" + "\t\tPRINCIPAL" + "\tINTEREST" + "\tBALANCE");
            Console.WriteLine("------------------------------------------------------------------------");

            for (int i = 1; i <= n; i++)
            {
                interest = balance* r;
        Amount = principal + interest;
                balance = balance - principal;
                Console.WriteLine(i + "\t\t" +  Amount + "\t\t" + principal + "\t\t" + interest + "\t\t" +  balance);

                intTotal = intTotal + interest;
                AmtTotal = AmtTotal + Amount;
            }

    Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("TOTAL" + "\t\t" + AmtTotal + "\t" + balRaw + "\t" + intTotal + "\t\t" +  balance);
            Console.WriteLine("--------------------------------------------------------------------------");

            Console.ReadLine();
        }

        private static void Others()
        {
            double num1 = 2.67;
            double num2 = 1.67;
            double num3 = 1.67;
            double num4 = 2.67;

            int num1Result = (int)Math.Round(num1, 2);
            int num2Result = (int)Math.Round(num2, 2);
            int num3Result = (int)Math.Floor(num3);
            int num4Result = (int)Math.Floor(num4);

            var cust = new Customer() { Id = 1, Name = "Tochi", Location = "Lagos" };
            string name = "SAMUEL OFFIAH";
            Console.WriteLine("The value of my name is: " + name.Substring(name.IndexOf(" ") + 1));
            Console.ReadLine();
        }
        public static string GenerateReference(string plan, string amt)
        {
            string refId;
            Random random = new Random();
            var today = DateTime.Now.ToString("yyMMddHHmm");
            if (string.IsNullOrEmpty(plan) || string.IsNullOrEmpty(amt))
            {
                return string.Empty;
            }

            amt = amt.Substring(0, 3);
            plan = plan.Substring(0, 3);
            string datePart = today.Substring(0, 6);
            string timePart = today.Substring(6, 4);
            int ranNum = random.Next(1000, 9999);

            refId = datePart + plan + amt + timePart + ranNum.ToString();

            return refId; // 210306 DIA 250 1049 8511
        }
        public static Dictionary<string, object> ObjectToDictionary(object obj)
        {
            Dictionary<string, object> ret = new Dictionary<string, object>();

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                string propName = prop.Name;
                var val = obj.GetType().GetProperty(propName).GetValue(obj, null);
                if (val != null)
                {
                    ret.Add(propName, val);
                }
                else
                {
                    ret.Add(propName, null);
                }
            }

            return ret;
        }
        static void OrderKeyHashValuesUsingDictionay()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("ACCRA", "GHANA CAPITAL");
            dictionary.Add("PORT", "NIGERIAN OIL CITY");
            dictionary.Add("ABUJA", "NIGERIAN CAPITAL");
            dictionary.Add("LAGOS", "NIGERIAN BUSINESS HUB");
            var keyList = dictionary.Keys.ToList();
            keyList.Sort();

            string values = null;
            foreach (var key in keyList)
            {
                values = values + dictionary[key] + ",";
            }
            int lastCommaPosition = values.LastIndexOf(",");
            values = values.Remove(lastCommaPosition);
            Console.WriteLine(values);


            //string plainText = "Technology crowds";
            string hashedData = ComputeStringToSha256Hash(values);
            Console.WriteLine(string.Format("The SHA256 hash of \r\n" + values + "\r\n" + hashedData));

            Console.ReadLine();
        }

        static string ComputeStringToSha256Hash(string plainText)
        {
            // Create a SHA256 hash from string   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computing Hash - returns here byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                // now convert byte array to a string   
                StringBuilder stringbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringbuilder.Append(bytes[i].ToString("x2"));
                }
                return stringbuilder.ToString();
            }
        }

        static void LINQPrintArrayOfNames()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA", "CHINA", "UK" };

            string result = countries.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine("Countries are: " + result);
            Console.ReadLine();
        }
        static void PrintArrayOfNames()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA", "CHINA", "UK" };

            string country = null;
            foreach (var item in countries)
            {
                country = country + item + ", ";
            }

            int lastIndexOfComma = country.LastIndexOf(",");
            country = country.Remove(lastIndexOfComma);
            Console.WriteLine("The location of comma after UK is: " + lastIndexOfComma);
            Console.WriteLine("Countries are: " + country);
            Console.ReadLine();
        }
        static void LINQPrintShortestNameInAList()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA" };

            int? size = countries.Min(x => x.Length);
            
            Console.WriteLine("The Length of the shortest name is: " + size);
        }

        static void PrintShortestNameInAList()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA"};

            int? size = null;

            foreach (var item in countries)
            {
                if (!size.HasValue || size > item.Length)
                {
                    size = item.Length;
                }
            }
            Console.WriteLine("The Length of the shortest name is: " + size);
        }

        static void LINQPrintOtherAgregrate()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = numbers.Sum();
            int cnt = numbers.Count();
            double avg = numbers.Average();
            double avgEven = numbers.Where(x => x % 2 == 0).Average();
            int sumEven = numbers.Where(x => x % 2 == 0).Sum();

            Console.WriteLine("Agregrate Values, Sum: " + sum + ", Count: " + cnt 
                + ", Sum Even: " + sumEven + ", Average: " + avg + ", avgEven " + avgEven);
        }

        static void LINQPrintEvenNumbers()
        {
            int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = numbers.Where(x => x % 2 == 0).Min();

            Console.WriteLine(result);
        }
        static void LINQPrintLeastEvenNumbers()
        {
            int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = numbers.Where(x => x % 2 == 0).Min();
            
            Console.WriteLine(result);
        }

        static void LINQPrintMinimumNumber()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = numbers.Min();

            Console.WriteLine(result);
        }

        static void PrintMinimumNumber()
        {
            int[] numbers = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int? result = null;

            foreach (int num in numbers)
            {

                if (!result.HasValue || num < result)
                {
                    result = num;
                }

            }
            Console.WriteLine(result);
        }
        static void PrintEvenNumbers()
        {
            int[] numbers_ = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }

    public class Children
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Children> Childrens { get; set; }
    }
}
