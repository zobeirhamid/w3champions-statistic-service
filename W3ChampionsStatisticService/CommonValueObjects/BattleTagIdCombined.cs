using System.Collections.Generic;
using System.Linq;

namespace W3ChampionsStatisticService.CommonValueObjects
{
    public class BattleTagIdCombined
    {
        public List<PlayerId> BattleTags { get; }
        public GateWay GateWay { get; }
        public GameMode GameMode { get; }
        public int Season { get; }
        public string Id { get; }

        public BattleTagIdCombined(
            List<PlayerId> battleTags,
            GateWay gateWay,
            GameMode gameMode,
            int season)
        {
            BattleTags = battleTags;
            GateWay = gateWay;
            GameMode = gameMode;
            Season = season;
            Id = $"{season}_{string.Join("_", battleTags.OrderBy(t => t.BattleTag).Select(b => $"{b.BattleTag}@{(int)gateWay}"))}_{gameMode}";
        }
    }
}