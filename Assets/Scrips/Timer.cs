using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timeLeftText;
    [SerializeField] private float timeLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Update()
    {
        timeLeft -= Timer.deltaTime;
        timeLeftText.SetText(Mathf.ceilToInt(timeLeft).ToString());

        if(IsFinished())
        {
            config.FinishGame();
        }
    }
    public void Reset()
    {
        timeLeft = config.gameDuration;
    }
    public void IsFinished() 
    {
        //bool
    }


}
