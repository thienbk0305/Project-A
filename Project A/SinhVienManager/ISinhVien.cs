using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.SinhVienManager
{
    public interface ISinhVien
    {
        List<SinhVienDataBase> SinhvienGetList(int masv);
        int ProductInsert(SinhVienDataBase sinhvien);
    }
}
