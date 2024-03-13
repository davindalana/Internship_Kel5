using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject shootBall;
    public Transform shootPoint;

    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log(shootPoint.position);
            Instantiate(shootBall, shootPoint.position, transform.rotation);
        }
    }
}
