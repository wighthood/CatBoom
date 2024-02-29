using UnityEngine;

public class GridScript
{
    private int m_Width;
    private int m_Height;
    private int m_CellSize;
    private int[,] m_GridArray;

    public GridScript (int width, int height, int CellSize)
    {
        this.m_Width = width;
        this.m_Height = height;
        this.m_CellSize = CellSize;

        m_GridArray = new int[width, height];

        for (int i = 0; i < m_GridArray.GetLength(0); i++)
        {
            for (int j = 0; j < m_GridArray.GetLength(1); j++)
            {
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i + 1, j), Color.white, 100f);
            }
        }
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * m_CellSize;
    }
}
