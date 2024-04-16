using Part1_Prog;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter recipe: ");
        string reci = Console.ReadLine();

        Console.WriteLine("Enter the number of ingredients:");
        int ingredientCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of steps:");
        int stepCount = int.Parse(Console.ReadLine());

        Recipe recipe = new Recipe(ingredientCount, stepCount);

        for (int i = 0; i < ingredientCount; i++)
        {
            Console.WriteLine($"Ingredient {i + 1} - Name:");
            string name = Console.ReadLine();

            Console.WriteLine($"Ingredient {i + 1} - Quantity:");
            double quantity = double.Parse(Console.ReadLine());

            Console.WriteLine($"Ingredient {i + 1} - Unit of Measurement:");
            string unit = Console.ReadLine();

            recipe.AddIngredient(new Ingredient(name, quantity, unit), i);
        }

        for (int i = 0; i < stepCount; i++)
        {
            Console.WriteLine($"Step {i + 1}:");
            string step = Console.ReadLine();
            recipe.AddStep(step, i);
        }

        Console.WriteLine("\nYour Recipe: " + reci);
        Console.WriteLine(recipe);

        while (true)
        {
            Console.WriteLine("Enter a scale factor (0.5, 2, 3) or 'exit' to quit:");
            string command = Console.ReadLine();

            if (command == "exit")
            {
                break;
            }
            else
            {
                double scaleFactor = double.Parse(command);
                recipe.ScaleRecipe(scaleFactor);

                Console.WriteLine("\nScaled Recipe:");
                Console.WriteLine(recipe.ToString());
            }
        }
    }
}