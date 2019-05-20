﻿using GiaoDien.Unity;
using System;
using System.Data;

namespace GiaoDien.Controllers
{
    public class NhanvienControllers
    {
        UnityClass _unity = new UnityClass();

        /// <summary>
        /// GetEmployees -- Tìm kiếm nhân viên theo tên nhân viên
        /// </summary>
        /// <param name="EmployessName"></param>
        /// <returns></returns>
        public DataTable GetEmployees(string EmployessName)
        {
            return _unity.filldb("HT_NhanVien_SearchData", EmployessName.ToString());
        }

        /// <summary>
        /// GetEmployessCde -- lấy mã nhân viên để ktra khóa chính khi thêm vào
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public DataTable GetEmployessCde(string EmployessCde)
        {
            return _unity.filldb("HT_NhanVien_GetEmployessCde", EmployessCde.ToString());
        }

        /// <summary>
        /// GetComboboxDuty -- lấy thông tin chức vụ để load combobox chức vụ
        /// </summary>
        /// <returns></returns>
        public DataTable GetComboboxDuty()
        {
            return _unity.filldb("QL_NhomNguoiDung_GetComboboxDuty");
        }

        /// <summary>
        /// InsertEmployess -- Insert thông tin nhân viên vào DB
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <param name="EmployessName"></param>
        /// <param name="Set"></param>
        /// <param name="Adress"></param>
        /// <param name="User"></param>
        /// <param name="Pass"></param>
        /// <param name="Phone"></param>
        /// <param name="Image"></param>
        /// <param name="DutyID"></param>
        /// <returns></returns>
        public DataTable InsertEmployess(string EmployessCde, string EmployessName, string Set, string Adress, string User, string Pass, string Phone, byte[] Image, string DutyID)
        {
            return _unity.filldb("HT_NhanVien_InsertEmployess", EmployessCde, EmployessName, Set, Adress, User, Pass, Phone, Image, DutyID);
        }

        /// <summary>
        /// DeleteEmployess -- xóa nhân viên
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public bool DeleteEmployess(string EmployessCde, string user)
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
            new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                DataTable dtNV = _unity.filldb("HT_NhanVien_Delete", EmployessCde.ToString());
                if (dtNV.Rows.Count <=0 || Convert.ToInt16(dtNV.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                DataTable dtND = _unity.filldb("QL_NguoiDungNhomNguoiDung_DeleteNV", user.ToString());
                if (dtND.Rows.Count <= 0 || Convert.ToInt16(dtND.Rows[0][0].ToString()) <= 0)
                {
                    return false;
                }
                tran.Complete();
            }
            return true;
        }

        public DataTable GetImage(string EmployessCde)
        {
            var result = _unity.filldb("HT_NhanVien_GetImage", EmployessCde.ToString());
            return result;
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public DataTable UpdaetPassWord(string User, string Passodl, string passNew)
        {
            return _unity.filldb("HT_NhanVien_UpdatePassWord", User, Passodl, passNew);
        }
    }
}
