using UnityEngine;

public class Fusion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cube")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.GetComponent<MeshRenderer>().enabled = false;
            AppManager.Instance.Capsule.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Cube")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            other.GetComponent<MeshRenderer>().enabled = true;
            AppManager.Instance.Capsule.SetActive(false);
        }
    }

    /*
   private void OnTriggerStay(Collider other)
   {
       Debug.LogFormat("OnTriggerStay::\n Sou {0} e estou colidindo com {1}", gameObject.name, other.name);
   }

   private void OnCollisionEnter(Collision collision)
   {
       Debug.LogFormat("OnCollisionEnter::\n Sou {0} e colidir com {1}", gameObject.name, collision.gameObject.name);

   }

   private void OnCollisionExit(Collision collision)
   {
       Debug.LogFormat("OnCollisionExit::\n Sou {0} e colidir com {1}", gameObject.name, collision.gameObject.name);

   }

   private void OnCollisionStay(Collision collision)
   {
       Debug.LogFormat("OnCollisionStay::\n Sou {0} e colidir com {1}", gameObject.name, collision.gameObject.name);

   }
   */
}