

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public GameObject KillaPosition;


    void Update()
    {
        transform.position = new Vector2(KillaPosition.transform.position.x, KillaPosition.transform.position.y); 
        
    }
}
