namespace UndoWithMementoPattern
{
    public interface IOriginator
    {
        IMememto GetMemento();
        void SetMemento(IMememto memento);
    }
}