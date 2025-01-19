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
	public class NebulaSignItem : BaseSignItem<NebulaSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.NebulaBrick, 6)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}
}
