using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerの動き
/// </summary>
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D Rig;
    float Speed = 700;

    private void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var hori = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        var vert = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        Rig.velocity = new Vector2(hori,vert);
    }
}
