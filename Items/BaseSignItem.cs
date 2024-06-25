using MoreSigns.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace MoreSigns.Items
{
	public abstract class BaseSignItem<T> : ModItem where T : ModTile
	{
		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<T>(), 0);
			Item.width = 26;
			Item.height = 22;
			Item.value = 50;
		}
	}
}
