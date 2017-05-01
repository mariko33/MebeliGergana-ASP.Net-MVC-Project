using MebeliGergana.Data;
using MebeliGergana.Data.Interfaces;

namespace MebeliGergana.Services
{
    public abstract class Service
    {
        public Service()
        {
            this.Context = new MebeliGerganaContext();
        }
        protected MebeliGerganaContext Context { get; }


        //public Service(IMebeliGerganaContext context)
        //{
        //    this.Context = context;
        //}

        //protected IMebeliGerganaContext Context { get; set; }
    }
}