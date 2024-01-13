using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public Vector3 RotationVector;
    void Update()
    {
        transform.Rotate(RotationVector*Time.deltaTime);
    }
}
