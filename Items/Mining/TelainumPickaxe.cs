using Terraria.ID;
using Terraria.ModLoader;
using Intrucial.Recipes;
using Terraria;

namespace Intrucial.Items.Mining
{
    public class TelainumPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Telainum Pickaxe, Strongest And Fastest there is...");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 1;
            item.useAnimation = 1;
            item.pick = 300;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 1000000;
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.expert = true;
        }

        public override void AddRecipes()
        {
            IntrucialRecipe recipe = new IntrucialRecipe(mod, () => Main.LocalPlayer.GetModPlayer<IntrucialPlayer>().HiddenRecipesAvailable);
            recipe.AddIngredient(null, "TelainumBar", 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}