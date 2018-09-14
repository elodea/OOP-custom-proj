﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Wormhole
{
	public class Weapon : Tool
	{
		private AmmoHandler ammoHandler;

		public Weapon(AmmoHandler handler)
		{
			ammoHandler = handler;
		}

		public override void Activate()
		{
			if (cdHandler.OnCooldown())
				return;

			//fetch template ammo
			Ammo templateAmmo = (Ammo)ChildComponents.FetchComponent<Ammo>(ammoId);
			//deep copy
			Ammo newAmmo = Util.DeepClone(templateAmmo);

			ammoHandler.AddAmmo(newAmmo);
			cdHandler.StartCooldown();
		}
	}
}