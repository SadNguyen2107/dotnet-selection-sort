namespace SN_Program
{
    class StopWatch
    {
        // Attribute
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime
        {
            get { return this.startTime; }
        }

        public DateTime EndTime
        {
            get { return this.endTime; }
        }

        // Constructor
        public StopWatch()
        {
            this.startTime = DateTime.Now;
        }

        public void Start()
        {
            this.startTime = DateTime.Now;
        }

        public void Stop()
        {
            this.endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            return (this.EndTime - this.StartTime).TotalMilliseconds;
        } 
    }
}