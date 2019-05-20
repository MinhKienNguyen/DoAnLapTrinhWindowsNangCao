﻿using GiaoDien.Controllers;
using System.Data;

namespace GiaoDien.Models
{
    public class NhanvienModel
    {
        NhanvienControllers _nhanvienControllers = new NhanvienControllers();

        /// <summary>
        /// GetEmployees -- tìm kiếm nhân viên theo tên nhân viên để load lên lưới
        /// </summary>
        /// <param name="EmployessName"></param>
        /// <returns></returns>
        public DataTable GetEmployees(string EmployessName)
        {
            return _nhanvienControllers.GetEmployees(EmployessName);
        }

        /// <summary>
        /// GetEmployessCde -- lấy mã nhân viên để ktra khóa chính khi thêm vào
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public DataTable GetEmployessCde(string EmployessCde)
        {
            return _nhanvienControllers.GetEmployessCde(EmployessCde.ToString());
        }

        /// <summary>
        /// GetComboboxDuty -- lấy thông tin chức vụ để load combobox chức vụ
        /// </summary>
        /// <returns></returns>
        public DataTable GetComboboxDuty()
        {
            return _nhanvienControllers.GetComboboxDuty();
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
            return _nhanvienControllers.InsertEmployess(EmployessCde, EmployessName, Set, Adress, User, Pass, Phone, Image, DutyID);
        }


        public bool DeleteEmployess(string EmployessCde, string user)
        {
            return _nhanvienControllers.DeleteEmployess(EmployessCde.ToString(), user.ToString());
        }

        public DataTable GetImage(string EmployessCde)
        {
            return _nhanvienControllers.GetImage(EmployessCde.ToString());
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public DataTable UpdatePassWord(string User, string PassOld, string passNew)
        {
            return _nhanvienControllers.UpdaetPassWord(User, PassOld, passNew);
        }
    }
}
