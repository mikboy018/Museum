using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    public float speed;
    private GameObject monsterBody;

    void Awake()
    {
        monsterBody = GetComponent<GameObject>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        monsterBody.transform.position = new Vector3(speed, 0, 0);
	}
}
