﻿using GiaoDien.Unity;
using System.Data;

namespace GiaoDien.Controllers
{

    public class LoginControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetDataLogin( string pUser, string pPass)
        {
            return _unity.filldb("HT_NhanVien_CheckLogin",pUser.ToString(), pPass.ToString());
        }
    }
}
