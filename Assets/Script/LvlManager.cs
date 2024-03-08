using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour
{

    public GridScript m_ScriptGrid;

    // Start is called before the first frame update
    private void Awake()
    {
        m_ScriptGrid = new GridScript(13, 13, 0.5f, new Vector2(-3.5f, -3.5f));
    }
}
