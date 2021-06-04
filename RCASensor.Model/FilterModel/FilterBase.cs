using System.Linq;

namespace RCASensor.Model.FilterModel
{
    public abstract class FilterBase
    {
        private int _page = 1;
        private int _amountItemsShow = 10;

        public IQueryable<T> Pagination<T>(IQueryable<T> listQueryable)
        {
            var skipValue = Page * AmountItemsShow;
            skipValue -= AmountItemsShow;

            return listQueryable.Skip(skipValue).Take(AmountItemsShow);
        }

        public int Page 
        { 
            get
            {
                return _page;
            }

            set
            {
                _page = value;
            }
        }
        public int AmountItemsShow
        {
            get
            {
                return _amountItemsShow;
            }

            set
            {
                _amountItemsShow = value;
            }
        }
    }
}
