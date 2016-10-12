using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour {
    public string level;
    public string spawnPointName;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("level: " + level + "   spawnpoint: " + spawnPointName);
            DontDestroyOnLoad(other.gameObject);
            SceneManager.LoadScene(level);
            other.transform.position = GameObject.Find(spawnPointName).transform.position;
            print("spawn point search: " + GameObject.Find(spawnPointName).name);
        }
    }
}
