namespace HelloWorld.ConsoleApplication
{
    public struct ReadInfo
    {
        private char _character;
        private bool _sollEnden;

        public ReadInfo(char character, bool sollEnden)
        {
            _character = character;
            _sollEnden = sollEnden;
        }

        public char Character
        {
            get { return _character; }
        }

        public bool SollEnden
        {
            get { return _sollEnden; }
        }
    }
}