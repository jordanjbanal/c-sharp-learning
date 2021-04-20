// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public Archmage (string title) : base(title)
        {
          Title = title;
        }

        public override Storm CastRainStorm()
        {
          Storm overriddenRainStorm = new Storm("rain", true, Title);
          return overriddenRainStorm;
        }

        public Storm CastLightningStorm()
        {
          Storm lightningStorm = new Storm("lightning", true, Title);
          return lightningStorm;
        }
    }
}
