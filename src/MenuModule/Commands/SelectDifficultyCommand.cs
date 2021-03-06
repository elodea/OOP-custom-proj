﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForceUltra.src.MenuModule
{
	/// <summary>
	/// Command to select a difficulty to play at
	/// </summary>
	public class SelectDifficultyCommand : ICommand
	{
		private IMenuModule menuModule;
		private string id;

		public SelectDifficultyCommand(IMenuModule m, string id) {
			menuModule = m;
			this.id = id;
		}

		public void Execute() {
			menuModule.AddSelection(SelectionType.Difficulty, id);
		}

		public void Undo() {
			menuModule.RemoveSelection(SelectionType.Difficulty);
		}
	}
}
