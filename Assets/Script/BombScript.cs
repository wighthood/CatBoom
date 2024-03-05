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
        yield return new WaitForSeconds(4);

        Instantiate(m_Explosion, transform.position, Quaternion.identity);
        StartCoroutine(CreateExplosion(Vector3.up/2));
        StartCoroutine(CreateExplosion(Vector3.right/2));
        StartCoroutine(CreateExplosion(Vector3.down/2));
        //StartCoroutine(CreateExplosion(Vector3.left/2));
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    IEnumerator CreateExplosion(Vector3 direction)
    {
        for (int i = 1; i <= range; i++)
        {
            RaycastHit hit;
            Physics.Raycast(transform.position + new Vector3(0, range, 0), direction, out hit,i);
            if (!hit.collider)
            {
                Instantiate(m_Explosion, transform.position + (i * direction), m_Explosion.transform.rotation);
            }
            else if (hit.collider.CompareTag("Indestructible") || hit.collider.CompareTag("Wall"))
            {
                break;
            }
            yield return new WaitForSeconds(.01f);
        }
    }
}

