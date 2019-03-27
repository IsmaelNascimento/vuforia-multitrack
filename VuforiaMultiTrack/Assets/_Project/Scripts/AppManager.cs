using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager Instance;
    [SerializeField] private GameObject capsule;
    public GameObject Capsule
    {
        get { return capsule; }
    }

    private void Awake()
    {
        Instance = this;
    }
}