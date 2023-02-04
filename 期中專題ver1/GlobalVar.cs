using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中專題ver1
{
    internal class GlobalVar
    {
        public static string OrderNum = "";
        public static string BuyerInfo = "";
        public static string methods = "";
        public static string BuyerName = "";
        public static string BuyerPhone = "";
        public static string BuyerAddress = "";
        public static List<ArrayList> OrderItemList = new List<ArrayList>();
        public static int plasticbags = 0;
        public static int tableware = 0;
        public static string EmployeeID = "";
        public static string OrderPrice = "";
        public static int visitorID = 0; //訪客權限

    }
}
