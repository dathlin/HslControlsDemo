<pre>
             ///\      ///\             /////////\              ///\
            //\\/      //\/           //\\\\\\\\//\            //\\/
           //\/       //\/          //\\/       \\/           //\/
          //\/       //\/           \//\                     //\/
         /////////////\/             \//////\               //\/
        //\\\\\\\\\//\/               \\\\\//\             //\/
       //\/       //\/                     \//\           //\/
      //\/       //\/           ///\      //\\/          //\/       //\   
     ///\      ///\/            \/////////\\/           /////////////\/
     \\\/      \\\/              \\\\\\\\\/             \\\\\\\\\\\\\/             Present by Richard.Hu
</pre>

# HslControls.dll
![NuGet Status](https://img.shields.io/nuget/v/HslControls.svg) ![NuGet Download](https://img.shields.io/nuget/dt/HslControls.svg)  ![NetFramework](https://img.shields.io/badge/Language-C%23%207.0-orange.svg) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2019-red.svg) ![copyright status](https://img.shields.io/badge/CopyRight-Richard.Hu-brightgreen.svg) 

一个工业软件的控件库，配套HslCommunication通信组件使用即可以快速开发上位机的软件系统。本项目不是源代码，是一个DEMO项目的源代码。本控件库支持windows版本和安卓版，开发不容易，禁止破解，请支持正版，谢谢合作。
## Install From Nuget
```
Install-Package HslControls
```

## 关于源代码和激活码
具体可以参照 http://www.hslcommunication.cn/Cooperation

激活码 加入 '''技术支持VIP群''' 即可以获得，永久支持更新。
源代码 加入 '''HslControls粉丝群''' 即可以获得，永久支持更新。

## 输入激活码
在你的程序进入的地方输入激活码即可。
```
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main( )
        {
            // 注册控件示例，如果注册失败，你的控件仍然只能使用8个小时
            bool isSuccess = HslControls.Authorization.SetAuthorizationCode( "你的授权码" );
            if (!isSuccess)
            {
                Console.WriteLine( "注册失败" );
            }

            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new FormLoad( ) );
        }
    }
```
安卓的版本在你的MainActivity里面输入即可
```
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

			// code here
            bool isSuccess = HslControls.Authorization.SetAuthorizationCode( "你的授权码" );
            if (!isSuccess)
            {
                Console.WriteLine( "注册失败" );
            }
        }
```


## Demo
初步实现的控件如下所示（有些为动图，实际需要自己下载demo运行，demo仅支持免费运行8小时）：

安卓版的如下

![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/300.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/301.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/302.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/303.png)

这是wpf版本的界面

![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/2.png)

这是winform版本的界面

![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/1.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/100.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/101.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/102.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/103.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/104.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/105.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/106.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/107.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/108.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/109.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/110.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/111.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/112.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/113.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/114.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/115.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/116.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/117.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/118.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/119.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/120.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/121.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/122.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/123.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/124.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/125.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/200.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/201.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/202.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/1000.gif)