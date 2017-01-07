using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    public GameObject logoPrefab;
    public AudioSource sound;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(logoSpawn());
	}


    private IEnumerator logoSpawn()
    {

        GameObject logoSplash = Instantiate<GameObject>(logoPrefab);
        GameObject spawnPoint =  GameObject.Find("Spawn Point");
        logoSplash.transform.localPosition = spawnPoint.transform.position;
        logoSplash.transform.localScale = spawnPoint.transform.localScale * 3f;
        sound.Play();
        yield return new WaitForSeconds(9.0f);
        Color tmp = logoSplash.GetComponent<SpriteRenderer>().color;
        tmp.a = 0f;
        logoSplash.GetComponent<SpriteRenderer>().color = tmp;
        logoSplash.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("TitleScreen");

    }
	

}
