using System;
using Zenject;
public class PatrolCommandCreator :
CommandCreatorBase<IPatrolCommand>
{
    [Inject] private AssetsContext _context;
    protected override void
    classSpecificCommandCreation(Action<IPatrolCommand> creationCallback)
    {
        creationCallback?.Invoke(_context.Inject(new
        PatrolCommand()));
    }
}
