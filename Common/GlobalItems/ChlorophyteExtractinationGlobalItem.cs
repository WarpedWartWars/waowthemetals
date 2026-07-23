using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WaowTheMetals.Common.GlobalItems
{
	public class ChlorophyteExtractinationGlobalItem : GlobalItem
	{
		public override void ExtractinatorUse(int extractType, int extractinatorBlockType, ref int resultType, ref int resultStack) {
			if (extractType != ItemID.ChlorophyteOre || extractinatorBlockType != TileID.ChlorophyteExtractinator)
				return;

			if (extractinatorBlockType == TileID.ChlorophyteExtractinator) {
				if (extractType == ItemID.ChlorophyteOre) {
					resultStack = 1;
					resultType = ModContent.ItemType<Content.Items.LithuaniumOre>();
					return;
				}
				if (extractType == ItemID.ChlorophyteBar) {
					resultType = ModContent.ItemType<Content.Items.LithuaniumBar>();
				}
			} else {
				resultType = -1;
				resultStack = -1;
				return;
			};
		}
	}

	public class ChlorophyteExtractinationModSystem : ModSystem
	{
		public override void PostSetupContent() {
			ItemID.Sets.ExtractinatorMode[ItemID.ChlorophyteOre] = ItemID.ChlorophyteOre;
			ItemID.Sets.ExtractinatorMode[ItemID.ChlorophyteBar] = ItemID.ChlorophyteBar;
		}
	}
}