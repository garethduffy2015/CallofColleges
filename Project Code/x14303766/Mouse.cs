using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour
{

    public float RotationSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        float yVal = (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime);

        transform.Rotate(0, yVal, 0, Space.World);
    }

}