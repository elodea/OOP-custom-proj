﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForceUltra.src.GameModule.Commands
{
	public class ShootCommand : ICommand
	{
		IControllable controlled;

		public ShootCommand(IControllable c) {
			controlled = c;
		}

		public void Execute() {
			controlled.ShootCommand();
		}

		public void Undo() {
			//can't undo shooting
		}
	}
}
