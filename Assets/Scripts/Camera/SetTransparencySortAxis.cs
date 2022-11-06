using UnityEngine;
using AC;

public class SetTransparencySortAxis : MonoBehaviour
{

	void Start ()
	{
		KickStarter.CameraMain.transparencySortMode = TransparencySortMode.CustomAxis;
		KickStarter.CameraMain.transparencySortAxis = Vector3.up;
	}

}