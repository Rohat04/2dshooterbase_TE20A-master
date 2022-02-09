using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  public float speed = 9001f;

  void Update()
  {
    float xMovement = Input.GetAxisRaw("Horizontal"); // -1 till +1
    float yMovement = Input.GetAxisRaw("Vertical"); // -1 till +1

    Vector2 horizontalMovement = new Vector2(xMovement, 0) * speed;
    Vector2 verticalMovement = new Vector2(0, yMovement) * speed;

    transform.Translate(horizontalMovement + verticalMovement);

    if (Mathf.Abs(transform.position.x) > 5)
    {
      transform.Translate(-horizontalMovement);
    }

  }
}
