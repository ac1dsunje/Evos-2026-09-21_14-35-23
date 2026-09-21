using UnityEngine;

namespace _Game.Scripts.World.View
{
[RequireComponent(typeof(Rigidbody2D))]
public class CreatureView : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    
    public Rigidbody2D Rigidbody2D => _rigidbody2D;
}
}