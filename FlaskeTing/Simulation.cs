namespace FlaskeTing
{
    public class Simulation
    {
        public int WantedVolume { get; }
        public Bottle Bottle1 { get; }
        public Bottle Bottle2 { get; }

        public bool IsSolved => Bottle1.Content + Bottle2.Content == WantedVolume
                             || Bottle1.Content == WantedVolume 
                             || Bottle2.Content == WantedVolume;

        public Simulation(int wantedVolume, int volumeBottle1, int volumeBottle2)
        {
            WantedVolume = wantedVolume;
            Bottle1 = new Bottle(volumeBottle1);
            Bottle2 = new Bottle(volumeBottle2);
        }


        public void Run()
        {
            var numberOfOperations = 1;
            while (true)
            {
                var operationSet = new OperationSet(numberOfOperations, this);
                operationSet.RunAll();
                if (IsSolved)
                {
                    operationSet.Show();
                    break;
                }
                numberOfOperations++;
            }
        }
    }
}
