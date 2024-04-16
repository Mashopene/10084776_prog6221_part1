using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Prog
{
    class Recipe
    {
        private Ingredient[] ingredients;
        private string[] steps;
        private double[] originalQuantities;

        public Recipe(int ingredientCount, int stepCount)
        {
            ingredients = new Ingredient[ingredientCount];
            steps = new string[stepCount];
        }

        public void AddIngredient(Ingredient ingredient, int index)
        {
            ingredients[index] = ingredient;
        }

        public void AddStep(string step, int index)
        {
            steps[index] = step;
        }

        public void ScaleRecipe(double scaleFactor)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.ScaleQuantity(scaleFactor);
            }
        }

        public void ResetQuantities()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i].ResetQuantity(originalQuantities[i]);
            }
        }

        public override string ToString()
        {
            string recipeString = "Ingredients:\n";
            foreach (Ingredient ingredient in ingredients)
            {
                recipeString += $"{ingredient}\n";
            }
            recipeString += "\nSteps:\n";
            for (int i = 0; i < steps.Length; i++)
            {
                recipeString += $"{i + 1}. {steps[i]}\n";
            }
            return recipeString;
        }
    }
}
