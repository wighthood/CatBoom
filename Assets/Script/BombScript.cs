using System.Collections;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] private GameObject m_Explosion;
    [SerializeField] public int range;
    [SerializeField] private LayerMask m_layerMask;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bombTimer());
    }

    IEnumerator bombTimer()
    {
        yield return new WaitForSeconds(4);

        Instantiate(m_Explosion, transform.position, Quaternion.identity);
        StartCoroutine(CreateExplosion(Vector3.up));
        StartCoroutine(CreateExplosion(Vector3.right));
        StartCoroutine(CreateExplosion(Vector3.down));
        StartCoroutine(CreateExplosion(Vector3.left));
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    IEnumerator CreateExplosion(Vector3 direction)
    {
        for (int i = 1; i <= range; i++)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction,i,m_layerMask);
            if (!hit.collider)
            {
                Instantiate(m_Explosion, transform.position + (0.5f*i* direction), m_Explosion.transform.rotation);
            }
            else
            {
                if(hit.collider.CompareTag("Wall"))
                {
                    Destroy(hit.collider.transform.gameObject);
                }
                break;
            }
            yield return new WaitForSeconds(.01f);
        }
    }
}

