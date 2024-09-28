using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNV_LTH;  

namespace QLNV_Tester1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            // Khởi tạo form đăng nhập
            var login = new frm_dangnhap();

            // Giả định rằng frm_DangNhap có các thuộc tính công khai cho Username và Password
            Assert.AreEqual(string.Empty, login.Username, "Vui lòng điền tên người dùng vào ô văn bản!");
            Assert.AreEqual(string.Empty, login.pw, "Vui lòng điền mật khẩu vào ô văn bản!");
        }
    }
}
