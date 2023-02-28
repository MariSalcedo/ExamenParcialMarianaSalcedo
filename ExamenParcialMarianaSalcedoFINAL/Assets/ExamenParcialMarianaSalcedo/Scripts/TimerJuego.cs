using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerJuego : MonoBehaviour
{
    public float timer = 60f;
    public TextMeshProUGUI textTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textTimer.text = "Tiempo restante: " + timer.ToString("f2");

        if(timer <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}