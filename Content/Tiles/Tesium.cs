using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WaowTheMetals.Content.Tiles
{
	public class Tesium : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			TileID.Sets.FriendlyFairyCanLureTo[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 410; //todo
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			AddMapEntry(new Color(2, 1, 12)); //palladium hue -128 lightness -95

			DustType = DustID.Platinum; //todo
			VanillaFallbackOnModDeletion = TileID.Chlorophyte;
            HitSound = SoundID.Tink;
		}
	}
}