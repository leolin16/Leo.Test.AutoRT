using System;
using Leo.Test.AutoRT.Enums;

public class Screen
{
    public int Id { get; set; }
    public string Category { get; set; }

    public string ScreenName { get; set; }

    public string ScreenJpName { get; set; }
    public Boolean Availability { get; set; }
    public string VeriMethod { get; set; }
    public string VeriNo { get; set; }
    public string BrowserType { get; set; }
    public MatchFilter BrowserFilter { get; set; }
    public string BrowserContent { get; set; }
    public string ScreenType { get; set; }
    public MatchFilter ScreenFilter { get; set; }
    public string ScreenContent { get; set; }

}