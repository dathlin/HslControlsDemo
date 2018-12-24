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
            HslControls.Authorization.SetAuthorizationCode( "你的授权码" );

            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new FormLoad( ) );
        }
    }
}
