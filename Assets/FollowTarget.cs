using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {

    public Transform player1;
    public Transform player2;


    private Vector3 offset;
    private Camera mainCamera;
	// Use this for initialization
	void Start () {
        offset = transform.position - (player1.position + player2.position) / 2;
        mainCamera = this.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player1 == null || player2 == null) return;
        transform.position = (player1.position + player2.position) / 2 + offset;
        float distance = Vector3.Distance(player1.position, player2.position);
        float size = distance * 0.886f;
        mainCamera.orthographicSize = size;
	}
}
