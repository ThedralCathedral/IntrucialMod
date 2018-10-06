using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Intrucial.Recipes;

namespace Intrucial.Items.Weapons
{
    public class TelainumBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Telainum Bow");
            Tooltip.SetDefault("Extremely High Damage.");
        }

        public override void SetDefaults()
        {
            item.damage = 130;
            item.ranged = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7f;
            item.value = Item.sellPrice(10, 0, 0, 0);
            item.rare = 11;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = ProjectileID.MoonlordArrow;
            
        }

        public override void AddRecipes()
        {
            IntrucialRecipe recipe = new IntrucialRecipe(mod, () => Main.LocalPlayer.GetModPlayer<IntrucialPlayer>().HiddenRecipesAvailable);
            recipe.AddIngredient(null, "TelainumBar", 30);
            recipe.AddIngredient(null, "FallenStarBow", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
