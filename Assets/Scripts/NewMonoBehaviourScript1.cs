using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
