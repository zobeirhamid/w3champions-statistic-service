﻿using System.Threading.Tasks;
using W3ChampionsStatisticService.PadEvents;
using W3ChampionsStatisticService.Ports;
using W3ChampionsStatisticService.ReadModelBase;

namespace W3ChampionsStatisticService.Ladder
{
    public class PlayOverviewHandler : IReadModelHandler
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayOverviewHandler(
            IPlayerRepository playerRepository
            )
        {
            _playerRepository = playerRepository;
        }

        public async Task Update(MatchFinishedEvent nextEvent)
        {
            foreach (var playerRaw in nextEvent.match.players)
            {
                var player = await _playerRepository.LoadOverview(playerRaw.id)
                             ?? new PlayerOverview(playerRaw.id, playerRaw.battleTag, nextEvent.match.gateway);
                player.RecordWin(playerRaw.won, (int?) playerRaw.updatedMmr?.rating ?? (int) playerRaw.mmr.rating);
                await _playerRepository.UpsertPlayer(player);
            }
        }
    }
}