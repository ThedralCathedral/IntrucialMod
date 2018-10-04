using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items
{
    public class MaglyneOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Maglyne Ore. Last one, of its kind.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 10000;
            item.rare = 3;
            item.useTime = 45;
            item.useStyle = 1;
            item.createTile = mod.TileType("MaglyneOreTile");
            item.consumable = true;
        }
    }
}