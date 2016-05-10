﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOAD_HR_System.Model;
using OOAD_HR_System.Service;

namespace OOAD_HR_System.Controller
{
    public class LoginController
    {

        private LoginModel _loginModel = new LoginModel();
        private AccountService _accountService = new AccountService();

        // 建構子
        public LoginController()
        {

        }

        // 判斷帳號密碼是否符合資料庫中的資料
        public Boolean judgeAccountAndPassword(String account, String password)
        {
            _loginModel = _accountService.searchByAccount(account);
            if (account == _loginModel.getAccount() && password == _loginModel.getPassword())
                return true;
            else
                return false;
        }

    }
}