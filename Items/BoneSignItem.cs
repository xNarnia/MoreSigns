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
	public class BoneSignItem : BaseSignItem<BoneSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Bone, 6)
				.AddTile(TileID.BoneWelder)
				.Register();
		}
	}
}
