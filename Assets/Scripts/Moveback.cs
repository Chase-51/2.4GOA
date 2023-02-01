using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    // The start position is 0, 0, 0
    private Vector3 start = Vector3.zero;

    // The final position is 5, 0, 0
    [SerializeField] private Vector3 final = new(5, 0, 0);

    // Range of accepted values
    [SerializeField] private float margin = 1;

    // We use FixedUpdate because we are working with movement
    private void FixedUpdate()
    {
        // To make it more legible
        Vector3 _pos = transform.position;

        // Checking to see if we are within a certain amount of the specified location
        if ((_pos.x - margin <= final.x && final.x <= _pos.x + margin) &&
            _pos.y - margin <= final.y && final.y <= _pos.y + margin &&
            _pos.z - margin <= final.z && final.z <= _pos.z + margin)
            transform.position = start;
    }
}


