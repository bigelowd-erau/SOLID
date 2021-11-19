using UnityEngine;

public class MouseScreenRayProvider : MonoBehaviour, IRayProvider
{
    public Ray CreateRay()
    {
        //Ray creation
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}