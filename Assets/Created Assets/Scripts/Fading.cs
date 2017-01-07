﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Fading : MonoBehaviour {

    public Texture2D fadeoutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private  int fadeDir = -1;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelLoaded;
    }
	void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeoutTexture);
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return(fadeSpeed);
    }

    void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        BeginFade(-1);

    }
}
