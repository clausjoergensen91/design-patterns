using Domain;
using Specification.Specification_Pattern;

var userOlderThan18 = User.Create(20);
var userIs18 = User.Create(18);
var userYoungerThan18 = User.Create(10);

var userIsOlderThan18Specification = new UserIsOlderThan18Specification();

Console.WriteLine($"User is older than 18: {userIsOlderThan18Specification.IsSatisfiedBy(userOlderThan18)}");
Console.WriteLine($"User is 18: {userIsOlderThan18Specification.IsSatisfiedBy(userIs18)}");
Console.WriteLine($"User is younger than 18: {userIsOlderThan18Specification.IsSatisfiedBy(userYoungerThan18)}");