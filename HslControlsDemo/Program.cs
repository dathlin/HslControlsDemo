using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HslControlsDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main( )
        {
            // 注册控件示例，如果注册失败，你的控件仍然只能使用8个小时
            if(HslControls.Authorization.SetAuthorizationCode( "Your Code" ))
            {
                // 注册成功 Registration Successful;
            }
            else
            {
                // 注册失败 Registration Failed;

            }

            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new FormMainWindow( ) );
        }
    }
}
