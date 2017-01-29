using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    private Rigidbody2D player_rigidbody;
    
    [SerializeField]
    private float player_speed;

    // Use this for initialization
    void Start () {
        player_rigidbody = GetComponent<Rigidbody2D>();

    }

    private void movement_handler(float horizontal) {
        player_rigidbody.velocity = new Vector2(horizontal * player_speed, player_rigidbody.velocity.y);
    }

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");

        movement_handler(horizontal);
	}
}
