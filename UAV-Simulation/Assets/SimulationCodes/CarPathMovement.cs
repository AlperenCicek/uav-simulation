using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPathMovement : MonoBehaviour
{
    public GameObject car;
    public GameObject path1;
    public GameObject path2;
    public GameObject path3;
    public bool path1Flag;
    public bool path2Flag;
    public bool path3Flag;

    // Start is called before the first frame update
    void Start()
    {
        path1Flag = true;
        path2Flag = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //car.transform.LookAt(path1.transform);
        if(path1Flag)
            car.transform.position = car.transform.position + new Vector3(0.001f, 0, 0);
        else if(path2Flag)
            car.transform.position = car.transform.position + new Vector3(0, 0, 0.001f);
        else if(path3Flag)
            car.transform.position = car.transform.position + new Vector3(-0.001f, 0, 0);

        Debug.Log(car.transform.position);
        if(path1Flag && path2Flag == false)
        {
            if(0.2f > (car.transform.position.x - path1.transform.position.x))
            {
                if(-0.2f < (car.transform.position.x - path1.transform.position.x))
                {
                    car.transform.Rotate(new Vector3(0, 0, 90));
                    path1Flag = false;
                    path2Flag = true;
                }
            }
        }

        if(0.2f > (car.transform.position.x - path2.transform.position.x))
        {
            if(-0.2f < (car.transform.position.x - path2.transform.position.x))
            {
                if(path2Flag && path3Flag == false)
                {
                    car.transform.Rotate(new Vector3(0, 0, 90));
                    path2Flag = false;
                    path3Flag = true;
                }
            }
        }
            
    }
}
