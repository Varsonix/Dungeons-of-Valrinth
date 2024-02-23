using Dungeons_of_Valrinth.Core;
using Dungeons_of_Valrinth.Systems;

namespace Dungeons_of_Valrinth.Interfaces
{
    public interface IBehavior
    {
        bool Act(Monster monster, CommandSystem commandSystem);
    }
}
