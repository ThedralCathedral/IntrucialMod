using Terraria.ModLoader;
using Intrucial;
using Terraria.ID;
using Terraria;
using Intrucial.Recipes;
using Terraria.Audio;

namespace Intrucial.Items
{


    public class ScrollOfEternalCrafting : ModItem
    {
        public override bool UseItem(Player player)
        {
            player.GetModPlayer<IntrucialPlayer>().HiddenRecipesAvailable = true;

            return true;
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = 1000000;
            item.rare = 12;
            item.expert = true;
            item.consumable = true;
            item.useStyle = 4;
            item.useTime = 60;
            item.useAnimation = 60;
            item.UseSound = new LegacySoundStyle(SoundID.Roar, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar);
            recipe.AddIngredient(ItemID.ChlorophyteBar);
            recipe.AddIngredient(ItemID.MeteoriteBar);
            recipe.AddIngredient(ItemID.PalladiumBar);
            recipe.AddIngredient(ItemID.ShroomiteBar);
            recipe.AddIngredient(ItemID.PirateMap);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}