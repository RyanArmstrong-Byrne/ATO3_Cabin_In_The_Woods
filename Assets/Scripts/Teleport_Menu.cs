using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport_Menu : MonoBehaviour
{
    [SerializeField] GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);//false to hide, show to true
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //      Debug.Log("tab");
            if (Menu.activeInHierarchy == true)
            {
                Menu.SetActive(false);//flase to hide, show to true
               // Debug.Log("false");
            }
            else 
            {
                Menu.SetActive(true);//flase to hide, show to true
               // Debug.Log("true");
            }
        }
        


    }
}
