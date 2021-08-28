using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vel = velocidade * -6 * Time.deltaTime;
        transform.Rotate(new Vector3(0, 1, 0), vel);
    }
}
