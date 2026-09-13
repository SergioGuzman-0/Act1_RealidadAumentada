using UnityEngine;

public class ComportamientoObjetos : MonoBehaviour
{
    [Header("Referencias de Objetos")]
    [Tooltip("Objeto que se encenderá o apagará")]
    public GameObject objetoAAlternar;

    [Tooltip("Objeto que cambiará de posición")]
    public GameObject objetoAMover;

    public void AlternarEstadoObjeto()
    {
        if (objetoAAlternar != null)
        {
          
            objetoAAlternar.SetActive(!objetoAAlternar.activeSelf);
        }
        else
        {
            Debug.LogWarning("No has asignado el 'objetoAAlternar' en el Inspector.");
        }
    }


    public void MoverAPosicionAleatoria()
    {
        if (objetoAMover != null)
        {
            float posX = Random.Range(0f, 20f);
            float posY = Random.Range(0f, 20f);
            float posZ = Random.Range(0f, 20f);

            objetoAMover.transform.position = new Vector3(posX, posY, posZ);
        }
        else
        {
            Debug.LogWarning("No has asignado el 'objetoAMover' en el Inspector.");
        }
    }
}
