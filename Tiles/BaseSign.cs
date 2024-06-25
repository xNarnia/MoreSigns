using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Terraria.Enums;
using MoreSigns.Items;
using Terraria.GameContent.ObjectInteractions;
using Terraria.Chat;
using Humanizer;

namespace MoreSigns.Tiles
{
	public abstract class BaseSign<T> : ModTile where T : ModItem
	{
		private int TileI { get; set; }
		private int TileJ { get; set; }

		public override void SetStaticDefaults()
		{
			Main.tileSign[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileID.Sets.DisableSmartCursor[Type] = true;
			AdjTiles = new int[] { Type };

			// Use the vanilla sign style as our foundation.
			TileObjectData.newTile.CopyFrom(TileObjectData.GetTileData(TileID.Signs, 0));

			// Implement fixes for two of the five styles from the Vanilla Sign TileObjectData.
			// Fix Vanilla TileObjectData: Allow attaching sign to the ground by changing origin.
			TileObjectData.newSubTile.CopyFrom(TileObjectData.newTile);
			TileObjectData.newSubTile.Origin = new Point16(0, 0);
			TileObjectData.addSubTile(0);

			// Fix Vanilla TileObjectData: Allow attaching to a solid object that is to the right of the sign.
			TileObjectData.newSubTile.CopyFrom(TileObjectData.newTile);
			TileObjectData.newSubTile.Origin = new Point16(0, 0);
			TileObjectData.newSubTile.AnchorBottom = AnchorData.Empty;
			TileObjectData.addSubTile(3);
			TileObjectData.addTile(Type);
		}

		public string GetSignText()
		{
			return Main.sign[Sign.ReadSign(TileI, TileJ)].text;
		}

		public void SetSignText(string input)
		{
			Main.sign[Sign.ReadSign(TileI, TileJ)].text = input;
		}

		public override void PlaceInWorld(int i, int j, Item item)
		{
			TileI = i;
			TileJ = j;
			Sign.ReadSign(TileI, TileJ, true);
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Sign.KillSign(i, j);
		}

		public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings)
		{
			return true;
		}
	}
}
