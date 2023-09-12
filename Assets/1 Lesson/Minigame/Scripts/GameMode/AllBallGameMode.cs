public class AllBallGameMode : GameMode
{
    public AllBallGameMode(BallGenerator ballGenerator) : base(ballGenerator) { }

    public override bool CheckResult()
    {
        if (BallGenerator.Balls.Count == 0)
            return true;
        
        return false;
    }
}
