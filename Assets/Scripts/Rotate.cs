using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private bool rotate;
    MeshRenderer rend;
    Color original;
    // Start is called before the first frame update
    void Start()
    {
        rotate = true;
        rend = GetComponentInChildren<MeshRenderer>();
        original = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 45f, Space.Self);
        }
    }

    public void InterruptRotation()
    {
        if (rotate)
        {
            rend.material.color = Color.green;
        }
        else
        {
            rend.material.color = original;
        }
        rotate = !rotate;
    }
}
