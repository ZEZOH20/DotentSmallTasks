    public static class PrimitiveSingleTypeConverter<T>
    {
        //Note: Work only on : string - int - float - double 
        // Can't work on Arrays or Enums

        static readonly string rootFolder = @"D:\ziad\.net_projects\DotentSmallTasks\DotnetAsync\src\InputFiles\";
        static readonly string textFile = rootFolder + @"BInterestingDrink.txt";
        public static void Main()
        {
            var Inp = Input();
            int counter = 0;

            foreach (var line in Inp)
            {
                foreach (T item in line)
                {
                    Console.WriteLine($"Line{counter}  , Item :{item.GetType()}");
                }

                counter++;
            }
        }

        static List<T[]> Input()
        {
            List<T[]> lines = new List<T[]>();
            if (File.Exists(textFile))
            {
                using (StreamReader file = new StreamReader(textFile))
                {

                    int counter = 0;
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        lines.Add(ChangeType(ln.Split(" ")));
                        counter++;
                    }
                    file.Close();
                }
            }
            return lines;
        }

        static T[] ChangeType(string[] obj)
        {
            T[] temp = new T[obj.Length];
            int counter = 0;
            foreach (string item in obj)
            {
                temp[counter] = (T)Convert.ChangeType(item, typeof(T));
                counter++;
            }
            return temp;
        }

    }
