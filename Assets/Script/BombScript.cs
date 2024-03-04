using System.Collections;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] private GameObject m_Explosion;
    [SerializeField] private int range;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bombTimer());
    }

    IEnumerator bombTimer()
    {
        yield return new WaitForSeconds(3);
        Instantiate(m_Explosion, transform);
        for (int i = 1; i <= range; i++)
        {
            Instantiate(m_Explosion, transform);
            Instantiate(m_Explosion, transform);
            Instantiate(m_Explosion, transform);
            Instantiate(m_Explosion, transform);
        }
        yield return new WaitForSeconds(2);
        Object.Destroy(gameObject);
    }
}
