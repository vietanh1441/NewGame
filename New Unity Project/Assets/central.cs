using UnityEngine;
using System.Collections;

public class central : MonoBehaviour {
    public Transform scene;
    public Transform player;
	// Use this for initialization
    void NewScene()
    {
        Transform clone;
        clone = Instantiate(scene, new Vector3( player.position.x + 15, 2.5f, 0), Quaternion.identity) as Transform;
    }
}
