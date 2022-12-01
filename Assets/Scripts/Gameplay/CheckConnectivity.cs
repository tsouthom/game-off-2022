using UnityEngine;


public class CheckConnectivity : MonoBehaviour 
{
    public static bool isConnected { get; private set; } = true;

    void PostUpdate()
    {
        isConnected = Application.internetReachability != NetworkReachability.NotReachable;
    }
}
