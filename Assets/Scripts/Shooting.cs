using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public float velocity = 100f;
	public float fireRate = 0.2f;
	public GameObject shotSpawn;

	float nextFire = 0f;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject theBullet = (GameObject) Instantiate (bulletPrefab, shotSpawn.transform.position, shotSpawn.transform.rotation);
			Rigidbody theBulletRB = theBullet.GetComponent<Rigidbody> ();
			theBulletRB.AddForce (theBullet.transform.forward * velocity);
			nextFire = Time.time + fireRate;
		}
	}
}
