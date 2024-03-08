using System.Collections;
using UnityEngine;

public class GridDeplacement : MonoBehaviour
{
    private Vector3 m_StartPos;
    private bool m_IsMoving = false;
    public float m_MoveTime = 0.2f;

    private GridScript m_Grid;

    private void Start()
    {
        LvlManager lvl  = FindAnyObjectByType<LvlManager>();
        if ( lvl != null )
        {
            m_Grid = lvl.m_ScriptGrid;
        }
        else
        {
            Debug.Log("No lvlManager in scene");
        }
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (!m_IsMoving)
        {
            StartCoroutine(MovePlayer((0,-1)));
        }
    }

    IEnumerator MovePlayer((int,int) dir)
    {

        m_StartPos = transform.position;
        (int,int) m_gridPose = m_Grid.GetGridPosition(m_StartPos);
        m_gridPose.Item1 += dir.Item1;
        m_gridPose.Item2 += dir.Item2;

        Vector3 m_EndPos = m_Grid.GetWorldPosition(m_gridPose.Item1, m_gridPose.Item2);

        m_IsMoving = true;
        float m_nextMove = 0f;
        
        while (m_nextMove > m_MoveTime)
        {
            transform.position = Vector3.Lerp(m_StartPos, m_EndPos, m_nextMove / m_MoveTime);
            m_nextMove += Time.deltaTime;
            yield return null;
        }

        transform.position = m_EndPos;
        m_IsMoving = false;
    }
}
