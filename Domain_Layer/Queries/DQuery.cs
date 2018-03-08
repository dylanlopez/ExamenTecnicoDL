using Data_Layer;

namespace Domain_Layer.Queries
{
    public partial class DQuery
    {
        private UnitOfWork UnitOfWork;

        public DQuery()
        {
            UnitOfWork = UnitOfWork.GetInstance;
        }
        public DQuery(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public UnitOfWork GetUnitOfWork()
        {
            return UnitOfWork;
        }
    }
}