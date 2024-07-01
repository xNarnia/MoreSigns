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
	public class TungstenSignItem : BaseSignItem<TungstenSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.TungstenBar, 2)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
