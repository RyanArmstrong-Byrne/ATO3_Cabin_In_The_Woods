using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;


public class Teleportation : MonoBehaviour
{

    [SerializeField] Transform[] telLoc;
    [SerializeField] GameObject Player;

    private NavigationWaypoint waypoint;
    private void Start()
    {
        telLoc[0].GetComponent<NavigationWaypoint>().Activate();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            telLoc[0].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            telLoc[1].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            telLoc[2].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            telLoc[3].GetComponent<NavigationWaypoint>().Activate(); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            telLoc[4].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            telLoc[5].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            telLoc[6].GetComponent<NavigationWaypoint>().Activate();
        }
    }

}
