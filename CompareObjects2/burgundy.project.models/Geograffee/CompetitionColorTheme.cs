using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [TsClass]
    public class CompetitionColorTheme
    {
        public string BackgroundColor { get; set; }

        public string AccentColor { get; set; }

        public string FontColor { get; set; }

        public string BannerFontColor { get; set; }

        public string StagesBackgroundColor { get; set; }

        public string StagesFontColor { get; set; }

        public string ButtonBackgroundColor { get; set; }

        public string ButtonFontColor { get; set; }

        public CompetitionColorTheme()
        {
            BackgroundColor = "#FEFEFE";
            AccentColor = "#c5c6c7";
            FontColor = "#151514";
            BannerFontColor = "#151514";
            StagesBackgroundColor = "#151514";
            StagesFontColor = "#c5c6c7";
            ButtonBackgroundColor = "#151514";
            ButtonFontColor = "#FEFEFE";
        }
    }
}