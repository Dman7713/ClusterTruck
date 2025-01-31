using UnityEngine;

public class SticktoTruck : MonoBehaviour
{
    public bool OnPlatform;
    public GameObject otherGameObject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Truck")
        {
            otherGameObject = other.transform.parent.gameObject;
            OnPlatform = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Truck")
        {
            OnPlatform = false;
        }
    }
    public void Update()
    {
        if(OnPlatform)
        {
            transform.position += otherGameObject.transform.forward * Time.deltaTime * otherGameObject.GetComponent<Truck>().MovementSpeed;
        }
    }
}
