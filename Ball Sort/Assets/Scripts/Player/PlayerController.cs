using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float speed;
    public static float hAxis;
    public static float vAxis;

    public static bool openDoor;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.E)){
            openDoor = true;
        }
    }

    private void FixedUpdate() {
        _rb.velocity = new Vector2(hAxis,vAxis) * speed;
    }

}
