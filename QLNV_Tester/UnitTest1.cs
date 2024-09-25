using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNV_VQT;

namespace QLNV_Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            var login = new frm_dangnhap();

            Assert.IsNull(login.Username, "Please fill textbox username !!");
            Assert.IsNull(login.pw, "Please fill textbox password !!");
        }
    }
}
