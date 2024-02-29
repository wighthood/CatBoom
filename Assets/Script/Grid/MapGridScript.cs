using UnityEngine;

public class MapGridScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GridScript gridScript =  new GridScript(13,13,5);
    }
}
