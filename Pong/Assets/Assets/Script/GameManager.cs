using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public SFXManager SfxManager;
    
    public Text playerScoreText;
    public Text computerScoreText;
    
    private int _playerScore;
    private int _computerScore;

    public void PlayerScore()
    {
        _playerScore++;
        SfxManager.PlaySFX(SfxManager.scored);
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }
    
    public void ComputerScore()
    {
        _computerScore++;
        SfxManager.PlaySFX(SfxManager.failed);
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
