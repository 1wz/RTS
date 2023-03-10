using System;
using Zenject;
public class AttackCommandCreator :
CommandCreatorBase<IAttackCommand>
{
    [Inject] private AssetsContext _context;
    protected override void
    classSpecificCommandCreation(Action<IAttackCommand> creationCallback)
    {
        creationCallback?.Invoke(_context.Inject(new
        AttackCommand()));
    }
}
