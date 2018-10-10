using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    public float moveSpeed = 600f;

    public EdgeCollider2D restart;

    public EdgeCollider2D points;

    float movement = 0f;

	// Update is called once per frame
	void Update () {
        movement = Input.GetAxisRaw("Horizontal");
	}

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * - moveSpeed);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
