﻿using System.Collections.Generic;
using System.Threading.Tasks;
using W3ChampionsStatisticService.Ladder;
using W3ChampionsStatisticService.PlayerProfiles;

namespace W3ChampionsStatisticService.Ports
{
    public interface IPlayerRepository
    {
        Task UpsertPlayer(PlayerProfile playerProfile);
        Task UpsertPlayer(PlayerOverview playerOverview);
        Task<PlayerProfile> Load(string battleTag);
        Task<PlayerOverview> LoadOverview(string battleTag);
        Task<PlayerWinLoss> LoadPlayerWinrate(string playerId);
        Task Save(List<PlayerWinLoss> winrate);
        Task<PlayerOverview> LoadOverviewFrom(int offset);
    }
}