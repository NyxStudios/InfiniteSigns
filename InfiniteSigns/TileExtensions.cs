using Terraria;

namespace InfiniteSigns
{
    public static class TileExtensions
	{
		public static bool IsSign(this Tile t)
		{
			return t.type == 55 || t.type == 85 || t.type == 425;
		}
		public static bool IsSolid(this Tile t)
		{
			return t.active() && Main.tileSolid[t.type];
		}
	}
}