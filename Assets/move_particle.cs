using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_particle : MonoBehaviour
{

    public double phase = 0;
    public double speed = 2;
    public double maginitude = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (transform.position.x, (float)sineAmount(), transform.position.z);
    }

    public double sineAmount()
    {
        return maginitude * Mathf.Sin((float)(Time.time * speed + phase));
    }
}
