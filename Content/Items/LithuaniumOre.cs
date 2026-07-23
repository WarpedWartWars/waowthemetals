using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//19910113
namespace WaowTheMetals.Content.Items
{
    public class LithuaniumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 100;
            //ItemID.Sets.ItemNoGravity[Item.type] = true;
            ItemID.Sets.SortingPriorityMaterials[Type] = 58;
            ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.ChlorophyteOre;
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Content.Tiles.Lithuanium>());
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