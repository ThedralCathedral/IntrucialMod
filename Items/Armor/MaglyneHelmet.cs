using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Intrucial.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MaglyneHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Even This is green?");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 10000000;
            item.rare = 6;
            item.defense = 10;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("MaglyneBreastplate") && legs.type == mod.ItemType("MaglyneLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage *= 1.2f;
            player.rangedDamage *= 1.2f;
            player.magicDamage *= 1.2f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglyneBar", 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}