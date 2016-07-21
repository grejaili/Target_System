using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

    // Use this for initialization
    public float health;
    float maxHealth;

    void Start()
    {
        maxHealth = 100;
        health = maxHealth;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
