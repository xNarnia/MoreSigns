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
			// All StaticDefaults provided by ExampleSign from the tModLoader repo
			// https://github.com/tModLoader/tModLoader/blob/1.4.4/ExampleMod/Content/Tiles/ExampleSign.cs
			Main.tileSign[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileID.Sets.DisableSmartCursor[Type] = true;
			TileID.Sets.FramesOnKillWall[Type] = true;
			TileID.Sets.AvoidedByNPCs[Type] = true;
			TileID.Sets.TileInteractRead[Type] = true;
			TileID.Sets.InteractibleByNPCs[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.StyleMultiplier = 5;
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 18 };
			TileObjectData.newTile.AnchorBottom = AnchorData.Empty; 

			AnchorData SolidOrSolidSideAnchor2TilesLong = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, 2, 0);
			AnchorData SolidOrSolidSideOrTreeAnchor2TilesLong = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree, 2, 0);

			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, 2, 0); ;
			TileObjectData.addAlternate(0); // Due to a bug in TileLoader.CheckModTile, we need a separate alternate for the normal placement

			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.Origin = Point16.Zero;
			TileObjectData.newAlternate.AnchorTop = SolidOrSolidSideAnchor2TilesLong;
			TileObjectData.newAlternate.DrawYOffset = -2;
			TileObjectData.addAlternate(1);

			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.Origin = Point16.Zero;
			TileObjectData.newAlternate.AnchorLeft = SolidOrSolidSideOrTreeAnchor2TilesLong;
			TileObjectData.addAlternate(2);

			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.Origin = new Point16(1, 0);
			TileObjectData.newAlternate.AnchorRight = SolidOrSolidSideOrTreeAnchor2TilesLong;
			TileObjectData.addAlternate(3);

			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.Origin = Point16.Zero;
			TileObjectData.newAlternate.AnchorWall = true;
			TileObjectData.addAlternate(4);

			TileObjectData.newTile.AnchorBottom = SolidOrSolidSideAnchor2TilesLong; 
			TileObjectData.addTile(Type);
		}

		public override void SetDrawPositions(int i, int j, ref int width, ref int offsetY, ref int height, ref short tileFrameX, ref short tileFrameY)
		{
			if (tileFrameX == 36 || tileFrameX == 54)
			{
				offsetY = -2;
			}

			base.SetDrawPositions(i, j, ref width, ref offsetY, ref height, ref tileFrameX, ref tileFrameY);
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
