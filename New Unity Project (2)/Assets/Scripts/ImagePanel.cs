using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePanel : MonoBehaviour
{

    public GameObject Images;


    public void OpenPanel()
    {
        if (Images != null)
        {
            bool isActive = Images.activeSelf;

            Images.SetActive(!isActive);
        }
    }
}
