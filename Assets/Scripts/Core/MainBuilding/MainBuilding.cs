using UnityEngine;
public class MainBuilding : /*CommandExecutorBase<IProduceUnitCommand>,*/MonoBehaviour, ISelecatable,IAttackable
{
    public Transform PivotPoint { get => transform; }

    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    //[SerializeField] private Transform _unitsParent;
    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    private float _health = 1000;
    public Vector3 RallyPoint { get; set; }

    public void RecieveDamage(int amount)
    {
        if (_health <= 0)
        {
            return;
        }
        _health -= amount;
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
    /*
    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0,
        Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
    }
    */
}
