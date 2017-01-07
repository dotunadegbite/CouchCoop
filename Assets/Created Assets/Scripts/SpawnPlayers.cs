using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnPlayers : MonoBehaviour {

    public GameObject playerOnePrefab;
    public GameObject playerTwoPrefab;
    public Transform[] spawnPoints;
    private int spawnIndex;
    private int previousSpawnIndex;
    GameObject playerOne;
    GameObject playerTwo;
    public float startingTime;
    private float currentTime;
    public Text time;
    PlayerHealth playerOneHealth;
    PlayerHealth playerTwoHealth;
    Slider slide1;
    Slider slide2;
    Image img1;
    Image img2;


    private void Start()
    {

        //Instantiate();
        StartCoroutine(Countdown(startingTime));


    }

    private void Instantiate()
    {
        spawnIndex = calculateSpawnIndex();
        previousSpawnIndex = spawnIndex;
        playerOne = Instantiate<GameObject>(playerOnePrefab);
        playerOne.tag = "Player One";
        playerOne.transform.localPosition = spawnPoints[spawnIndex].transform.position;
        playerTwo = Instantiate<GameObject>(playerTwoPrefab);
        playerTwo.tag = "Player Two";
        while (spawnIndex == previousSpawnIndex) spawnIndex = calculateSpawnIndex();
        playerTwo.transform.localPosition = spawnPoints[spawnIndex].transform.position;
        playerOneHealth = playerOne.GetComponent<PlayerHealth>();
        playerTwoHealth = playerTwo.GetComponent<PlayerHealth>();
        
        
    }

    private int calculateSpawnIndex()
    {
        int currentSpawnIndex = (int)Random.Range(0, spawnPoints.Length);
        return currentSpawnIndex;

    }

	public IEnumerator Countdown(float startingTime)
    {
        Debug.Log("Occur");
        currentTime = startingTime;
        while(currentTime > 0)
        {
            time.text = currentTime.ToString();
            yield return new WaitForSeconds(1.0f);
            currentTime--;
        }
    }

    void Update()
    {
        
    }
}
