using UnityEngine;
using System.Collections;

public class central : MonoBehaviour {
    public Transform[] scene;
    public GameObject player;
    public int coin;
    public int coin_save;
	// Use this for initialization
    void Start()
    {
        coin_save = 0;
        Object.DontDestroyOnLoad(gameObject);
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void NewScene()
    {
        int i = Random.Range(0,scene.Length);
        Transform clone;
        clone = Instantiate(scene[i], new Vector3( player.transform.position.x + 15, 2.5f, 0), Quaternion.identity) as Transform;
    }

    void Increment()
    {
        coin++;
    }

    void Save()
    {
        coin_save = coin;
    }

    void Death()
    {
        coin = coin_save;
    }
}
