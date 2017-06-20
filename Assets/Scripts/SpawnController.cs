using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public GameObject enemy;
    public GameObject spawnPoint;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Create", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Create()
    {
        Vector3 v3 = new Vector3(0, 5, 0);
        GameObject created = Instantiate(enemy, v3, Quaternion.identity);

        Destroy(created, 10);
    }
}
