using UnityEngine;
using System.Collections;

public class NormalBullet : MonoBehaviour {

    public float timeToDestroy = 4f;
	
	
	
	// Update is called once per frame
	void Update () {

        Destroy(this.gameObject, timeToDestroy);

        if (transform.position.y < 0)
        {
            Destroy(this.gameObject);
        }
       
    }
	}

