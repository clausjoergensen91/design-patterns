using Domain;

namespace Specification.Specification_Pattern;
public class UserIsOlderThan18Specification : CompositeSpecification<User>
{
    public override bool IsSatisfiedBy(User candidate)
    {
        return candidate.Age > 18;
    }
}
