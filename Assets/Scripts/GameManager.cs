using DG.Tweening;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public int AIScore;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI AIScoreText;
    
    [Header("Audios")]
    public AudioSource audioSource;
    public AudioClip scoreSfx;

    public void PlayerPoint()
    {
        JuiceText(playerScoreText);
        
        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }

    public void AIPoint()
    {
        JuiceText(AIScoreText);
        
        AIScore++;
        AIScoreText.text = AIScore.ToString();
    }

    void JuiceText(TextMeshProUGUI text)
    {
        audioSource.PlayOneShot(scoreSfx);
        
        text.transform.DOKill();
        text.transform.localScale = Vector3.one;
        text.transform.DOScale(1.5f, 0.5f).SetLoops(2, LoopType.Yoyo);
        
       // text.DOColor(Color.yellow, 0.5f).SetLoops(2, LoopType.Yoyo);
    }

    public void ClickButton()
    {
        Debug.Log("Click button");
    }
}
