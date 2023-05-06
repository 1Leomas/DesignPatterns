using InterfaceSegregationPrinciple;

Shape shape1 = new Square(5);
Shape shape2 = new Circle(3);
Shape shape3 = new Triangle(4, 6);

Console.WriteLine($"Aria patratului: {shape1.Aria()}");
Console.WriteLine($"Aria cercului: {shape2.Aria()}");
Console.WriteLine($"Aria triunghiului: {shape3.Aria()}");

shape3 = new Circle(3);
Console.WriteLine($"Aria cercului: {shape3.Aria()}");
