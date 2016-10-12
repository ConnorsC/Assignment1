using UnityEngine;
using System.Collections;

public class FloorRotation : MonoBehaviour {

    public float speed =8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

    }
}
