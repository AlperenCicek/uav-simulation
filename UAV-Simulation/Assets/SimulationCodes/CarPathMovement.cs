using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPathMovement : MonoBehaviour
{
    public GameObject car;
    public GameObject path1;
    public GameObject path2;
    public GameObject path3;
    public GameObject path4;
    public GameObject path5;
    public GameObject path6;
    public bool path1Flag;
    public bool path2Flag;
    public bool path3Flag;
    public bool path4Flag;
    public bool path5Flag;
    public bool path6Flag;

    // Start is called before the first frame update
    void Start()
    {
        path1Flag = true;
        path2Flag = false;
        path3Flag = false;
        path4Flag = false;
        path5Flag = false;
        path6Flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //car.transform.LookAt(path1.transform);
        if(path1Flag)
        {
            car.transform.position = car.transform.position + new Vector3(0.001f, 0, 0);
            if(0.2f > (path1.transform.position.x - car.transform.position.x))
            {
                if(-0.2f < (car.transform.position.z - path1.transform.position.z))
                {
                    path1Flag = false;
                    path2Flag = true;
                    car.transform.Rotate(new Vector3(0, 0, 270));
                }
            }
        }
        else if(path2Flag)
        {
            car.transform.position = car.transform.position + new Vector3(0, 0, -0.001f);
            if(0.2f > (path2.transform.position.x - car.transform.position.x))
            {
                if(0.2f > (car.transform.position.z - path2.transform.position.z))
                {
                    car.transform.Rotate(new Vector3(0, 0, 270));
                    path2Flag = false;
                    path3Flag = true;
                }
            }
        }
        else if(path3Flag)
        {
            car.transform.position = car.transform.position + new Vector3(-0.001f, 0, 0);
            if(0.2f < (path3.transform.position.x - car.transform.position.x))
            {
                if(0.2f > (car.transform.position.z - path3.transform.position.z))
                {
                    car.transform.Rotate(new Vector3(0, 0, 90));
                    path3Flag = false;
                    path4Flag = true;
                }
            }
        }
        else if(path4Flag)
        {
            car.transform.position = car.transform.position + new Vector3(0, 0, -0.001f);
            if(0.5f > (path4.transform.position.x - car.transform.position.x))
            {
                if(0.5f > (car.transform.position.z - path4.transform.position.z))
                {
                    car.transform.Rotate(new Vector3(0, 0, 270));
                    path4Flag = false;
                    path5Flag = true;
                }
            }
        }
        else if(path5Flag)
        {
            car.transform.position = car.transform.position + new Vector3(-0.001f, 0, 0);
            if(0.5f < (path5.transform.position.x - car.transform.position.x))
            {
                if(0.5f > (car.transform.position.z - path5.transform.position.z))
                {
                    car.transform.Rotate(new Vector3(0, 0, 270));
                    path5Flag = false;
                    path6Flag = true;
                }
            }
        }
        else if(path6Flag)
        {
            car.transform.position = car.transform.position + new Vector3(0, 0, 0.001f);
            if(0.5f > (path6.transform.position.x - car.transform.position.x))
            {
                if(0.5f < (car.transform.position.z - path6.transform.position.z))
                {
                    car.transform.Rotate(new Vector3(0, 0, 270));
                    path6Flag = false;
                    path1Flag = true;
                }
            }
        }

        
            
    }
}
