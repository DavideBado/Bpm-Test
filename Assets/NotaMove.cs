using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaMove : MonoBehaviour {
    float Speed;
    Collider collider;
    float Space;
    public float SpawnTime;
	// Use this for initialization
	void Start ()
    {
        collider = GetComponent<Collider>();
        Space = collider.bounds.size.y;
        Speed = (Space / SpawnTime) + 1; // +1 per separarle

    }
	
	// Update is called once per frame
	void Update () {
        Muoviti();
	}
    void Muoviti()
    {
        if (tag == "Nota")
        {
            transform.position -= new Vector3(0, Speed * Time.deltaTime);
        }

    }
}
