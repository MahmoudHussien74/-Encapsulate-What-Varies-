namespace EncapsulateWhatVaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order("Chicken");

            Console.WriteLine(pizza);

            Console.ReadKey();
        }
        public class Pizza
        {


            public virtual string Title => $"{nameof(Pizza)}";
            public virtual decimal Ptice => 6m;

            private static Pizza Create(string type)
            {
                Pizza pizza;

                if (type == PizzaConstant.Cheese)
                {
                    pizza = new Cheese();
                }
                else if (type == PizzaConstant.Chicken)
                {
                    pizza = new Chicken();
                }
                else
                    pizza = new Vegeterian();

                return pizza;
            }

            public static Pizza Order(string type)
            {
                Pizza pizza = Create(type);
                Prepare();
                Cook();
                Cut();
                return pizza;
            }
            public static void Prepare()
            {
                Console.Write("Preparing.....Completed");
            }
            public static void Cook()
            {
                Console.WriteLine("Cooking.....Completed");
            }
            public static void Cut()
            {
                Console.WriteLine("Cutting and Boxing...Completed");
            }
            public override string ToString()
            {
                return $"\nTitle is {this.Title} \n Price equal :{this.Ptice}";
            }
        }

        public class Cheese : Pizza
        {
            public override string Title => base.Title + $" {nameof(Cheese)}";
            public override decimal Ptice => base.Ptice + 10m;
        }
        public class Chicken : Pizza
        {
            public override string Title => base.Title + $" {nameof(Chicken)}";
            public override decimal Ptice => base.Ptice + 10m;
        }
        public class Vegeterian : Pizza
        {
            public override string Title => base.Title + $" {nameof(Vegeterian)}";
            public override decimal Ptice => base.Ptice + 10m;
        }

    }
}
