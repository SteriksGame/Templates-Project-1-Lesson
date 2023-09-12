using System.Linq;

public class OnlyOneColorBallGameMode : GameMode
{
    public OnlyOneColorBallGameMode(BallGenerator ballGenerator) : base(ballGenerator) { }
    public override bool CheckResult()
    {
        int countBallGreen = BallGenerator.Balls.Where(balls => balls is BallGreen).Count();
        int countBallRed = BallGenerator.Balls.Where(balls => balls is BallRed).Count();
        int countBallWhite = BallGenerator.Balls.Where(balls => balls is BallWhite).Count();

        if (countBallGreen == 0 || countBallRed == 0 || countBallWhite == 0)
            return true;

        return false;
    }
}