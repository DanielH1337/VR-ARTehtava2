using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public GameObject tempObject;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 5)
        {
            Debug.Log("MOI");
            tempObject.SetActive(true);
            timer = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "write")
        {
            tempObject = other.gameObject;
            other.gameObject.SetActive(false);
        }
    }
    
}
