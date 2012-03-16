namespace AdapterExample.Adapter
{
    using AdapterExample.Consultant;

    /// <summary>
    /// Allows an Enterprise Developer to masquerade as a normal one
    /// </summary>
    public class ConsultantDeveloperAdapter : Developer.IDeveloper
    {
        private readonly Consultant _consultant;

        public ConsultantDeveloperAdapter(Consultant consultant)
        {
            this._consultant = consultant;
        }

        public void EstimateTime()
        {
            this._consultant.PickNumberOutOfAss();
        }

        public void WriteSoftware()
        {
            this._consultant.OverengineerStuff();
        }
    }
}
