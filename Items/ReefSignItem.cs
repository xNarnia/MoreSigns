﻿using MoreSigns.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreSigns.Items
{
	public class ReefSignItem : BaseSignItem<ReefSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.ReefBlock, 6)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
