using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_particle : MonoBehaviour
{

    public float phase = 0;
    public float speed = 2;
    public float maginitude = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (transform.position.x, sineAmount(), transform.position.z);
    }

    public float sineAmount()
    {
        return maginitude * Mathf.Sin(Time.time * speed + phase);
    }
}
