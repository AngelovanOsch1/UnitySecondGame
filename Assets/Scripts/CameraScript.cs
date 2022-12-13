using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int movingSpeed = 5;

    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * movingSpeed;
    }
}
