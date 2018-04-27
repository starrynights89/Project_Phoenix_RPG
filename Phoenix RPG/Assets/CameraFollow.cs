using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        print(player.ToString());
    }

    // Update is called once per frame
    void LateUpdate() {
        // Camera Movement

        // If you dont' want the camera to have a smooth panning / turning one,
        //then just replace the camera look at code with:
        //  transform.lookt(CameraGoalLookAt);
    }
}
