using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int m_Speed;
    private static PlayerController instance = null;
    [SerializeField] private GameObject _Bomb;
    public int range;
    public static PlayerController Instance => instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
    }

    private void BombDrop()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Bomb.GetComponent<BombScript>().range = range;
            Instantiate(_Bomb, transform.position, Quaternion.identity);
        }
    }
}
