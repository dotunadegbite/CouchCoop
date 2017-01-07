using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour {

    public void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
