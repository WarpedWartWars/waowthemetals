using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
//19910113
namespace WaowTheMetals.Content.Items
{
    public class TesiumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 100;
            //ItemID.Sets.ItemNoGravity[Item.type] = true;
            ItemID.Sets.SortingPriorityMaterials[Type] = 58;
            ItemID.Sets.ShimmerTransformToItem[Type] = ModContent.ItemType<LithuaniumOre>();

            ItemTrader.ChlorophyteExtractinator.AddOption_OneWay(ModContent.ItemType<LithuaniumOre>(), 1, Type, 1);
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Content.Tiles.Tesium>());
            Item.width = 12;
            Item.height = 12;
            Item.value = Item.sellPrice(0, 0, 1, 0); //todo
            Item.rare = ItemRarityID.Cyan; // todo, very very new Color(151, 196, 191) blueish-green
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
        
        public override void ExtractinatorUse(int extractinatorBlockType, ref int resultType, ref int resultStack) {
			//resultType = ModContent.ItemType<LithuaniumOre>(); //todo
		}
    }
}