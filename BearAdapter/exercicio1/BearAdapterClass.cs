using System;

namespace BearAdapter
{
    public class BearAdapterClass : IDog
        {
            private IBear bear;

            public void Bark()
            {
                bear.Roar();
            }
            void Fetch(object objectToFetch)
            {
                bear.LookAt(objectToFetch);
                bear.GoTowards(objectToFetch);
                bear.TryEat(objectToFetch); 
            }
            public BearAdapterClass(IBear bear)
            {
                this.bear = bear;
            }
        }
}