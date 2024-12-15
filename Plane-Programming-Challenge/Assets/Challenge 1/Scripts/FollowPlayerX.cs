using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    private Vector3 translationVector = new Vector3(30, 0, 10);
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // translate the position of the camera according to the given vector
        transform.position = player.transform.position + translationVector;
        
        // Rotate the camera around the player along the x-axis by -90 degrees
        transform.rotation = Quaternion.Euler(0, -90, 0);
    }
}

