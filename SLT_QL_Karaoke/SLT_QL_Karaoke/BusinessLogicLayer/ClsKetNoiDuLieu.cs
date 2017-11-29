using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ClsKetNoiDuLieu
    {
        
        public string KetNoiDuLieu()
        {
            string sChuoiKetNoi = @"Data Source=HOANGDUY;Initial Catalog=AP;Integrated Security=True";
            return sChuoiKetNoi;
        }
    }
}
