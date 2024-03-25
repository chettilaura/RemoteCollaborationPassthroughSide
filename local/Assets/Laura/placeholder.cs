using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeholder : MonoBehaviour
{

    public GameObject OVRControllerVisual_left;
    public GameObject holder;
    Quaternion rotationAmount = Quaternion.Euler(0, 90, 0);

    void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Debug.Log("x pressed");

            //set the "leftholder" gameobject at the leftController coordinates 
            gameObject.transform.position = OVRControllerVisual_left.GetComponent<Transform>().position;
            gameObject.transform.rotation = OVRControllerVisual_left.GetComponent<Transform>().rotation * rotationAmount;

            //enable holder visibility
            holder.SetActive(true); 

        }

    }
}
