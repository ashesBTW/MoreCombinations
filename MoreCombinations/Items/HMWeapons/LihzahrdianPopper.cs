
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace MoreCombinations.Items.HMWeapons
{
    public class LihzahrdianPopper : ModItem

    {
        public override void SetStaticDefaults()
        {
          
        }

        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 10000;
            item.knockBack = 1;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 125;
            item.useAnimation = 125;
            item.autoReuse = true;
            item.shootSpeed = 25;
            item.noMelee = true;
            item.shoot = AmmoID.Bullet;
            item.useAmmo = AmmoID.Bullet;
            item.rare = ItemRarityID.Purple;
            item.UseSound = SoundID.Item92;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarTabletFragment, 20);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.Musket);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 10);
            recipe.AddIngredient(ItemID.LihzahrdPowerCell);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
