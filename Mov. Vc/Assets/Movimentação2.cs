using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação2 : MonoBehaviour
{
    public List<Transform> place = new List<Transform>();
    Transform finalplace;
    int position = 0;
    bool voltar;
    // Start is called before the first frame update
    void Start()
    {
        finalplace = place[position];
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, finalplace.position) > 0.2f)
            transform.position += (finalplace.position - transform.position).normalized * 8f * Time.deltaTime;
        else
            ChangePatrolPoint();
    }
    void ChangePatrolPoint()
    {
        if (!voltar)
            position++;
        else
            position--;

        if (position >= place.Count)
        {
            position = (place.Count - 1);
            voltar = true;
        }
        else if (position < 0)
        {
            position = 0;
            voltar = false;
        }

        finalplace = place[position];
    }
}
