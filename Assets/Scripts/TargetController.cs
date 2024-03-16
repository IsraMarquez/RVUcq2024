using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{

    public GameObject[] WayPoints;

    public float target_Speed = 2;

    int way_PointsIndex = 0;


    void Update()
    {
        MovePlatform();
    }

    void MovePlatform() 
    {
        if (Vector3.Distance(transform.position, WayPoints[way_PointsIndex].transform.position) < 0.1f) 
        {
            way_PointsIndex++;

            if(way_PointsIndex >= WayPoints.Length) 
            {
                way_PointsIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, WayPoints[way_PointsIndex].transform.position, target_Speed*Time.deltaTime);
    }

}
