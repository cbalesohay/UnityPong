using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayerOne = 0;
    public int scorePlayerTwo = 0;

    public ScoreText scoreTextLeft;
    public ScoreText scoreTextRight;
    public Ball ball;
    public Paddle paddleLeft;
    public Paddle paddleRight;

    public void OnScoreZoneReached(int id)
    {
        if (id == 1)
        {
            scorePlayerOne++;
        }
        else if (id == 2)
        {
            scorePlayerTwo++;
        }

        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreTextLeft.SetScore(scorePlayerOne);
        scoreTextRight.SetScore(scorePlayerTwo);
    }
}
