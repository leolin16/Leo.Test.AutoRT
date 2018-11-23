using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leo.Test.AutoRT.Interfaces
{
    public interface IDataStore
    {
        IEnumerable<Screen> GetScreens();
        Screen GetScreenByScreenName(string screenName);
        Task<Screen> AddScreen(Screen screen);
    }
}