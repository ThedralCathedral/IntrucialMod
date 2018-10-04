using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items
{
	public class FallenStarIngot : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Fallen Star Bar");
            Tooltip.SetDefault("Made Purely from a fallen star.");
		}

		public override void SetDefaults()
		{
            item.width = 30;
            item.height = 24;
            item.maxStack = 99;
            item.value = 5;
        }

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
	}
}
