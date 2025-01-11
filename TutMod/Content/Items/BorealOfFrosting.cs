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
	public class BorealOfFrosting : ModItem
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
                Item.useStyle = 1;
                Item.useAnimation = 26;
                Item.useTime = 26;
                Item.width = 26;
                Item.height = 28;
                Item.shoot = 979;
                Item.UseSound = SoundID.Item8;
                Item.damage = 15;
                Item.shootSpeed = 7f;
                Item.magic = true;
                Item.noMelee = true;
                Item.mana = 2;
                Item.crit = 10;
			}
			else //Sets what happens on left click(normal use)
			{
				Item.useStyle = 1;
				Item.useTurn = false;
				Item.useAnimation = 20;
				Item.useTime = 20;
				Item.width = 24;
                Item.height = 28;
				Item.damage = 8;
				Item.knockBack = 6f;
				Item.UseSound = SoundID.Item1;
				Item.scale = 1f;
				Item.value = 100;
				Item.melee = true;
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
			recipe.AddIngredient(ItemID.BorealWoodSword, 1);
			recipe.AddIngredient(ItemID.WandofFrosting, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}



/**
					this.useStyle = 1;
					this.useTurn = false;
					this.useAnimation = 20;
					this.useTime = 20;
					base.width = 24;
					base.height = 28;
					this.damage = 8;
					this.knockBack = 6f;
					this.UseSound = SoundID.Item1;
					this.scale = 1f;
					this.value = 100;
					this.melee = true;

                    			this.useStyle = 1;
			this.useAnimation = 26;
			this.useTime = 26;
			base.width = 26;
			base.height = 28;
			this.shoot = 979;
			this.UseSound = SoundID.Item8;
			this.damage = 15;
			this.shootSpeed = 7f;
			this.magic = true;
			this.noMelee = true;
			this.mana = 2;
			this.crit = 10;
**/