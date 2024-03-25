using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRigAligner : MonoBehaviour
{
    public Transform startTransform;

    public Transform rig;
    public Transform cam;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        AlignTransform();
    }

    void AlignTransform()
    {
        Quaternion flatCamRotation = Quaternion.Euler(0f, cam.transform.eulerAngles.y, 0f);
        Quaternion rotationoffset = Quaternion.Inverse(flatCamRotation) * startTransform.rotation;
        rig.transform.rotation *= rotationoffset;

        Vector3 rigOffset = startTransform.position - rig.transform.position;
        Vector3 camToRigOffset = rig.transform.position - cam.transform.position;


        rig.transform.position += rigOffset;
        rig.transform.position += camToRigOffset;

    }

}
