﻿using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
   public class NhaCungCapControllers
    {
        UnityClass _unity = new UnityClass();
        /// <summary>
        /// load dữ liệu theo tên
        /// </summary>
        /// <param name="EmployessName"></param>
        /// <returns></returns>
        public DataTable GetEmployees(string EmployessName)
        {
            return _unity.filldb("HH_NhaCungCap_Data", EmployessName.ToString());
        }
        /// <summary>
        /// GetEmployessCde -- lấy mã NCC để ktra khóa chính khi thêm vào
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public DataTable GetEmployessCde(string EmployessCde)
        {
            return _unity.filldb("HH_NhaCungCap_GetEmployessCde", EmployessCde.ToString());
        }
        public DataTable InsertEmployess(string ma, string ten, string diachi, string sdt)
        {
            return _unity.filldb("HH_NhaCungCap_InsertEmployess", ma, ten, diachi, sdt);
        }
        public bool DeleteEmployess(string ma)
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                DataTable dtNV = _unity.filldb("HH_NhaCungCap_Delete", ma.ToString());
                if (dtNV.Rows.Count <= 0 || Convert.ToInt16(dtNV.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }             
                tran.Complete();
            }
            return true;
        }

    }
}
