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
	public class MahoganyAmethystStaff : ModItem
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
                Item.mana = 5;
                Item.UseSound = SoundID.Item43;
                Item.useStyle = 5;
                Item.damage = 15;
                Item.useAnimation = 37;
                Item.useTime = 37;
                Item.width = 40;
                Item.height = 40;
                Item.shoot = 121;
                Item.shootSpeed = 6f;
                Item.knockBack = 3.25f;
                Item.noMelee = true;
			}
			else //Sets what happens on left click(normal use)
			{
                Item.useStyle = 1;
                Item.useTurn = false;
                Item.useAnimation = 19;
                Item.useTime = 19;
                Item.width = 24;
                Item.height = 28;
                Item.damage = 8;
                Item.knockBack = 6f;
                Item.UseSound = SoundID.Item1;
                Item.scale = 1f;
                Item.noMelee = false;
                Item.mana = 0;
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
			recipe.AddIngredient(ItemID.RichMahoganySword, 1);
			recipe.AddIngredient(ItemID.AmethystStaff, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}



/**
this.useStyle = 1;
this.useTurn = false;
this.useAnimation = 19;
this.useTime = 19;
base.width = 24;
base.height = 28;
this.damage = 8;
this.knockBack = 6f;
this.UseSound = SoundID.Item1;
this.scale = 1f;
this.value = 100;
this.melee = true;


this.mana = 5;
this.UseSound = SoundID.Item43;
this.useStyle = 5;
this.damage = 15;
this.useAnimation = 37;
this.useTime = 37;
base.width = 40;
base.height = 40;
this.shoot = 121;
this.shootSpeed = 6f;
this.knockBack = 3.25f;
this.value = 2000;
this.magic = true;
this.noMelee = true;
**/