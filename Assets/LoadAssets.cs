using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public  GameObject redObj;
   
    // Start is called before the first frame update
    void Start()
    {
       GameObject redObj = GameObject.Find("RedPrefab");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
