using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour {

    private GameObject player;
    public string level = "Level2";
    public GameObject spawnPoint;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Cooper"); 
	}
	
	// Update is called once per frame
	void Update () {
	

	}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            DontDestroyOnLoad(other.gameObject);
            SceneManager.LoadScene("Level2");
            other.transform.position = GameObject.Find("SpawnPoint").transform.position;
        }
    }
}
