using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTImer : MonoBehaviour
{
    float Timer;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        TimerText.text = Mathf.Floor(Timer).ToString();
    }
}
