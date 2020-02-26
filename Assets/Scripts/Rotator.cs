using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
    {
        left,
        right
    }

public class Rotator : MonoBehaviour
{

    public float speed;
    public Direction direction;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotate = direction == Direction.left ? new Vector3(0,speed, 0) : new Vector3(0, -speed, 0);
        gameObject.transform.Rotate(rotate);
           
    }
}
