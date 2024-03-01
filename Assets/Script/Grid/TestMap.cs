using UnityEngine;

public class TestMap : MonoBehaviour
{
    [SerializeField] private float m_Offset;
    [SerializeField] private int m_width;
    [SerializeField] private int m_height;
    [SerializeField] private float m_scale;
    // Start is called before the first frame update
    void Start()
    {
        GridScript gridScript =  new GridScript(m_width,m_height,m_scale, new Vector3 (m_Offset,m_Offset));
    }
}
