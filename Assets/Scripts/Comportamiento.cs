using UnityEngine;
using UnityEngine.UI;

public class Comportamiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Image imagen;
    public void Imagen()
    {
        imagen.color = Color.pink;
    }

    void Start()
    {
        Debug.Log("Hola");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
