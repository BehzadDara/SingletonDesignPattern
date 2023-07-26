using SingletonDesignPattern;

var shapeSingleton = ShapeSingleton.Instance;
shapeSingleton.AddShape(new Circle());
shapeSingleton.AddShape(new Square());

ShapeSingleton.Instance.MoveShapes();
