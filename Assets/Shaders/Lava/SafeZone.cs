using UnityEngine;
[ExecuteAlways]
public class SafeZone : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float colliderRadius;
    private void Start()
    {
        colliderRadius = GetComponent<SphereCollider>().radius;
    }

    void Update()
    {

        Shader.SetGlobalVector("_Revealer_Position", _player.position);
        Shader.SetGlobalFloat("_Radius", (colliderRadius * _player.localScale.x));
    }
}