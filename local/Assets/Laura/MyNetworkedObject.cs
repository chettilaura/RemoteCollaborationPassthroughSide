using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;

public class MyNetworkedObject : MonoBehaviour
{
    NetworkContext context;

    //cubes start with the mesh renderer disabled!!

   
    //private bool cube1=false;
    //private bool cube2=false;
    //private bool cube3=false;
    //private bool cube4=false;
    //private bool cube5=false;
    //private bool cube6=false;
    //private bool cube7=false;
    //private bool cube8=false;
    //private bool cube9=false;   
    //private bool cube10=false;


    void Start()
    {
        context = NetworkScene.Register(this);
    }

    Vector3 lastPosition;


    void Update()
    {
        if (lastPosition != transform.localPosition && this.gameObject.name == "ray")
        {
            lastPosition = transform.localPosition;
            context.SendJson(new Message()
            {
                position = transform.localPosition,
                rotation = transform.localRotation,
                name = this.gameObject.name
            });
        }
    }
    

    private struct Message
    {
        public Vector3 position;
        public Quaternion rotation;
        public string name;
    }


    // analyze the received message
    public void ProcessMessage(ReferenceCountedSceneGraphMessage message)
    {
        var m = message.FromJson<Message>();
        //Debug.Log("a message received from " + m.name);



        switch (m.name)
        {
            case "Cube1":
                Debug.Log("cube1 was selected");
                //if (cube1 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube1 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube1 = false;
                //}
                break;
            case "Cube2":
                Debug.Log("cube2 was selected");
                //if (cube2 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube2 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube2 = false;
                //}
                break;
            case "Cube3":
                Debug.Log("cube3 was selected");
                //if (cube3 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube3 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube3 = false;
                //}
                break;
            case "Cube4":
                Debug.Log("cube4 was selected");
                //if (cube4 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube4 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube4 = false;
                //}
                break;
            case "Cube5":
                Debug.Log("cube5 was selected");
                //if (cube5 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube5 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube5 = false;
                //}
                break;
            case "Cube6":
                Debug.Log("cube6 was selected");
                //if (cube6 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube6 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube6 = false;
                //}
                break;

            case "Cube7":
                Debug.Log("cube7 was selected");
                //if (cube7 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube7 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube7 = false;
                //}
                break;
            case "Cube8":
                Debug.Log("cube8 was selected");
                //if (cube8 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube8 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube8 = false;
                //}
                break;
            case "Cube9":
                Debug.Log("cube9 was selected");
                //if (cube9 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube9 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube9 = false;
                //}
                break;
            case "Cube10":
                Debug.Log("cube10 was selected");
                //if (cube10 == false)
                //{
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //cube10 = true;
                    StartCoroutine(waitseconds(5));
                //}
                //else
                //{
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    cube10 = false;
                //}
                break;

            case "ray":
                //Debug.Log("ray movement received");

                // Use the message to update the Component
                transform.localPosition = m.position;
                transform.localRotation = m.rotation;

                // Make sure the logic in Update doesn't trigger as a result of this message
                lastPosition = transform.localPosition;
                break;

            default:
                Debug.Log("no cube was selected");
                break;
        }


        IEnumerator waitseconds(int secs)
        {
            yield return new WaitForSeconds(secs);
            gameObject.GetComponent<MeshRenderer>().enabled = false;

        }



    }
}
