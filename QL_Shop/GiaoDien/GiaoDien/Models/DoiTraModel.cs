using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class DoiTraModel
    {
        private DoiTraControllers _doiControllers = new DoiTraControllers();

        public DataTable GetDataBill(string _maHD)
        {
            return _doiControllers.GetDataBill(_maHD);
        }
    }
}
