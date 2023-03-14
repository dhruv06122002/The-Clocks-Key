using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerone_Sceneone : MonoBehaviour
{
    [SerializeField] 
    public GameObject Cell;
    public GameObject Wall_1;
    public GameObject Wall_2;
    public GameObject Wall_3;
    public GameObject Wall_4;
    public GameObject LampOn;
    public GameObject LampOff;
    public GameObject WatchOff;
    public GameObject Watchback;
    public GameObject Watchbackwithcell;
    public GameObject WatchOn;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        Cell.SetActive(false);
        LampOff.SetActive(false);
        LampOn.SetActive(true);
        WatchOff.SetActive(true);
        Watchback.SetActive(false);
        WatchOn.SetActive(false);
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LampIsOn()
    {
        Cell.SetActive(true);
        LampOff.SetActive(true);
        LampOn.SetActive(false);
        flag = true;
    }
        
    public void Delay()
    {
        Invoke("LampIsOn", 1.80f);
    }

    public void WatchIsOff()
    {
        if(flag == true)
        {
            Debug.Log("Screen is turned");
            Cell.SetActive(true);
            WatchOff.SetActive(false);
            Watchback.SetActive(true);
            flag = false;
        }
    }

    public void WatchCellInserted()
    {
        if (flag == false)
        {
            Debug.Log("Cell is Inserted");
            Cell.SetActive(false);
            WatchOff.SetActive(false);
            Watchback.SetActive(false);
            Watchbackwithcell.SetActive(true);
            flag = true;
        }
    }

    public void WatchIsOn()
    {
        if (flag == true)
        {
            Debug.Log("Watch is On");
            Cell.SetActive(false);
            WatchOff.SetActive(false);
            Watchback.SetActive(false);
            Watchbackwithcell.SetActive(false);
            WatchOn.SetActive(true);
            flag = false;
        }
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
