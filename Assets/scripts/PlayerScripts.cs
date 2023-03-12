using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public Transform ShootingPoint;
    public GameObject Fireball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            Instantiate(Fireball, ShootingPoint.transform.position, Quaternion.identity);
        }
    }
}
