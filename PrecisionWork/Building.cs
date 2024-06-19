namespace PrecisionWork
{
    internal class Building
    {
        private uint _size;
        private uint _floorCount;

        public uint GetFloorCount() => _floorCount;

        public uint GetSize() => _size;

        public Building(uint height, uint floorCount)
        {
            _size = height;
            _floorCount = floorCount;
        }

        public Building(uint floorCount)
        {
            _size = 3 * floorCount;
            _floorCount = floorCount;
        }

        public float GetFloorMaxSize()
        {
            return (float)_size / _floorCount;
        }
    }
}
