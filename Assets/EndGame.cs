using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGame : MonoBehaviour {

    public SpawnPlayers spawn;
    public float currentTime;

    void Start()
    {
         currentTime = spawn.currentTime;
    }
    
    	
	// Update is called once per frame
	void Update ()
    {
	    if (currentTime <= 0)
	}{

}
