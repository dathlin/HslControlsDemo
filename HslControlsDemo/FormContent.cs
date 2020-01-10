using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HslControlsDemo
{
    public class FormContent : WeifenLuo.WinFormsUI.Docking.DockContent
    {

        /// <summary>
        /// 控件选择时触发的事件
        /// </summary>
        public event Action<object> OnControlSelected;

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );
            AutoScroll = true;
        }


        public void Control_Click( object sender, EventArgs e )
        {
            OnControlSelected?.Invoke( sender );
        }
    }
}
