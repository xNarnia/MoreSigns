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
	public class StardustSignItem : BaseSignItem<StardustSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.StardustBrick, 6)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}
}
