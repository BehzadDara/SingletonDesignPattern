namespace SingletonDesignPattern
{
    public sealed class ShapeSingleton
    {
        private static readonly object padlock = new();

        private ShapeSingleton() { }

        private static ShapeSingleton? instance;
        public static ShapeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    instance ??= new ShapeSingleton();
                    return instance;
                }
            }
        }


        private readonly List<IShape> Shapes = new();
        public void AddShape(IShape shape) 
            => Shapes.Add(shape);
        public void MoveShapes()
            => Shapes.ForEach(x => x.Move());

    }
}
