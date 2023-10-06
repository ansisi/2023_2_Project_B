using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;

    private EnemytPath thePath;
    private int currentpoint;
    private bool reacheEnd;

    // Start is called before the first frame update
    void Start()
    {
        if(thePath == null)
        {
            thePath = FindObjectOfType<EnemytPath>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(reacheEnd == false )
        {
            transform.LookAt(thePath.points[currentpoint]);

            transform.position =
                Vector3.MoveTowards(transform.position, thePath.points[currentpoint].position, moveSpeed * Time.deltaTime);

            if(Vector3.Distance(transform.position , thePath.points[currentpoint].position)<0.01f)
            {
                currentpoint += 1;
                if(currentpoint >= thePath.points.Length)
                {
                    reacheEnd = true;
                }
            }
        }
    }
}
