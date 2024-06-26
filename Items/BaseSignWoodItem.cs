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
	public abstract class BaseSignWoodItem<T> : BaseSignItem<T> where T : ModTile
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Sign, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
