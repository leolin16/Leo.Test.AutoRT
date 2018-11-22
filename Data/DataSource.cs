using System.Collections.Generic;
using System.Linq;

namespace Leo.Test.AutoRT.Data
{
    public class DataSource
    {
        public IList<Screen> Screens
        {
            get;
            set;
        }

        public DataSource()
        {
            Screens = new List<Screen>(){
                new Screen { Category= "Others", ScreenName="EP_LOGIN", ScreenJpName="ログイン_EP"},
                new Screen { Category= "Eface_Core", ScreenName="EC_CHANGE_ACTOR_MF", ScreenJpName= "担当者変更_MainFrame"},
                new Screen { Category= "Create_Quick", ScreenName="EP_CREATE_APP_QUICK", ScreenJpName= "クイック申込"}
            };
        }

        public Screen GetScreenByScreenName(string screenName)
        {
            return Screens.First(i => i.ScreenName.Equals(screenName));
        }
    }
}