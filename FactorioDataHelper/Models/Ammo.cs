using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioDataHelper.Models
{
    public class Ammo : DataItem
    {
        public string Icon { get; set; }


        public int IconSize { get; set; } = 128;
               

        public string SubGroup { get; set; }


        public string Order { get; set; }


        public int StackSize { get; set; }
    }

    public class AmmoType
    {
        public string Category { get; set; }


        public string TargetType { get; set; }


        public AmmoTypeAction Action { get; set; }
    }

    public class AmmoTypeAction
    {
        public string Type { get; set; }


        public List<AmmoSourceEffect> SourceEffects { get; set; } = new List<AmmoSourceEffect>();


        public AmmoTypeActionDelivery Delivery { get; set; } = new AmmoTypeActionDelivery();
    }

    public class AmmoTypeActionDelivery
    {
        public string Type { get; set; }


        public string Projectile { get; set; }


        public float StartingSpeed { get; set; } = 1;


        public float DirectionDeviation { get; set; }


        public float RangeDeviation { get; set; }


        public int MaxRange { get; set; }


        public int MinRange { get; set; }


        public List<AmmoSourceEffect> SourceEffects { get; set; } = new List<AmmoSourceEffect>();


        public List<AmmoTargetEffect> TargetEffects { get; set; } = new List<AmmoTargetEffect>();
    }

    public class AmmoSourceEffect
    {
        public string Type { get; set; }


        public string EntityName { get; set; }
    }

    public class AmmoTargetEffect
    {
        public string Type { get; set; }


        public string EntityName { get; set; }


        public AmmoTargetEffectDamage Damage { get; set; } = new AmmoTargetEffectDamage();
    }

    /// <summary>
    /// 
    /// </summary>
    public class AmmoTargetEffectDamage
    {
        public int Amount { get; set; }


        public string Type { get; set; } = "physical";
    }

}
