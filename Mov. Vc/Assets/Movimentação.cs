using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
    public Transform GO1;
    public float V1 = 5f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (GO1.position - transform.position).normalized*V1*Time.deltaTime;
    }
}
