using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGrid : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject Particle;
    private int worldSizeX = 10;
    private int worldSizeY = 10;
    private float gridOffset = 2;
    void Start()
    {
        for (int i = 0; i < worldSizeX; i++)
        {
            for (int j = 0; j < worldSizeY; j++)
            {
                Vector3 pos = new Vector3(i * gridOffset, i*j, j * gridOffset);
                GameObject gridParticle = Instantiate(Particle, pos, Quaternion.identity) as GameObject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
