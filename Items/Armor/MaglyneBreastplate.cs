using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class MaglyneBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Maglyne Breastplate");
            Tooltip.SetDefault("Natural Green all the way boys and girls"
                + "\nImmunity to 'Poison'"
                + "\n+50 max mana and +1 max minions");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 1000000;
            item.rare = 6;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Poisoned] = true;
            player.statManaMax2 += 50;
            player.maxMinions++;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglyneBar", 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}