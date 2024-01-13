using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingController : MonoBehaviour
{
    public GameObject TurbineObject;
    bool isActive = true;
    public void Toggler()
    {
        if (isActive)
        {
            TurbineObject.SetActive(false);
            isActive = false;
        }
        else
        {
            TurbineObject.SetActive(true);
            isActive = true;
        }
    }
}
