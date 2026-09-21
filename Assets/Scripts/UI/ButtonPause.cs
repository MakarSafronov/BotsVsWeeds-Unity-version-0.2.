using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Добавляем пространство имен для TextMeshPro

public class ButtonPause : MonoBehaviour
{
    public AudioClip pauseSound;
    public TMP_Text text; // Заменяем Text на TMP_Text
    private AudioManager am;

    void Awake()
    {
        am = AudioManager.GetInstance();
    }

    public void OnClick()
    {
        if (text.text == "Pause")
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        text.text = "Resume";
        am.PauseAllSounds();
        am.PlaySound(pauseSound);
        Time.timeScale = 0;
        am.PauseMusic();
    }

    public void ResumeGame()
    {
        text.text = "Pause";
        Time.timeScale = 1;
        am.ResumeAllSounds();
        am.PlaySound(pauseSound);
        am.ResumeMusic();
    }
}