using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightLine : MonoBehaviour
{
    Mesh mesh;

    [SerializeField] private float FOV;

    [SerializeField] private Vector3 origin;
    [SerializeField] private int rayCount;
    [SerializeField] private float viewDistance;

    [SerializeField] private LayerMask layermask;

    private float StartAngle;

    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        //FOV = 90f;
      
        origin = Vector3.zero;
        //rayCount = 50;
      
        //viewDistance = 5f;

    }

    void Update()
    {
        float angle = StartAngle;
        float angleIncrease = FOV/rayCount;

        
        Vector3[] vertices = new Vector3[rayCount + 1 + 1];
        Vector2[] uv = new Vector2[vertices.Length];
        int[] triangles = new int[rayCount * 3];


        vertices[0] = origin;
        int vertexIndex = 1;
        int triangleIndex = 0;
        for (int i = 0; i <= rayCount; i++)
        {
            Vector3 vertex;
            RaycastHit2D hit = Physics2D.Raycast(origin, GetVectorFromAngle(angle), viewDistance,layermask);

            if (hit.collider == null)
            {
                vertex = origin + GetVectorFromAngle(angle) * viewDistance;

            }
            else
            {
                vertex = hit.point;
              
            }
            vertices[vertexIndex] = vertex;
            if (i > 0)
            {


                triangles[triangleIndex + 0] = 0;
                triangles[triangleIndex + 1] = vertexIndex - 1;
                triangles[triangleIndex + 2] = vertexIndex;

                triangleIndex += 3;
            }
            vertexIndex++;
            angle -= angleIncrease;

        }


        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

    }

    public void SetOrigin(Vector3 origin)
    {
        this.origin = origin; 
    }

    public void SetAimDirection(Vector3 aimDirection)
    {
        StartAngle = GetAngleFromVectorFloat(aimDirection) - FOV / 2f;
    }

    public float GetAngleFromVectorFloat(Vector3 dir)
    {
        dir = dir.normalized;
        float n = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        if (n < 0) n += 360;

        return n;
    }

    public Vector3 GetVectorFromAngle(float angle)
    {
        float angleRad = angle * (Mathf.PI / 180f);
        return new Vector3(Mathf.Cos(angleRad),Mathf.Sin(angleRad));

    }
}
