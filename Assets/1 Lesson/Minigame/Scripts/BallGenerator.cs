using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] private List<Ball> ballCollection = new List<Ball>();

    private int _randomGreen = 100;
    private int _randomRed = 100;
    private int _randomWhite = 100;

    public List<Ball> Balls { get; private set; } = new List<Ball>();

    public void Generation()
    {
        for (int i = -2; i < 3; i++)
        {
            for(int j = -2; j < 3; j++) 
            {
                Balls.Add(Instantiate(ballCollection[RandomBall()], new Vector3(i, 0, j), Quaternion.identity));
            }
        }
    }
    public void RemoveBall(Ball ball)
    {
        Balls.Remove(ball);
        Destroy(ball.gameObject);
    }

    private int RandomBall()
    {
        if(_randomGreen == 0 && _randomRed == 0 && _randomWhite == 0)
        {
            _randomGreen = 100;
            _randomRed = 100;
            _randomWhite = 100;
        }

        int indexRandomBall = Random.Range(0, ballCollection.Count);
        int randomChance = Random.Range(0, 100);

        switch (indexRandomBall)
        {
            case 0:
                if (randomChance < _randomGreen)
                { 
                    _randomGreen -= 50; 
                    return indexRandomBall;
                }
                break;

            case 1:
                if (randomChance < _randomRed)
                {
                    _randomRed -= 50; 
                    return indexRandomBall;
                }
                break;

            case 2:
                if (randomChance < _randomWhite)
                {
                    _randomWhite -= 50;
                    return indexRandomBall;
                }
                break;

            default:
                RandomBall();
                break;
        }

        return RandomBall();
    }
}
