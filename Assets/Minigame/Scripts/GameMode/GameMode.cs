using System.Collections.Generic;

public interface IGameMode
{
    bool IsWin(IEnumerable<Ball> balls);
}
