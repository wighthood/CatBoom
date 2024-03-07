using UnityEngine;

public class GridScript
{
    private float m_CellSize;
    private int[,] m_GridArray;
    private Vector3 m_InitPos;

    public GridScript(int width, int height, float CellSize, Vector3 InitPos)
    {
        this.m_CellSize = CellSize;
        this.m_InitPos = InitPos;

        m_GridArray = new int[width, height];

        for (int i = 0; i < m_GridArray.GetLength(0); i++)
        {
            for (int j = 0; j < m_GridArray.GetLength(1); j++)
            {
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i + 1, j), Color.white, 100f);
            }
        }
        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);
    }

    public Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * m_CellSize + m_InitPos;
    }
        
    public (int,int) GetGridPosition(Vector3 transformPos)
    {
        (int,int) gridPos = ((int)(Mathf.RoundToInt(transformPos.x) / m_CellSize - m_InitPos.x), (int)(Mathf.RoundToInt(transformPos.y) / m_CellSize - m_InitPos.y));
        return gridPos;
    }
}
