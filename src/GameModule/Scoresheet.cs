﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForceUltra.src.GameModule
{
	/// <summary>
	/// Manages the score of different teams
	/// </summary>
	public class Scoresheet
	{
		private Dictionary<Team, float> teamScores;

		public Scoresheet() {
			teamScores = new Dictionary<Team, float>();

			teamScores.Add(Team.Team1, 0);
			teamScores.Add(Team.Team2, 0);
			teamScores.Add(Team.Team3, 0);
			teamScores.Add(Team.Team4, 0);
			teamScores.Add(Team.Computer, 0);
		}

		/// <summary>
		/// Add points to a team
		/// </summary>
		public void AddPoints(Team team, float points) {
			teamScores[team] = teamScores[team] + points;
		}

		/// <summary>
		/// Remove points from a team
		/// </summary>
		public void RemovePoints(Team team, float points) {
			AddPoints(team, -points);
		}

		/// <summary>
		/// Fetch score of the team
		/// </summary>		
		/// <returns>score</returns>
		public int FetchTeamScore(Team team) {
			return (int)teamScores[team];
		}
	}
}
