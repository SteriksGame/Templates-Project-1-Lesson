public class GameMode
{
    protected BallGenerator BallGenerator;

    public GameMode(BallGenerator ballGenerator)
    {
        BallGenerator = ballGenerator;
    }

    public virtual bool CheckResult() { return false; }
}
