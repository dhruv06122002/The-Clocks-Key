using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerLetter : MonoBehaviour
{
    public GameObject Letter;
    public GameObject StaticLetter;
    public GameObject Wall_1;
    public GameObject Wall_2;
    public GameObject Wall_3;
    public GameObject Wall_4;
    // Start is called before the first frame update
    void Start()
    {
        StaticLetter.SetActive(true);
        Letter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void letter()
    {
        StaticLetter.SetActive(false);
        Letter.SetActive(true);
    }

    public void Wall1()
    {
        Wall_1.SetActive(true);
        Wall_2.SetActive(false);
        Wall_3.SetActive(false);
        Wall_4.SetActive(false);
    }
    public void Wall2()
    {
        Wall_1.SetActive(false);
        Wall_2.SetActive(true);
        Wall_3.SetActive(false);
        Wall_4.SetActive(false);
    }

    public void Wall3()
    {
        Wall_1.SetActive(false);
        Wall_2.SetActive(false);
        Wall_3.SetActive(true);
        Wall_4.SetActive(false);
    }

    public void Wall4()
    {
        Wall_1.SetActive(false);
        Wall_2.SetActive(false);
        Wall_3.SetActive(false);
        Wall_4.SetActive(true);
    }
}
