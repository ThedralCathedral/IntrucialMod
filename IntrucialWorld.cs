using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace Intrucial
{
    public class IntrucialWorld : ModWorld
    {
        private const int saveVersion = 0;

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Maglyne Ore", IntrucialModOres));
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Telainum Ore", IntrucialModOres));
            }


            int LivingTreesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Living Trees"));
            if (LivingTreesIndex != -1)
            {
                tasks.Insert(LivingTreesIndex + 1, new PassLegacy("Post Terrain", delegate (GenerationProgress progress)
                { }));

            }

        }

        private void IntrucialModOres(GenerationProgress progress)
        {
            for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("MaglyneOreTile"), false, 0f, 0f, false, true);
                WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("TelainumOreTile"), false, 0f, 0f, false, true);

            }
        }
    }
}