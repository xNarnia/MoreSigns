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
	public class MeteoriteSignItem : BaseSignItem<MeteoriteSign>
	{
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.MeteoriteBar, 2)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
