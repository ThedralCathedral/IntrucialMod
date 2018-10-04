using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items
{
    public class TelainumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Telainum Ore");
            Tooltip.SetDefault("Telainum Ore. Stronger than it looks.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100000000;
            item.rare = 12;
            item.useTime = 45;
            item.useStyle = 1;
            item.createTile = mod.TileType("TelainumOreTile");
            item.consumable = true;
        }
    }
}