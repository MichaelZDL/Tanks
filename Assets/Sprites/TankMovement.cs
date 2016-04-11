using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {

    public float speed = 5;
    private Rigidbody rigidbody;
    // Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}

    void FixedUpdate() {
        float h = Input.GetAxis("Vertical");
        rigidbody.velocity = transform.forward * h * speed;
    }
}
