using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionController : MonoBehaviour
{
    public float waitTime = 5f;
    public List<GameObject> gameObjects;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        foreach(GameObject go in gameObjects)
        {
            yield return new WaitForSeconds(waitTime);

            go.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
