using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrow : MonoBehaviour
{
    [SerializeField]
    private Transform Tree;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 1; i++)
        {
            Vector3 scale = new()
            {
                x = Mathf.Abs(Mathf.Sin(Time.time * .3f) * .05f),
                y = Mathf.Abs(Mathf.Sin(Time.time * .3f) * .05f),
                z = Mathf.Abs(Mathf.Sin(Time.time * .3f) * .05f)

            };
            transform.localScale = scale;
        }
    }
}