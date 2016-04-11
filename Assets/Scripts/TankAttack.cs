using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour {
    public GameObject shellPrefab;
    private Transform firePos;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 10;
    public AudioClip shotAudio;
	// Use this for initialization
	void Start () {
	    firePos = transform.Find("FirePos");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey)) {
            AudioSource.PlayClipAtPoint(shotAudio, transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab, firePos.position, firePos.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
            
        }
	}
}
