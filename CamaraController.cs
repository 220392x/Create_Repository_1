using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour {

    // Use this for initialization
    GameObject player;

	void Start () {
        this.player = GameObject.Find("Furry");
	}

	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
	}
}
