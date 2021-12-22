using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Player Player;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        if (Player != null)
            transform.position = Player.transform.position + _offset;
    }
}
