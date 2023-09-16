using System.Collections.Generic;
using System.Linq;

public class AllBallGameMode : IGameMode
{
    public bool IsWin(IEnumerable<Ball> balls)
    {
        if (balls.LongCount() == 0)
            return true;

        return false;
    }
}
