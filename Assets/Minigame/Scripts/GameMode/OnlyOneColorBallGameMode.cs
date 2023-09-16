using System.Collections.Generic;
using System.Linq;

public class OnlyOneColorBallGameMode : IGameMode
{
    public bool IsWin(IEnumerable<Ball> balls)
    {
        int countBallGreen = balls.Where(balls => balls.TypeColor == Ball.TypesColor.Green).Count();
        int countBallRed = balls.Where(balls => balls.TypeColor == Ball.TypesColor.Red).Count();
        int countBallWhite = balls.Where(balls => balls.TypeColor == Ball.TypesColor.White).Count();

        if (countBallGreen == 0 || countBallRed == 0 || countBallWhite == 0)
            return true;

        return false;
    }
}