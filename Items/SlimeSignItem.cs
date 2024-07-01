using MoreSigns.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreSigns.Items
{
	public class SlimeSignItem : BaseSignItem<SlimeSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Gel, 6)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
