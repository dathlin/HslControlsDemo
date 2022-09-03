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

һ����ҵ����Ŀؼ��⣬����HslCommunicationͨ�����ʹ�ü����Կ��ٿ�����λ�������ϵͳ������Ŀ����Դ���룬��һ��DEMO��Ŀ��Դ���롣���ؼ���֧��windows�汾�Ͱ�׿�棬���������ף���ֹ�ƽ⣬��֧�����棬лл������
## Install From Nuget
```
Install-Package HslControls
```

## ������Ȩ˵��
������Բ��� http://www.hslcommunication.cn/Cooperation

������Ȩ�� ���� **����֧��VIPȺ** �����Ի�ü����룬֧�ֳ�ʱ�����ʹ�á�

������Ȩ������Դ���룩: 
   1. ǩ����ͬ��
   2. ���֧������΢�ţ����п������ԡ�
   3. ��Ʊ��Ŀǰ����ֵ˰��Ʊ��
   4. ���� **HslControls��˿Ⱥ** �����Դ����ͳ��������룬����֧�ָ��¡�
   5. ע�������git�˻�
   6. רҵ��ѵ���⸶�ѣ�1000Ԫ�����1Сʱ����ѵ�ؼ�ʹ�ã��ؼ�������

## ���뼤����
����ĳ������ĵط����뼤���뼴�ɡ�
```
    static class Program
    {
        /// <summary>
        /// Ӧ�ó��������ڵ㡣
        /// </summary>
        [STAThread]
        static void Main( )
        {
            // ע��ؼ�ʾ�������ע��ʧ�ܣ���Ŀؼ���Ȼֻ��ʹ��8��Сʱ
            bool isSuccess = HslControls.Authorization.SetAuthorizationCode( "�����Ȩ��" );
            if (!isSuccess)
            {
                Console.WriteLine( "ע��ʧ��" );
            }

            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new FormLoad( ) );
        }
    }
```
��׿�İ汾�����MainActivity�������뼴��
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
            bool isSuccess = HslControls.Authorization.SetAuthorizationCode( "�����Ȩ��" );
            if (!isSuccess)
            {
                Console.WriteLine( "ע��ʧ��" );
            }
        }
```


## Demo
����ʵ�ֵĿؼ�������ʾ����ЩΪ��ͼ��ʵ����Ҫ�Լ�����demo���У�demo��֧���������8Сʱ����

��׿�������

![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/300.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/301.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/302.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/303.png)

����wpf�汾�Ľ���

![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/2.png)

����winform�汾�Ľ���

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
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/127.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/128.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/129.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/130.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/200.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/201.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/202.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/1000.gif)