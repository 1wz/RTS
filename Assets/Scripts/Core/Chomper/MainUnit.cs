using UnityEngine;
public class MainUnit : MonoBehaviour, ISelecatable,IAttackable,IUnit
{
    public Transform PivotPoint { get => transform; }
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;
    private float _health = 100;
}