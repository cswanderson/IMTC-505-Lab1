using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bang");
    }

    [SerializeField]
    private Transform[] _spinSphere;
    [SerializeField]
    private float[] _spinSpeed;
    [SerializeField]
    private float _spinSpherePulseDistance;
    [SerializeField]
    private float _spinSpherePulseSpeed;
    [SerializeField]

    private void Start()
    {
        _spinSpherePulseDistance = .22f;
        _spinSpherePulseSpeed = .78f;
        for (int i = 0; i < _spinSphere.Length; i++) // init a random int for loop for the spining lights spin speed
        {
            _spinSpeed[i] = Random.Range(-50, 50);
        }

    }

    // Update is called once per frame
    private void Update()
    {
        for (int i = 0; i < _spinSphere.Length; i++)
        {
            // Rotate
            Vector3 rotation = new()
            {
                z = _spinSpeed[i] * Time.deltaTime
            };
            _spinSphere[i].Rotate(rotation);
            //Debug.Log("Time " + Mathf.Sin(Time.time));

            // Pulse
            Vector3 scale = new()
            {
                x = Mathf.Sin(Time.time * _spinSpherePulseSpeed) * _spinSpherePulseDistance + 1,
                y = Mathf.Sin(Time.time * _spinSpherePulseSpeed) * _spinSpherePulseDistance + 1,
                z = Mathf.Sin(Time.time * _spinSpherePulseSpeed) * _spinSpherePulseDistance + 1

            };
            _spinSphere[i].localScale = scale;
        }



    }

}