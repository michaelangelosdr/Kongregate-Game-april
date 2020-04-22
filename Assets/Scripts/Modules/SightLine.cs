using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightLine : MonoBehaviour
{
    Mesh mesh;
    MeshFilter mFilter;

    [SerializeField] private float FOV;
    [SerializeField] private Vector3 origin;
    [SerializeField] private int rayCount;
    [SerializeField] private float viewDistance;
    [SerializeField] private LayerMask layermask;

    private Vector3[] vertices;
    private Vector2[] uv;
    private float angleIncrease;

    [SerializeField] private Color startColor;
    [SerializeField] private float colorChangeSpeed;
    [SerializeField] private Color FinalColor;
    [SerializeField] private Renderer _renderer;

    private Color Currentcolor;
    private bool isPlayerHit;
    private float StartAngle;
    private float starttime;
   

    int[] triangles;

    [SerializeField]
    [Range(0,1f)]
    private float colorLerpValue;

    [SerializeField]
    private int colorChangeTime;

    private float _timeDelta;

    //For player detection
    StealthModule mod;


    private void Awake()
    {
        mesh = new Mesh();
        mFilter = GetComponent<MeshFilter>();
        vertices = new Vector3[rayCount + 1 + 1]; 
        uv = new Vector2[vertices.Length];
        triangles = new int[rayCount * 3];
    }

    void Start()
    {       
        mFilter.mesh = mesh;
        origin = Vector3.zero;
        isPlayerHit = false;
        starttime = Time.time;
        angleIncrease = FOV / rayCount;
    }

    public void Initialize()
    {

    }
  
    void Update()
    {
        float angle = StartAngle;  
        vertices[0] = origin;
        int vertexIndex = 1;
        int triangleIndex = 0;
        for (int i = 0; i <= rayCount; i++)
        {
            Vector3 vertex;
            RaycastHit2D hit = Physics2D.Raycast(origin, GetVectorFromAngle(angle), viewDistance, layermask);

            if (hit.collider == null)
            {
                vertex = origin + GetVectorFromAngle(angle) * viewDistance;

            }          
            else
            {
                vertex = hit.point;

                if (hit.collider.CompareTag("Player"))
                {
                    Debug.Log("PLAYER HIT");
                    isPlayerHit = true;

                    if(mod == null)
                    {
                        mod = hit.collider.gameObject.GetComponent<StealthModule>();
                    }

                    

                }
            }
            vertices[vertexIndex] = vertex;
            if (i > 0)
            {


                triangles[triangleIndex + 0] = 0;
                triangles[triangleIndex + 1] = vertexIndex - 1;
                triangles[triangleIndex + 2] = vertexIndex;

                triangleIndex += 3;

                Debug.Log("draw");
            }
            vertexIndex++;
            angle -= angleIncrease;

        }

        if(isPlayerHit)
        {
            if(_timeDelta<colorChangeTime)
             _timeDelta += Time.deltaTime;

            mod.Found();
        }
        else
        {
            if (_timeDelta > 0) _timeDelta -= Time.deltaTime;
            
        }

        

        if (colorLerpValue <=1 && colorLerpValue >=0)
        {
            colorLerpValue = (1.0f / colorChangeTime) * _timeDelta;
            if(colorLerpValue>1)
            {
                colorLerpValue = 1;
                Debug.Log("Found!");
            }
            if (colorLerpValue < 0)
            {
                colorLerpValue = 0;
            }


        }

        isPlayerHit = false;

        DrawSightCone();
   
    }


    private void DrawSightCone()
    {
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
       
        _renderer.material.color = Color.LerpUnclamped(startColor, FinalColor, colorLerpValue);
        mesh.RecalculateBounds();
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
