using Unity.VisualScripting;
using UnityEngine;

public class Limites : MonoBehaviour
{
    public float LimitMin;
    public float LimitMax;
    void Update()
    {
        if (transform.position.y < LimitMax)
        {
            transform.position = new Vector3(transform.position.x, LimitMax);
        }
        if (transform.position.y > LimitMin)
        {
            transform.position = new Vector3(transform.position.x, LimitMin);
        }
    }
}