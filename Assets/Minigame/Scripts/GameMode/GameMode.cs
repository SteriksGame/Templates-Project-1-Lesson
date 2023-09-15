using System.Collections.Generic;

public class GameMode
{
    public virtual bool CheckWinGame(IEnumerable<Ball> balls) { return false; }
}
