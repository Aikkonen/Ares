using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int healthPoints = 5;

	IEnumerator flashEnemyColor(){
		ArrayList parts = new ArrayList ();
		parts.Add(gameObject.transform.Find("EnemyBody/Head").gameObject);
		parts.Add(gameObject.transform.Find("EnemyBody/Body").gameObject);
		parts.Add(gameObject.transform.Find("EnemyBody/LHand").gameObject);
		parts.Add(gameObject.transform.Find("EnemyBody/RHand").gameObject);
		parts.Add(gameObject.transform.Find("EnemyBody/LLeg").gameObject);
		parts.Add(gameObject.transform.Find("EnemyBody/RLeg").gameObject);

		foreach(GameObject part in parts){
			part.GetComponent<Renderer>().material.color = Color.red;
		}

		yield return new WaitForSeconds(0.1f);

		foreach(GameObject part in parts){
			part.GetComponent<Renderer>().material.color = Color.white;
		}
	}

	void UpdateHealthPoints(){
		Debug.Log("Enemy HP changed!");
		healthPoints--;
		StartCoroutine(flashEnemyColor());
		if (healthPoints == 0) {
			Destroy(gameObject);
		}
	}

	bool isHitByBullet(string tag){
		return tag == "Bullet";
	}

	void OnTriggerEnter(Collider other) {
		if(isHitByBullet(other.tag)){
			UpdateHealthPoints();
		}
	}
}
