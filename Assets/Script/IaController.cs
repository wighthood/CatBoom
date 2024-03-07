using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IaController : MonoBehaviour
{
    public float m_Speed = 0.2f;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x, y, 0) * m_Speed * Time.deltaTime;
    }


}
