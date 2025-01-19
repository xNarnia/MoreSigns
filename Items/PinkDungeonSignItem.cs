
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
	public class PinkDungeonSignItem : BaseSignItem<PinkDungeonSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.PinkBrick, 6)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
