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
	public class SpookySignItem : BaseSignItem<SpookySign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.SpookyWood, 6)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
