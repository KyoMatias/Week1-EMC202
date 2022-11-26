using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        var novice = new Novice(experience: 300, name: "Steven");
        Debug.Log(novice.GetProperties());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
