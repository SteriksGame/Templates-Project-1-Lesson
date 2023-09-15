using System.Collections.Generic;
using System.Linq;

public class AllBallGameMode : GameMode
{
    public override bool CheckWinGame(IEnumerable<Ball> balls)
    {
        if (balls.LongCount() == 0)
            return true;

        return false;
    }
}
