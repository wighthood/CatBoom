using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour
{

    private GridScript m_ScriptGrid;
    // Start is called before the first frame update
    void Start()
    {
        GridScript gridMap = new GridScript(13, 13, 0.5f, new Vector2(-3.25f, -3.25f));
    }
}
