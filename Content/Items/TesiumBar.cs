using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace WaowTheMetals.Content.Items
{
    public class TesiumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 58;

            ItemTrader.ChlorophyteExtractinator.AddOption_OneWay(ModContent.ItemType<LithuaniumBar>(), 1, Type, 1);
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Content.Tiles.TesiumBar>());
            Item.width = 20;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 0, 1, 0); //todo
            Item.rare = ItemRarityID.Cyan; // todo, very very new Color(151, 196, 191) blueish-green
        }

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Content.Items.TesiumOre>(4)
				.AddTile(TileID.Furnaces)
				.Register();
		}

        public override void ExtractinatorUse(int extractinatorBlockType, ref int resultType, ref int resultStack) {
			//resultType = ModContent.ItemType<LithuaniumOre>(); //todo
		}
    }
}