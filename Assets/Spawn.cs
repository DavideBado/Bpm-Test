using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public float Bpm;
    float SpawnTime;
    GameObject Nota;
	// Use this for initialization
	void Start ()        
    {
        SpawnTime = 60 / Bpm;
        Nota = GameObject.Find("Nota");
	}
	
	// Update is called once per frame
	void Update ()
    {
        Spawnala();
	}
    void Spawnala()
    {
        SpawnTime -= Time.deltaTime;
        if(SpawnTime <= 0)
        {
            GameObject Clone = GameObject.Instantiate(Nota, transform.position, Quaternion.identity);
            Clone.GetComponent<NotaMove>().SpawnTime = 60 / Bpm;
            Clone.tag = "Nota";
            SpawnTime = 60 / Bpm;            
        }
    }
}
