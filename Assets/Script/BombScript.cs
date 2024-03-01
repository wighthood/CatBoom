using System.Collections;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bombTimer());
    }

    IEnumerator bombTimer()
    {
        yield return new WaitForSeconds(5);
        Object.Destroy(gameObject);
    }
}
