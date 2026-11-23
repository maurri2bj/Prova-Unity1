using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed = 10f;
    Vector3 dir;
    void Start()
    {
        dir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {

        

       


        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Me ha tocado " + collision.gameObject.name);
    }
}
