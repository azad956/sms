using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam2.DAL;
using Exam2.Models;

namespace Exam2.BLL
{
    public class MobileManager
    {
        MobileRepository _mobileRepository = new MobileRepository();
        public bool Save(MobileCls mobile)
        {
            bool isSaved = false;
            isSaved = _mobileRepository.Save(mobile);
            return isSaved;
        }

        public bool Exists(MobileCls mobile)
        {
            bool isSaved = false;
            isSaved = _mobileRepository.Exists(mobile);
            return isSaved;
        }

        public bool Search(MobileCls mobile)
        {
            bool isSaved = false;
            isSaved = _mobileRepository.Search(mobile);
            return isSaved;
        }

        //public bool Search(double lowPrice, double highPrice)
        //{
        //    bool isSaved = false;
        //    isSaved = _mobileRepository.Search(lowPrice, highPrice);
        //    return isSaved;
        //}
        public List<MobileCls> Search( double lowPrice, double highPrice)
        {
            List<MobileCls> mobiles = new List<MobileCls>();
            mobiles = _mobileRepository.Search(lowPrice, highPrice);
            return mobiles;
        }
    }
}
