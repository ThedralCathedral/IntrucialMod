using System;
using Terraria.ModLoader;

namespace Intrucial.Recipes
{

    public class IntrucialRecipe : ModRecipe
    {
        private readonly Func<bool> available;

        public IntrucialRecipe(Mod mod, Func<bool> available = null) : base(mod)
        {
            this.available = available;
        }

        public override bool RecipeAvailable()
        {
            return available == null ? true : available();
        }

    }
}