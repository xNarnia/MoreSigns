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
	public class ObsidianSignItem : BaseSignItem<ObsidianSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Obsidian, 6)
				.AddIngredient(ItemID.Hellstone, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
