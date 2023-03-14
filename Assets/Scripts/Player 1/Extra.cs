using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour
{
    public GameObject Lock;
    // Start is called before the first frame update
    void Start()
    {
        Lock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Locks()
    {
        Lock.SetActive(true);
    }
}
