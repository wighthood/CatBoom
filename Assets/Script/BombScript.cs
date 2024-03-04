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
        GameObject m_gameObject;
        yield return new WaitForSeconds(4);
        Instantiate(m_Explosion, transform);
        for (int i = 1; i <= range; i++)
        {
            if ()
            {
                m_gameObject = Instantiate(m_Explosion, transform);
                m_gameObject.transform.position = Vector3.up * i / 2;
            }

            m_gameObject = Instantiate(m_Explosion, transform);
            m_gameObject.transform.position = Vector3.down * i / 2;

            m_gameObject = Instantiate(m_Explosion, transform);
            m_gameObject.transform.position = Vector3.left * i / 2;

            m_gameObject = Instantiate(m_Explosion, transform);
            m_gameObject.transform.position = Vector3.right * i / 2;
        }
        yield return new WaitForSeconds(1);
        Object.Destroy(gameObject);
    }
}

