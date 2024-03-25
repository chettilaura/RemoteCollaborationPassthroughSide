using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;

public class MyNetworkedRay : MonoBehaviour
{
    NetworkContext context;

    //ray starts disabled
    private bool rayswitch = false;
    public GameObject ray;

    void Start()
    {
        context = NetworkScene.Register(this);
    }


    private struct Message
    {
        public Vector3 position;
        public Quaternion rotation;
        public string name;
    }


    public void ProcessMessage(ReferenceCountedSceneGraphMessage message)
    {
        var m = message.FromJson<Message>();
        Debug.Log("a message received from " + m.name);

        if (m.name == "rayswitch")
        {
            Debug.Log("rayswitch was selected");
            if (rayswitch == false)
            {
                ray.GetComponent<MeshRenderer>().enabled = true;
                rayswitch = true;
            }
            else
            {
                ray.GetComponent<MeshRenderer>().enabled = false;
                rayswitch = false;
            }
        }
    }



}
