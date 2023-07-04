using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class GenerateGrid : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject Particle;
    private int worldSizeX = 10;
    private int worldSizeY = 10;
    private double gridOffset = 2;
    void Start()
    {
        int ct = 0;
        double[] phases = Linspace(-Mathf.PI, Mathf.PI, 10);

        for (int i = 0; i < worldSizeX; i++)
        {
            for (int j = 0; j < worldSizeY; j++)
            {
                Vector3 pos = new Vector3((float)(i * gridOffset), 0, (float)(j * gridOffset));
                GameObject gridParticle = Instantiate(Particle, pos, Quaternion.identity) as GameObject;
                gridParticle.GetComponent<move_particle>().phase = phases[ct++%10];
            }
            ct++;
        }
    }

    public static double[] Linspace(double start, double end, long numPoints)
    {
        double spacing = (end - start) / numPoints;
        double[] numbers = new double[numPoints];

        for (int i = 0; i < numPoints; i++)
        {
            numbers[i] = start + i * spacing;
        }
        return numbers;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
