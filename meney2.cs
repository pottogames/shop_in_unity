using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public GameObject projectile;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Instantiate(projectile, transform.position, transform.rotation);
    }
}