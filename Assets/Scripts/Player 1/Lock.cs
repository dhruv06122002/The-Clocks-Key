using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{

    public Text Details;
    public int score;
    public GameObject k1, k2, k3, k4, k5, k6, k7, k8, k9, k0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlockdoor()
    {
        Details.text = "O P E N";
    }

    public void one()
    {
        wrong();
        Details.text = "W R O N G";
        Debug.Log("two");
        /*
        score++;
        k1.SetActive(false);
        Details.text = "0 0 0 1";
        Debug.Log("One");*/
    }
    public void two()
    {
        Debug.Log("two");
        if (score == 1)
        {
            score++;
            k7.SetActive(false);
            Details.text = "_ _ 0 2";
        }
        else
        {
            Details.text = "W R O N G";
            wrong();
        }
        /*
        wrong();
        Details.text = "W R O N G";
        Debug.Log("two");*/
    }
    public void three()
    {
        Debug.Log("Three");
        if (score == 2)
        {
            score++;
            k3.SetActive(false);
            Details.text = "_ 0 2 3";
        }
        else
        {
            Details.text = "W R O N G";
            wrong();
        }

    }
    public void four()
    {
        Debug.Log("four");
        Details.text = "W R O N G";
        wrong();
    }
    public void five()
    {
        Debug.Log("five");
        if (score == 3)
        {
            Details.text = "O P E N";
            //UnlockVault();
        }
    }
    public void six()
    {
        wrong();
        Details.text = "W R O N G";
        Debug.Log("six");
    }
    public void seven()
    {
        wrong();
        Details.text = "W R O N G";
        Debug.Log("seven");
    }
    public void eight()
    {
        Details.text = "W R O N G";
        Debug.Log("eight");
        wrong();
    }
    public void nine()
    {
        Details.text = "W R O N G";
        Debug.Log("nine");
        wrong();
    }
    public void zero()
    {
        score++;
        k1.SetActive(false);
        Details.text = "_ _ _ 0";
    }

    public void wrong()
    {
        Debug.Log("wrong");
        score = 0;
        k0.SetActive(true);
        k1.SetActive(true);
        k2.SetActive(true);
        k3.SetActive(true);
        k4.SetActive(true);
        k5.SetActive(true);
        k6.SetActive(true);
        k7.SetActive(true);
        k8.SetActive(true);
        k9.SetActive(true);
    }
}
