using W3ChampionsStatisticService.PlayerProfiles;

namespace W3ChampionsStatisticService.PersonalSettings
{
    public class SetPictureCommand
    {
        public long GateWay { get; set; }
        public long PictureId { get; set; }
        public Race Race { get; set; }
    }
}