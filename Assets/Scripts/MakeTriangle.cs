using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTriangle : MonoBehaviour
{
    private Vector3[] vertices, normals;
    private int[] topology;
    // Start is called before the first frame update
    void Start()
    {
        vertices = new Vector3[3];
        normals = new Vector3[3];
        topology = new int[6];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(1, 0, 0);
        vertices[2] = new Vector3(0, 1.5f, 0);

        topology[0] = 0;
        topology[1] = 1;
        topology[2] = 2;
        topology[3] = 0;
        topology[4] = 2;
        topology[5] = 1;


        normals[0] = new Vector3(0, 0, -1);
        normals[1] = new Vector3(0, 0, -1);
        normals[2] = new Vector3(0, 0, -1);
        Mesh mesh = new Mesh();

        mesh.vertices = vertices;
        mesh.triangles = topology;
        mesh.normals = normals;

        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}