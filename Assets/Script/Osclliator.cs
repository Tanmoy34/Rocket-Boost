using UnityEngine;

public class Ossilator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;
    [SerializeField] float Speed = 1f;


    Vector3 Startpoint;
    Vector3 EndPoint;
    
    float movementFactor;
       
    void Start()
    {
        Startpoint = transform.position;
        EndPoint = Startpoint  + movementVector;
    }

    
    void Update()
    {
        movementFactor = Mathf.PingPong(Time.time * Speed,1f); 
        transform.position = Vector3.Lerp(Startpoint,EndPoint,movementFactor);
    }
}
