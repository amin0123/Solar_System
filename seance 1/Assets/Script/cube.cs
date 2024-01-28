using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class cube : MonoBehaviour
{
    public int A = 0;

    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.Debug.Log(A);
        transform.rotation = Quaternion.Euler(transform.rotation.x * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x * Time.deltaTime, 0, 0);
    }
}
