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
    public class LaserPistol : ModItem

    {


        public override void SetDefaults()
        {
            item.magic = true;
            item.damage = 150;
            item.knockBack = 1;
            item.mana = 12;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.autoReuse = true;
            item.shootSpeed = 25;
            item.shoot = ProjectileID.LaserMachinegunLaser;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item93;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LaserMachinegun);
            recipe.AddIngredient(ItemID.SpaceGun);
            recipe.AddIngredient(ItemID.FragmentNebula, 5);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
