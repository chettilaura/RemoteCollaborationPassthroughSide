using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class RaySwitch : MonoBehaviour
{

    public GameObject shared_ray;
    private bool _switch = true; //true if showing, false if hidden
    
    void Update()
    {


        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            if (_switch == true)
            {
                _switch = false;
                Debug.Log("ray disabled");
                shared_ray.SetActive(false);

            }
            else
            {
                _switch = true;
                Debug.Log("ray enabled");
                shared_ray.SetActive(true);

            }

        }


    }
}
