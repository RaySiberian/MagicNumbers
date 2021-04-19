using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class MagicNumbers : MonoBehaviour
{
    
    public Text curNumberText;
    public Text guessNumberText;
    public Text actionsText;
    public SceneLoader sceneLoader;
    
    public static MagicNumbers instance;
    
    private double curNumber;
    private double guessNumer;
    private double pressed = 1;

    private void Awake()
    {
        // Ссылки слетают при переходе на след. сцену
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
            return;
        }
    }

    private void Start()
    {
        sceneLoader = GetComponent<SceneLoader>();
        curNumber = Random.Range(455, 555);
        guessNumer = Random.Range(300, 700);
        curNumberText.text = curNumber.ToString();
        guessNumberText.text = guessNumer.ToString();
        actionsText.text = "1"; 
    }

    private void TextUpdate()
    {
        // Почему не округляется? 
        curNumberText.text = curNumber.ToString();
        guessNumberText.text = guessNumer.ToString();
        actionsText.text = pressed.ToString(); 
    }

    public void OnMorePressed()
    {
        if (pressed <= 15)
        {
            curNumber += 100 * (1 / pressed);
            Math.Round(curNumber,0);
            pressed++;
            TextUpdate();
        }
        else if (pressed > 15 && pressed < 20)
        {
            curNumber += 5;
            Math.Round(curNumber,0);
            pressed++;
            TextUpdate();
        }
        else 
        {
            curNumber += 1;
            Math.Round(curNumber,0);
            pressed++;
            TextUpdate();
        }
    }
    public void OnLessPressed()
    {
        if (pressed <= 15)
        {
            curNumber -= 100 * (1 / pressed);
            Math.Round(curNumber,0);
            pressed++;
            TextUpdate();
        }
        else if (pressed > 15 && pressed < 20)
        {
            curNumber -= 5;
            Math.Round(curNumber,0);
            pressed++;
            TextUpdate();
        }
        else 
        {
            curNumber -= 1;
            Math.Round(curNumber,0);
            pressed++;
            TextUpdate();
        }
    }
    
    
    
    public void OnSuccsessPressed()
    {
        sceneLoader.LoadWinScene();
        
        // Должно быть
        if (Math.Round(curNumber) == Math.Round(guessNumer))
        {
            sceneLoader.LoadWinScene();
        }
    }
}
