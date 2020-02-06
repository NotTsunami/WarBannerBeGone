using BepInEx;
using RoR2;
using ItemCatalog = On.RoR2.ItemCatalog;

namespace Tsunami
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("dev.tsunami.WarBannerBeGone", "WarBannerBeGone", "1.0.0")]
    public class WarBannerBeGone : BaseUnityPlugin
    {
        public void Awake()
        {
            ItemCatalog.RegisterItem += (orig, index, def) =>
            {
                if (index == ItemIndex.WardOnLevel)
                {
                    def.tier = ItemTier.NoTier;
                }
                orig(index, def);
            };
        }
    }
}