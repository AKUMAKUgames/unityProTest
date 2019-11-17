using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icemove_2 : MonoBehaviour
{
    public float speed = 5;
    Camera cam;
    icemove_3 move3;
    // Start is called before the first frame update
    void Start()
    {
        move3 = GetComponent<icemove_3>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveVel = moveInput.normalized * speed;
        move3.Move(moveVel);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;

        if (plane.Raycast(ray, out rayDistance))
        {
            Vector3 point = ray.GetPoint(rayDistance);
            move3.rolling(point);
        }
    }
}
