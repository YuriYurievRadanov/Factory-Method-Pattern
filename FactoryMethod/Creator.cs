namespace FactoryMethod
{
    enum LogistcisEnum
    {
        Railway, Sea, Road
    }

    internal class Creator
    {
        //Factory Method
        public Logistics LogisticsFactory(LogistcisEnum logisticsModel)
        {
            Logistics logistics = null;

            switch (logisticsModel)
            {
                case LogistcisEnum.Railway:
                    logistics = new Railway();
                    break;
                case LogistcisEnum.Sea:
                    logistics = new Sea();
                    break;
                case LogistcisEnum.Road:
                    logistics = new Road();
                    break;
                default:
                    break;
            }

            return logistics;
        }
    }
}
