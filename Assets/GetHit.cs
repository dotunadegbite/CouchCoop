using UnityEngine;
using System.Collections;

public class GetHit : MonoBehaviour
{

    PlayerHealth health;

    // Use this for initialization
    void Start()
    {
        health = GetComponent<PlayerHealth>();
        StartCoroutine(TakeHit());
    }

    public IEnumerator TakeHit()
    {
        while (health.currentHealth > 0)
        {
            health.TakeDamage(10);
            yield return new WaitForSeconds(10f);
        }
    }
}
