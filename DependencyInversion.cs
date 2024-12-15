using System;
					
    public class Program
    {
        public static void Main()
        {
            NonFlyingBird NonFlyingBird =
                new NonFlyingBird(new Bird());
			  flyingBird flyingBird =
                new flyingBird(new Bird());
        }


        public interface IBird
        {
            string? Name { get; set; }
            int? Speed { get; set; }
            void IsFly(IBird IBird);
            void StartFly();
        }


        public class Bird : IBird
        {
            public string? Name { get; set; }
            public int? Speed { get; set; }

            public void IsFly(IBird IBird)
            {
                Console.WriteLine($"{(IBird.Name == "flyingBird" ? IBird.Name : "NonFlyingBird")}");
            }

            public void StartFly()
            {
                Console.WriteLine("StartFly");
            }
        }

        public class NonFlyingBird : Bird
        {
            IBird _IBird;
            public NonFlyingBird(IBird IBird)
            {
                _IBird = IBird;
                _IBird.Name = "NonFlyingBird";
                _IBird.IsFly(IBird);
            }
        }

        public class flyingBird : Bird
        {
            IBird _IBird;
            public flyingBird(IBird IBird)
            {
                _IBird = IBird;
                _IBird.Name = "flyingBird";
                _IBird.IsFly(IBird);
            }
        }

    }
