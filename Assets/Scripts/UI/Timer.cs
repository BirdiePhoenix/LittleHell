using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    int minutes;
    int seconds;

    private float time;
    
    void Update()
    {
        time += Time.deltaTime;

        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);

        if(seconds >= 60) { seconds = 0; }
        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void StartTimer(float minutes)
    {
        time = minutes * 60;
        text.color = Color.cyan;
    }

    public int Minutes { get => minutes; }
    public int Seconds { get => seconds; }
}