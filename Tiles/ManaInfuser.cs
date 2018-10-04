using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Intrucial.Tiles
{
	public class ManaInfuser : ModTile
	{
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Mana Infuser");
            AddMapEntry(new Color(200, 200, 200), name);
            dustType = mod.DustType("Sparkle");
            disableSmartCursor = true;
        }


                    public override void KillMultiTile(int i, int j, int frameX, int frameY)
                    {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("ManaInfuser"));
                    }
    }
}
