namespace DragRacingGameLib
{
    public interface ICarFactory
    {
        internal ICar<Engine>[] Create();
    }
}
