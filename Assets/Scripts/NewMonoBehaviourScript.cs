using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.1f);
            // cubo.transform.y += 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0.5f, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0.1f, 0);
        }
    }
}
