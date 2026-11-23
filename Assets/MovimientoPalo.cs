using UnityEngine;
using UnityEngine.InputSystem;
public class MovimientoPalo : MonoBehaviour
{
    public float speed = 10f;
    public enum JUGADOR { A,B}
    public JUGADOR jugador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector2(0, 0);

        if (jugador == JUGADOR.A)
        {
            Debug.Log("jugadori a");
            if (Keyboard.current.wKey.isPressed)
            {
                Debug.Log("Don Eladio");
                dir.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                Debug.Log("Don Eladio2");
                dir.y = -1;
            }
        }
        else
        {
            Debug.Log("jugadori b");
            if (Keyboard.current.upArrowKey.isPressed)
            {
                Debug.Log("Don Eladio");
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                Debug.Log("Don Eladio2");
                dir.y = -1;
            }
        }
      
        transform.position += dir * speed * Time.deltaTime;
    }
}
