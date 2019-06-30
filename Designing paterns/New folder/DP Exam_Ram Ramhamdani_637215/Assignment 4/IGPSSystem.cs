namespace Assignment_4
{
    interface IGPSSystem
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void UpdatePosition();
    }
}
