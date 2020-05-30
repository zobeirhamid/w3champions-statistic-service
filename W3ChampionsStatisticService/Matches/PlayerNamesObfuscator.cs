﻿using System.Linq;
using W3ChampionsStatisticService.CommonValueObjects;

namespace W3ChampionsStatisticService.Matches
{
    public static class PlayerNamesObfuscator
    {
        public static void ObfuscatePlayersForFFA(params OnGoingMatchup[] matches)
        {
            foreach (var ffaMatch in matches.
                Where(x => x != null && x.GameMode == GameMode.FFA))
            {
                foreach (var team in ffaMatch.Teams)
                {
                    foreach (var player in team.Players)
                    {
                        player.BattleTag = "*";
                        player.Name = "*";
                    }
                }
            }
        }
    }
}