using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int m_Speed;
    public int m_Radius;
    private static PlayerController instance = null;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private int range;
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
            _gameObject.GetComponent<BombScript>().range = range;
            Instantiate(_gameObject, transform.position, Quaternion.identity);
        }
    }
}
