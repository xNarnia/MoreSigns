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
	public class HoneySignItem : BaseSignItem<HoneySign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.HoneyBlock, 6)
				.AddTile(TileID.HoneyDispenser)
				.Register();
		}
	}
}
