using MoreSigns.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreSigns.Items
{
	public class SteampunkSignItem : BaseSignItem<SteampunkSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Cog, 6)
				.AddTile(TileID.SteampunkBoiler)
				.Register();
		}
	}
}
