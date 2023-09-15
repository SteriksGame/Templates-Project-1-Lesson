using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] private List<Ball> ballCollection = new List<Ball>();

    private int _chanceOfOccurrenceGreen = 100;
    private int _chanceOfOccurrenceRed = 100;
    private int _chanceOfOccurrenceWhite = 100;

    private const int MAX_CHANCE_OF_OCCURRENCE = 100;
    private const int REDUCING_CHANCE_AFTER_APPEARANCE = 50;

    private const int GRID_SIZE_X = 5;
    private const int GRID_SIZE_Y = 5;
    private const int GRID_OFFSET = -2;

    public List<Ball> Generate()
    {
        List<Ball> result = new List<Ball>();

        for (int i = 0; i < GRID_SIZE_X; i++)
        {
            for(int j = 0; j < GRID_SIZE_Y; j++) 
            {
                result.Add(Instantiate(
                    ballCollection[GetRandomBall()],
                    new Vector3(i + GRID_OFFSET, 0, j + GRID_OFFSET),
                    Quaternion.identity
                    ));
            }
        }

        return result;
    }

    private int GetRandomBall()
    {
        if(_chanceOfOccurrenceGreen == 0 && _chanceOfOccurrenceRed == 0 && _chanceOfOccurrenceWhite == 0)
        {
            _chanceOfOccurrenceGreen = MAX_CHANCE_OF_OCCURRENCE;
            _chanceOfOccurrenceRed = MAX_CHANCE_OF_OCCURRENCE;
            _chanceOfOccurrenceWhite = MAX_CHANCE_OF_OCCURRENCE;
        }

        int indexRandomBall = Random.Range(0, ballCollection.Count);
        int randomChance = Random.Range(0, MAX_CHANCE_OF_OCCURRENCE);

        switch (indexRandomBall)
        {
            case 0:
                if (randomChance < _chanceOfOccurrenceGreen)
                { 
                    _chanceOfOccurrenceGreen -= REDUCING_CHANCE_AFTER_APPEARANCE; 
                    return indexRandomBall;
                }
                break;

            case 1:
                if (randomChance < _chanceOfOccurrenceRed)
                {
                    _chanceOfOccurrenceRed -= REDUCING_CHANCE_AFTER_APPEARANCE; 
                    return indexRandomBall;
                }
                break;

            case 2:
                if (randomChance < _chanceOfOccurrenceWhite)
                {
                    _chanceOfOccurrenceWhite -= REDUCING_CHANCE_AFTER_APPEARANCE;
                    return indexRandomBall;
                }
                break;

            default:
                GetRandomBall();
                break;
        }

        return GetRandomBall();
    }
}
