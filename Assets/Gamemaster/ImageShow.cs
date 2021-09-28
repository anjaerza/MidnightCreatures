using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageShow : MonoBehaviour
{
    public Image img3;
    public Image img2;
    public Image img1;
    public GameObject juga;

    void Start()
    {
        img3.enabled = true;
        img2.enabled = false;
        img1.enabled = false;
    }

    void Update()
    {


        if (juga.GetComponent<danoju>().vida==4 || juga.GetComponent<danoju>().vida==3)
        {
            img3.enabled = false;
            img2.enabled = true;
        }
        else if (juga.GetComponent<danoju>().vida == 2 || juga.GetComponent<danoju>().vida == 1)
        {
            img2.enabled = false;
            img1.enabled = true;
        }
    }
}