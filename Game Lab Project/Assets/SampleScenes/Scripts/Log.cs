using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    public GameObject ob;
    public Mesh mesh;
    private Vector3[] vertices;
    public int i;

    public float test = 0;
    // Start is called before the first frame update
    void Start()
    {
        mesh = ob.GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;
        transform.position = vertices[i];  
    }

    // Update is called once per frame
    void Update()
    {
        test = vertices[i].x;
        transform.position = Vector3.MoveTowards(transform.position, vertices[i], 1000);
    }
}
