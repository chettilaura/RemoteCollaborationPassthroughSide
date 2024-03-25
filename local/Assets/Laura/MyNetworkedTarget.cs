using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.Messaging;

public class MyNetworkedTarget : MonoBehaviour
{

    NetworkContext context;

    //targets start with the mesh renderer disabled!!


    //private bool targetA = false;
    //private bool targetB = false;
    //private bool targetC = false;
    //private bool targetD = false;
    //private bool targetE = false;
    //private bool targetF = false;
    //private bool targetG = false;
    //private bool targetH = false;
    //private bool targetI = false;
    //private bool targetJ = false;


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
        // analyze the received message
        var m = message.FromJson<Message>();
        Debug.Log("a message received from " + m.name);

        switch (m.name)
        {
            case "TargetA":
                //if (targetA == false)
                //{
                    Debug.Log("targetA is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    //targetA = true;
                    StartCoroutine(waitseconds(5));

                //}
                //else
                //{
                //    Debug.Log("targetA is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetA = false;
                    
                //}
                break;
            case "TargetB":
                //if (targetB == false)
                //{
                    Debug.Log("targetB is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                //targetB = true;
                StartCoroutine(waitseconds(5));

                //}
                //else
                //{
                //    Debug.Log("targetB is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetB = false;

                //}
                break;
            case "TargetC":
                //if (targetC == false)
                //{
                    Debug.Log("targetC is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetC = true;

                //}
                //else
                //{
                //    Debug.Log("targetC is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetC = false;

                //}
                break;
            case "TargetD":
                //if (targetD == false)
                //{
                    Debug.Log("targetD is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetD = true;
                    
                //}
                //else
                //{
                //    Debug.Log("targetD is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetD = false;
                    
                //}
                break;
            case "TargetE":
                //if (targetE == false)
                //{
                    Debug.Log("targetE is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetE = true;
                    
                //}
                //else
                //{
                //    Debug.Log("targetE is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetE = false;
                    
                //}
                break;
            case "TargetF":
                //if (targetF == false)
                //{
                    Debug.Log("targetF is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetF = true;
                    
                //}
                //else
                //{
                //    Debug.Log("targetF is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetF = false;
                    
                //}
                break;
            case "TargetG":

                //if (targetG == false)
                //{
                    Debug.Log("targetG is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetG = true;

                //}
                //else
                //{
                //    Debug.Log("targetG is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetG = false;

                //}
                break;
            case "TargetH":
                //if (targetH == false)
                //{
                    Debug.Log("targetH is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetH = true;
                    
                //}
                //else
                //{
                //    Debug.Log("targetH is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetH = false;
                    
                //}
                break;
            case "TargetI":
                //if (targetI == false)
                //{
                    Debug.Log("targetI is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetI = true;
                    
                //}
                //else
                //{
                //    Debug.Log("targetI is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetI = false;
                    
                //}
                break;
            case "TargetJ":
                //if (targetJ == false)
                //{
                    Debug.Log("targetJ is selected");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    StartCoroutine(waitseconds(5));
                //    targetJ = true;
                    
                //}
                //else
                //{
                //    Debug.Log("targetJ is deselected");
                //    gameObject.GetComponent<MeshRenderer>().enabled = false;
                //    targetJ = false;
                    
                //}
                break;

            default:
                Debug.Log("No target selected");
                break;
        }

    }

    IEnumerator waitseconds(int secs)
    {
        yield return new WaitForSeconds(secs);
        gameObject.GetComponent<MeshRenderer>().enabled = false;

    }

}
