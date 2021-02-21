using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MoreCombinations.Items.HMWeapons
{
    public class SpaceMinipistol : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Space Minipistol");
         

        }

        public override void SetDefaults()
        {
            item.magic = true;
            item.damage = 50;
            item.knockBack = 1;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime =5;
            item.useAnimation = 1;
            item.autoReuse = true;
            item.shootSpeed = 20;
            item.mana = 3;
            item.noMelee = true;
            item.shoot = ProjectileID.GreenLaser;
            item.rare = ItemRarityID.LightRed;
        }
     


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpaceGun, 4);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }



    }
}
