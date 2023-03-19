using UnityEngine;
using Zenject;
public class UiModelInstaller : MonoInstaller
{
    [SerializeField] private AssetsContext _legacyContext;
    [SerializeField] private Vector3Value _vector3Value;
    [SerializeField] private SelectableValue _selectableValue;
    [SerializeField] private AttackableValue _attackableValue;
    public override void InstallBindings()
    {
        Container.Bind<AttackableValue>().FromInstance(_attackableValue);
        Container.Bind<SelectableValue>().FromInstance(_selectableValue);
        Container.Bind<AssetsContext>().FromInstance(_legacyContext);
        Container.Bind<Vector3Value>().FromInstance(_vector3Value);
        Container.Bind<CommandCreatorBase<IProduceUnitCommand>>()
        .To<ProduceUnitCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IAttackCommand>>()
        .To<AttackCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IMoveCommand>>()
        .To<MoveCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IPatrolCommand>>()
        .To<PatrolCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IStopCommand>>()
        .To<StopCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<ISetRallyPointCommand>>()
        .To<SetRallyPointCommandCreator>().AsTransient();
        Container.Bind<CommandButtonsModel>().AsTransient();
        Container.Bind<BottomCenterModel>().AsTransient();
        Container.Bind<float>().WithId("Chomper").FromInstance(5f);
        Container.Bind<string>().WithId("Chomper").FromInstance("Chomper");

    }
}
