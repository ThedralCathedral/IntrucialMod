using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Intrucial.Recipes;

namespace Intrucial.Items.Weapons
{
    public class TelainumRevolver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Telainum Revolver"
                + "\nChanges all bullets to Chlorophyte Bullets");
        }

        public override void SetDefaults()
        {
            item.damage = 110;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = 1000000;
            item.rare = 12;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 15f;
            item.useAmmo = AmmoID.Bullet;
            item.expert = true;
        }

        public override void AddRecipes()
        {
            IntrucialRecipe recipe = new IntrucialRecipe(mod, () => Main.LocalPlayer.GetModPlayer<IntrucialPlayer>().HiddenRecipesAvailable);
            recipe.AddIngredient(null, "TelainumBar", 20);
            recipe.AddIngredient(ItemID.Revolver);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 speed = new Vector2(speedX, speedY).SafeNormalize(Vector2.UnitX) * 15f;
            speedX = speed.X;
            speedY = speed.Y;
            type = mod.ProjectileType("BetterLuminiteBullets");
            return true;

        }

    }
}