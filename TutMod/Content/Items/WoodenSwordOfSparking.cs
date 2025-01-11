using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.Utilities;
namespace TutMod.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class WoodenSwordOfSparking : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TutMod.hjson' file.
		public override void SetDefaults()
		{
            Item.shootSpeed = 7;
			Item.useTime = 26;
			Item.useAnimation = 20;
            Item.useTurn = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.value = 100;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override bool MeleePrefix() 
		{
			return true;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)//Sets what happens on right click(special ability)
			{
				Item.mana = 2;
				Item.damage = 14;
				Item.useStyle = 3;
				Item.shootSpeed = 7f;
				Item.shoot = 954;
				Item.width = 26;
				Item.height = 28;
				Item.UseSound = SoundID.Item8;
				Item.useAnimation = 26;
				Item.useTime = 26;
				Item.noMelee = true;
				//Item.magic = true;
				Item.crit = 10;
			}
			else //Sets what happens on left click(normal use)
			{
				Item.mana = 0;
				Item.useStyle = 1;
				Item.useTurn = false;
				Item.useTime = 20;
				Item.useAnimation = 20;
				Item.width = 24;
				Item.height = 28;
				Item.damage = 7;
				Item.knockBack = 5f;
				Item.scale = 1f;
				Item.UseSound = SoundID.Item1;
				Item.noMelee = false;
				//Item.melee = true;
			}
			return true;
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			if (player.altFunctionUse == 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WoodenSword, 1);
			recipe.AddIngredient(ItemID.WandofSparking, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}

            /**                 Wooden Sword
            this.useStyle = 1;
			this.useTurn = false;
			this.useTime = 20;
			this.useAnimation = 20;
			base.width = 24;
			base.height = 28;
			this.damage = 7;
			this.knockBack = 5f;
			this.scale = 1f;
			this.UseSound = SoundID.Item1;
			this.value = 100;
			this.melee = true;
            **/
            /**                 Wand of Sparking
            this.mana = 2;
			this.damage = 14;
			this.useStyle = 1;
			this.shootSpeed = 7f;
			this.shoot = 954;
			base.width = 26;
			base.height = 28;
			this.UseSound = SoundID.Item8;
			this.useAnimation = 26;
			this.useTime = 26;
			this.rare = 1;
			this.noMelee = true;
			this.value = 10000;
			this.magic = true;
			this.crit = 10;
            **/