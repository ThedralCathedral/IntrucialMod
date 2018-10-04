using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Intrucial
{

    public class IntrucialPlayer : ModPlayer
    {
        public bool HiddenRecipesAvailable { get; set; }

        public override TagCompound Save()
        {
            return new TagCompound()
        {
            { "HiddenRecipesAvailable", HiddenRecipesAvailable }
        };
        }
        public override void Load(TagCompound tag)
        {
            HiddenRecipesAvailable = tag.GetBool("HiddenRecipesAvailable");
        }
    }
}