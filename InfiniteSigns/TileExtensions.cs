
using Terraria;
using Terraria.ID;

namespace InfiniteSigns
{
	public static class TileExtensions
	{
		public static bool IsSign(this Tile t)
		{
			return t.type == TileID.Signs || t.type == TileID.Tombstones || t.type == TileID.AnnouncementBox;
		}
		public static bool IsSolid(this Tile t)
		{
			return t.active() && Main.tileSolid[t.type];
		}
	}
}