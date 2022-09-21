using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyString
    {
        //Tạo phương thức tiền xử lý chuỗi
        //1. Bỏ khoảng trắng dư (đầu cuối, khoảng trắng dư)
        //2. Xóa các ký tự đặc biệt
        //Tìm hiểu khái niệm: Regular expression - Regex in namespace
        public static string XoaKhoangTrangDu(String inputString)
        {
            string result = string.Empty;
            //Xóa khoảng trắng ở đầu và cuối chuỗi InputString
            result = inputString.Trim();
            //Xóa khoảng trắng dư
            string pattern = @"\s+";
            Regex rg = new Regex(pattern);

            result = rg.Replace(result, " ");
            return result;
        }

        public static string XoaKyTuDacBiet(string inputString)
        {
            string result = inputString;
            //Xóa khoảng trắng dư
            string pattern = @"!@#$^&%*()+=-[]\/{}|:<>?,.";
            foreach (char item in pattern.ToCharArray())
            {
                result = result.Replace(item.ToString(), "");
            }
            return result;
        }
    }
}
