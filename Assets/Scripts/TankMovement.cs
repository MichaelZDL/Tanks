using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 30;
    public float tankNum = 1;

    private Rigidbody rigidbody;
    // Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}

    void FixedUpdate() {
        float v = Input.GetAxis("VerticalPlayer" + tankNum);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("HorizontalPlayer" + tankNum);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;
    }
}
