using UnityEngine;
using System.Collections;

public class LevelTrigger : MonoBehaviour {

    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Cooper");        

	}
	
	// Update is called once per frame
	void Update () {
	
	}


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        //dont move the rigidbody if the character is on top of it


        if (hit.gameObject == gameFloor)
        {
            transform.position = respawnPoint.transform.position;
        }

        if (m_CollisionFlags == CollisionFlags.Below)
        {
            return;
        }

        if (body == null || body.isKinematic)
        {
            return;
        }
        body.AddForceAtPosition(m_CharacterController.velocity * 0.1f, hit.point, ForceMode.Impulse);
    }
}

}
