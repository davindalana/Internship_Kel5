using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField]
    private GameObject fireBall;
    private PlayerController playerControls;

    
    private void OnEnable()
    {
        playerControls.Enable();
    }
    void Start()
    {
    }

}
