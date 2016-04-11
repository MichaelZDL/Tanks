using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {

    public GameObject shellExplosionPrefab;
    public AudioClip shellExplosionAudio;

    public void OnTriggerEnter(Collider collider) {
        AudioSource.PlayClipAtPoint(shellExplosionAudio, this.transform.position);
        GameObject.Instantiate(shellExplosionPrefab, this.transform.position, this.transform.rotation);
        GameObject.Destroy(this.gameObject);

        if (collider.tag == "Tank") {
            collider.SendMessage("TakeDamage");
        }

    }
}
