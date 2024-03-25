using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;

public class MyNetworkedMenu : MonoBehaviour
{
    NetworkContext context;

    private bool menuswitch = true; //menu starts active
    public GameObject menu;

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

        if (m.name == "closemenu")
        {
            Debug.Log("menuswitch was selected");
            if (menuswitch == true)
            {
                Debug.Log("menu disabled");
                menu.SetActive(false);
                menuswitch = false;
            }
            else
            {
                Debug.Log("menu enabled");
                menu.SetActive(true);
                menuswitch = true;
            }
        }
    }
}
