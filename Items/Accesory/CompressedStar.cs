using Terraria;
using Terraria.ModLoader;

namespace Intrucial.Items.Accesory
{
    public class CompressedStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very Dense, a lot of mana capacity."
                + "\n+100 Mana, increased Mana Regen and Magic Damage.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 1000000;
            item.rare = 7;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magicDamage += 3f;
            player.manaRegen++;
            player.statManaMax2 += 100;


        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(109, 60);
            recipe.AddTile(null, "ManaInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}